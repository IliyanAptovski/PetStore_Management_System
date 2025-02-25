using Newtonsoft.Json;
using PetStore.Business;
using PetStore.Data.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public partial class UpdateOrder : Form
    {
        private readonly RestClient _client;
        private readonly ProductBusiness productBusiness = new ProductBusiness();

        public string FirebaseClientId { get; set; }

        public UpdateOrder()
        {
            InitializeComponent();
            _client = new RestClient("https://petstore-management-system-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        // Update client personal info
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirebaseClientId))
            {
                MessageBox.Show("Error: Client ID is missing.");
                return;
            }

            try
            {
                // Retrieve all pets from Firebase to find the pet by ClientId
                var request = new RestRequest("pets.json", Method.Get);  // Get all pets
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    // Deserialize the pets data and search for the pet with the matching ClientId
                    var pets = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(response.Content);
                    var petToUpdate = pets.FirstOrDefault(p => p.Value.ClientId == FirebaseClientId);

                    if (petToUpdate.Key != null)
                    {
                        // Prepare the updated client information
                        var updatedClient = new
                        {
                            ClientName = nameRichTextBox.Text,
                            ClientLastName = lastNameRichTextBox.Text,
                            ClientMail = emailRichTextBox.Text
                        };

                        var updatedClientJson = JsonConvert.SerializeObject(updatedClient);

                        // Send a PATCH request to update the client data of the pet
                        var updateRequest = new RestRequest($"pets/{petToUpdate.Key}.json", Method.Patch);
                        updateRequest.AddParameter("application/json", updatedClientJson, ParameterType.RequestBody);

                        var updateResponse = await _client.ExecuteAsync(updateRequest);

                        if (updateResponse.IsSuccessful)
                        {

                            // Show FinalizedOrder and pass the FirebaseClientId
                            var finalizedOrder = new FinalizedOrder
                            {
                                FirebaseClientId = FirebaseClientId
                            };
                            finalizedOrder.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error updating client: " + updateResponse.ErrorMessage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Client not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Error retrieving pets data.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void secondLineLbl_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
