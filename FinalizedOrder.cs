using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetStore.Business;

namespace PetStore
{
    public partial class FinalizedOrder : Form
    {
        ProductBusiness productBusiness = new ProductBusiness();
        public int GetClientId { get; set; }
        
        public FinalizedOrder()
        {
            InitializeComponent();
        }

        // Display client order
        private void FinalizedOrder_Load(object sender, EventArgs e)
        {
            int id = GetClientId;

            // Order number
            Random rnd = new Random();
            orderNumberTextLbl.Text = $"Order #{rnd.Next(100000, 999999)}";

            // Order info
            orderDataGridView.DataSource = productBusiness.Get(id);
            orderDataGridView.ReadOnly = true;
            orderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
