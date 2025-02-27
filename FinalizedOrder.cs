using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetStore.Business;
using Newtonsoft.Json;
using System.Collections.Generic;
using PetStore.Data.Models;
using RestSharp;

namespace PetStore
{
    public partial class FinalizedOrder : Form
    {
        private readonly ProductBusiness _productBusiness = new ProductBusiness();
        private RestClient _client;  // Declare RestClient
        public string FirebaseClientId { get; set; }

        public FinalizedOrder()
        {
            InitializeComponent();
            _client = new RestClient("https://petstore-management-system-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        // Load finalized order details
        private async void FinalizedOrder_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirebaseClientId))
            {
                MessageBox.Show("Error: Client ID is missing.");
                return;
            }

            // Generate order number
            orderNumberTextLbl.Text = $"Order #{new Random().Next(100000, 999999)}";

            try
            {
                // Fetch the specific pet/client data by FirebaseClientId
                var request = new RestRequest($"pets/{FirebaseClientId}.json", Method.Get);  // Get pet by FirebaseClientId
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
                {
                    // Deserialize the response into the expected client and product structure
                    var petData = JsonConvert.DeserializeObject<dynamic>(response.Content);

                    // Check if pet data exists
                    if (petData != null)
                    {
                        // Create a DataTable to hold the client and product data
                        DataTable dataTable = new DataTable();

                        // Add columns to the DataTable
                        dataTable.Columns.Add("ClientName", typeof(string));
                        dataTable.Columns.Add("ClientLastName", typeof(string));
                        dataTable.Columns.Add("ClientMail", typeof(string));
                        dataTable.Columns.Add("ProductName", typeof(string));
                        dataTable.Columns.Add("ProductPrice", typeof(decimal));
                        dataTable.Columns.Add("ProductCount", typeof(int));

                        // Extract client info
                        string clientName = petData.ClientName;
                        string clientLastName = petData.ClientLastName;
                        string clientMail = petData.ClientMail;

                        // Extract product data
                        var products = petData.Products;
                        if (products != null)
                        {
                            foreach (var product in products)
                            {
                                string productName = product.ProductName;
                                decimal productPrice = product.ProductPrice;
                                int productCount = product.ProductCount;

                                // Add rows to DataTable for each product
                                dataTable.Rows.Add(clientName, clientLastName, clientMail, productName, productPrice, productCount);
                            }
                        }

                        // Bind the DataTable to the DataGridView
                        orderDataGridView.DataSource = dataTable;
                        orderDataGridView.ReadOnly = true;
                        orderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else
                    {
                        MessageBox.Show("No order data found for the given client.");
                    }
                }
                else
                {
                    MessageBox.Show("Error retrieving pet data from Firebase.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
