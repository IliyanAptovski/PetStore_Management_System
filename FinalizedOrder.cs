using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using PetStore.Business;

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
            var petsDataTable = await _productBusiness.GetPetAsync(FirebaseClientId);

            if (petsDataTable == null || petsDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No order data found. Please check your data or try again later.");
                return;
            }

            // Extract relevant columns into a new DataTable for display
            var displayTable = petsDataTable.DefaultView.ToTable(false,
                "ClientName", "ClientLastName", "ClientMail", "ProductName", "ProductPrice", "ProductCount");

            // Bind the processed data to the DataGridView
            orderDataGridView.DataSource = displayTable;
            orderDataGridView.ReadOnly = true;
            orderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
