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
            bool userPanelFound = false;

            foreach(Form form in Application.OpenForms)
            {
                if(form is UserPanel)
                {
                    form.Show();
                    userPanelFound = true;
                    break;
                }
            }

            if(!userPanelFound)
            {
                UserPanel userPanel = new UserPanel();
                userPanel.Show();
            }
            this.Hide();
        }

        private void OutOfStockForm_Load(object sender, EventArgs e)
        {
            lblStock.Text = Convert.ToString(stock).ToString();
        }
    }
}
