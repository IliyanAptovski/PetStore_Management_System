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
    public partial class ShoppingCart : Form
    {
        public string GetClientID { get; set; }

        private RestClient _client;

        private ProductBusiness productBusiness = new ProductBusiness();
        List<Product> products = new List<Product>();
        public ShoppingCart()
        {
            InitializeComponent();
            InitializeFirebaseClient();  // Initialize the Firebase client
        }

        private void InitializeFirebaseClient()
        {
            string firebaseUrl = "https://petstore-management-system-default-rtdb.europe-west1.firebasedatabase.app/";

            // Initialize the RestClient to send requests to Firebase
            _client = new RestClient(firebaseUrl);
        }

        public List<Product> GetProducts { get; set; }
        private void lineLbl_Click(object sender, EventArgs e)
        {

        }

        private async void buyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameRichTextBox.Text) ||
                    string.IsNullOrWhiteSpace(lastNameRichTextBox.Text) ||
                    string.IsNullOrWhiteSpace(emailRichTextBox.Text) ||
                    products == null || !products.Any())
                {
                    MessageBox.Show("Please enter all client details and add at least one product.");
                    return;
                }

                // Create new client instance
                var client = new Client
                {
                    Name = nameRichTextBox.Text,
                    LastName = lastNameRichTextBox.Text,
                    Mail = emailRichTextBox.Text
                };

                // Prepare product list for Firebase
                var clientProducts = products.Select(p => new
                {
                    ProductId = Guid.NewGuid().ToString(), // Assign unique Product ID
                    ProductName = p.Name,
                    ProductPrice = p.Price,
                    ProductCount = p.Count
                }).ToList();

                // Create Firebase data object
                var petData = new
                {
                    ClientName = client.Name,
                    ClientLastName = client.LastName,
                    ClientMail = client.Mail,
                    Products = clientProducts
                };

                // Serialize data for Firebase
                var petJson = JsonConvert.SerializeObject(petData);

                // Send POST request to Firebase (new entry)
                var request = new RestRequest("pets.json", Method.Post);
                request.AddParameter("application/json", petJson, ParameterType.RequestBody);
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    // Extract Firebase-generated ClientId
                    var firebaseResponse = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
                    if (firebaseResponse != null && firebaseResponse.ContainsKey("name"))
                    {
                        GetClientID = firebaseResponse["name"]; // Firebase-generated ID
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve client ID from Firebase.");
                        return;
                    }

                    // Create order instance
                    var order = new Order(GetClientID)
                    {
                        GetClient = client,
                        GetClientItems = products
                    };

                    order.Show();

                    // Clear product list and close the form
                    products.Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error saving order: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Display order details
        private void ShoppingCart_Load(object sender, EventArgs e)
        {
            products.AddRange(GetProducts);
            foreach (Product product in GetProducts)
            {
                itemsRichTextBox.AppendText($"{product.Display()}\n");
            }
        }

        private void itemsRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondLineLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
