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
    public partial class CardDesign : Form
    {
        public CardDesign()
        {
            InitializeComponent();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            this.Hide();
        }

        private void butProceed_Click(object sender, EventArgs e)
        {
            FinalProceedFormCard finalProceedFormCard   = new FinalProceedFormCard();
            finalProceedFormCard.Show();
            this.Hide();
        }
    }
}
