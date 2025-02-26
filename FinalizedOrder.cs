using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetStore.Business;
using Newtonsoft.Json;

namespace PetStore
{
    public partial class FinalizedOrder : Form
    {
        private readonly ProductBusiness _productBusiness = new ProductBusiness();
        public string FirebaseClientId { get; set; }

        public FinalizedOrder()
        {
            InitializeComponent();
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

            // Fetch client order details from Firebase
            var pets = await _productBusiness.GetPetsFromFirebaseAsync();

            if (pets != null)
            {
                // Find the pet by matching the ClientId
                var petToUpdate = pets.FirstOrDefault(p => p.Value.ClientId == FirebaseClientId);

                if (petToUpdate.Key != null)
                {
                    // Data found, now display in the DataGridView
                    var petData = petToUpdate.Value;

                    // Create a DataTable to hold the client and product data
                    DataTable dataTable = new DataTable();

                    // Add columns to the DataTable
                    dataTable.Columns.Add("ClientName", typeof(string));
                    dataTable.Columns.Add("ClientLastName", typeof(string));
                    dataTable.Columns.Add("ClientMail", typeof(string));
                    dataTable.Columns.Add("ProductName", typeof(string));
                    dataTable.Columns.Add("ProductPrice", typeof(decimal));
                    dataTable.Columns.Add("ProductCount", typeof(int));

                    // Extract client info and products
                    string clientName = petData.ClientName;
                    string clientLastName = petData.ClientLastName;
                    string clientMail = petData.ClientMail;

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
                MessageBox.Show("Error: Unable to fetch data from Firebase.");
            }
        }
    }
}
