using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class OutOfStockForm : Form
    {
        private int stock;
        private TextBox textBoxQty;

        public OutOfStockForm(int Qty, TextBox textQty)
        {

            InitializeComponent();
            stock = Qty;
            textBoxQty = textQty;
        }

        private void butOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            textBoxQty.Text = stock.ToString();
            UserPanel userPanel = new UserPanel();
            userPanel.Show();
        }

        private void OutOfStockForm_Load(object sender, EventArgs e)
        {
            lblStock.Text = Convert.ToString(stock).ToString();
        }
    }
}
