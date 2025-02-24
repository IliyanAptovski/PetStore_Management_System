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
        decimal price = 0;
        ProductBusiness productBusiness = new ProductBusiness();

        public Order()
        {
            InitializeComponent();
        }

        public Client GetClient { get; set; }
        public List<Product> GetClientItems { get; set; }
        public int GetClientId { get; set; }

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

            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.Close();

            // Display the price
            foreach (var item in GetClientItems)
            {
                price += item.Price * item.Count;
            }
            subtotalLbl.Text = $"${price:f2}";
            totalLbl.Text = $"${(30 + price):f2}";
        }

        private void shippingTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void subtotalTextLbl_Click(object sender, EventArgs e)
        {

        }

        private void finalizeBtn_Click(object sender, EventArgs e)
        {
            // Reset the price
            price = 0;

            // Transfer client id
            FinalizedOrder finalizedOrder = new FinalizedOrder();
            finalizedOrder.GetClientId = this.GetClientId;
            finalizedOrder.Show();

            this.Close();
        }

        // Delete data from the database
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            productBusiness.Delete(this.GetClientId);
            this.Close();
        }

        // Update client personal info
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateOrder updateOrder = new UpdateOrder();
            updateOrder.GetClientId = this.GetClientId;
            updateOrder.Show();
            this.Close();
        }
    }
}
