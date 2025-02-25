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
    public partial class Order : Form
    {
        private decimal price;
        private readonly ProductBusiness productBusiness;
        private readonly string receivedClientId;

        public Client GetClient { get; set; }
        public List<Product> GetClientItems { get; set; }
        public string GetClientId { get; set; }

        public Order() : this(string.Empty) { }

        public Order(string clientId)
        {
            InitializeComponent();
            productBusiness = new ProductBusiness();
            receivedClientId = clientId;
        }

        private void lineLbl_Click(object sender, EventArgs e)
        {

        }

        private void captionTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void taxTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {
            // Close shopping cart if needed
            using (ShoppingCart shoppingCart = new ShoppingCart())
            {
                shoppingCart.Close();
            }

            // Calculate total price
            if (GetClientItems != null && GetClientItems.Any())
            {
                price = GetClientItems.Sum(item => item.Price * item.Count);
                subtotalLbl.Text = $"${price:F2}";
                totalLbl.Text = $"${(30 + price):F2}";
            }
        }

        private void shippingTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void subtotalTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void finalizeBtn_Click(object sender, EventArgs e)
        {
            // Reset price and finalize order
            price = 0;
            var finalizedOrder = new FinalizedOrder { FirebaseClientId = GetClientId };
            finalizedOrder.Show();
            Close();
        }

        // Delete data from the database
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(receivedClientId))
            {
                await productBusiness.DeletePetByClientIdAsync(receivedClientId);
            }
            Close();
        }

        // Update client personal info
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateOrder updateOrder = new UpdateOrder();
            updateOrder.FirebaseClientId = this.receivedClientId;
            updateOrder.Show();
            this.Close();
        }
    }
}
