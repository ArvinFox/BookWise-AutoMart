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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTopic1_Click(object sender, EventArgs e)
        {

        }

        private void butCash_Click(object sender, EventArgs e)
        {
            CashDesign cashDesign = new CashDesign();
            cashDesign.Show();
            this.Hide();
        }

        private void butCard_Click(object sender, EventArgs e)
        {
            CardDesign cardDesign = new CardDesign();   
            cardDesign.Show();  
            this.Hide();
        }
    }
}
