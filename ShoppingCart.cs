using PetStore.Business;
using PetStore.Data.Models;
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
        private ProductBusiness productBusiness = new ProductBusiness();
        List<Product> products = new List<Product>();
        public ShoppingCart()
        {
            InitializeComponent();
        }
        public List<Product> GetProducts { get; set; }
        private void lineLbl_Click(object sender, EventArgs e)
        {

        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            // Create a new instance of Order form
            Order order = new Order();

            // Create new clinet
            Client client = new Client(nameRichTextBox.Text, lastNameRichTextBox.Text, emailRichTextBox.Text);

            // Transfer client and products data
            order.GetClient = client;
            order.GetClientItems = products;

            // Add client to the database
            productBusiness.Add(client);

            /// Connect the data using ClientId
            // Get current client id
            int id = client.GetCurrentId();
            foreach (var item in products)
            {
                item.ClientId = id;
            }
            
            // Get the current client id
            order.GetClientId = id;
            
            
            foreach (Product product in products)
            {
                productBusiness.Add(product);
            }
            
            order.Show();

            products.Clear();

            // Close current form
            this.Close();
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
