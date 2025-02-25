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
                // Create new client
                Client client = new Client(nameRichTextBox.Text, lastNameRichTextBox.Text, emailRichTextBox.Text);

                // Create new list of products
                List<Product> clientProducts = new List<Product>(products);

                // Generate unique ClientId
                string clientId = Guid.NewGuid().ToString();

                // Combine client and product data for Firebase
                var pet = new
                {
                    ClientId = clientId,
                    ClientName = client.Name,
                    ClientLastName = client.LastName,
                    ClientMail = client.Mail,
                    Products = clientProducts.Select(p => new
                    {
                        ProductId = Guid.NewGuid().ToString(),
                        ProductName = p.Name,
                        ProductPrice = p.Price,
                        ProductCount = p.Count
                    }).ToList()
                };

                GetClientID = clientId; // Store the client ID

                // Serialize pet data for Firebase
                var petJson = JsonConvert.SerializeObject(pet);

                // Send the data to Firebase
                var request = new RestRequest("pets.json", Method.Post);
                request.AddParameter("application/json", petJson, ParameterType.RequestBody);
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    // Create order with the correct Client ID
                    Order order = new Order(GetClientID)
                    {
                        GetClient = client,
                        GetClientItems = clientProducts
                    };

                    order.Show();

                    // Clear the products list
                    products.Clear();

                    // Close current form
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: " + response.ErrorMessage);
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
                itemsRichTextBox.AppendText($"{product.Dispaly()}\n");
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
