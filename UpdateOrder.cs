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
    public partial class UpdateOrder : Form
    {
        ProductBusiness productBusiness = new ProductBusiness();
        public int GetClientId { get; set; }
        public UpdateOrder()
        {
            InitializeComponent();
        }

        // Update client personal info
        private void updateBtn_Click(object sender, EventArgs e)
        {
            productBusiness.Update(this.GetClientId, nameRichTextBox.Text, lastNameRichTextBox.Text, emailRichTextBox.Text);
            
            FinalizedOrder finalizedOrder = new FinalizedOrder();
            finalizedOrder.GetClientId = GetClientId;
            finalizedOrder.Show();
            this.Close();
        }

        private void secondLineLbl_Click(object sender, EventArgs e)
        {

        }

        private void UpdateOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
