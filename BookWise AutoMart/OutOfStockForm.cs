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
            textBoxQty.Text = stock.ToString();
            this.Close();
        }

        private void OutOfStockForm_Load(object sender, EventArgs e)
        {
            lblStock.Text = Convert.ToString(stock).ToString();
        }

        private void OutOfStockForm_Deactivate(object sender, EventArgs e)
        {
            textBoxQty.Text = stock.ToString();
            this.Close();
        }
    }
}
