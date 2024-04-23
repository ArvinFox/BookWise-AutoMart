using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookWise_AutoMart
{
    public partial class Checkout : Form
    {
        public Panel panelBill;

        public Checkout()
        {
            InitializeComponent();
            panelBill = pnlBill;
        }

        private void butCash_Click(object sender, EventArgs e)
        {
            tlpPaymentType.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = "Thank you";
        }

        private void butCard_Click(object sender, EventArgs e)
        {
            tlpPaymentType.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = "Thank you";
        }

        public void AddToBill(int quantity, string itemName, decimal price)
        {
            TableLayoutPanel tblBillItem = new TableLayoutPanel();

            tblBillItem.ColumnCount = 4;
            tblBillItem.RowCount = 1;
            tblBillItem.Width = this.Width;
            tblBillItem.Height = 55;
            tblBillItem.BackColor = Color.White;
            tblBillItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.17F));
            tblBillItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.29F));
            tblBillItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.09F));
            tblBillItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.59F));
            tblBillItem.Dock = DockStyle.Top;

            Label lblQty = new Label();
            lblQty.Text = quantity.ToString();
            lblQty.Dock = DockStyle.Fill;
            lblQty.TextAlign = ContentAlignment.MiddleCenter;
            lblQty.Font = new Font("Segoe UI", 10);
            tblBillItem.Controls.Add(lblQty, 0, 0);

            Label lblItemName = new Label();
            lblItemName.Text = itemName;
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            lblItemName.Font = new Font("Segoe UI", 8);
            tblBillItem.Controls.Add(lblItemName, 1, 0);

            Label lblUnitPrice = new Label();
            lblUnitPrice.Text = price.ToString();
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitPrice.Font = new Font("Segoe UI", 10);
            tblBillItem.Controls.Add(lblUnitPrice, 2, 0);

            Label lblAmount = new Label();
            lblAmount.Text = (price * quantity).ToString();
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            lblAmount.Font = new Font("Segoe UI", 10);
            tblBillItem.Controls.Add(lblAmount, 3, 0);

            pnlBill.Controls.Add(tblBillItem);
        }

        public void UpdateQuantity(string itemName, int quantity)
        {
            foreach (Control control in panelBill.Controls)
            {
                if (control is TableLayoutPanel tblItem)
                {
                    if (tblItem.Controls[1] is Label lblItemName)
                    {
                        if (lblItemName.Text.Trim() == itemName.Trim())
                        {
                            if (tblItem.Controls[0] is Label lblQty)
                            {
                                int currentQty = Convert.ToInt32(lblQty.Text);
                                lblQty.Text = (currentQty + quantity).ToString();

                                if (tblItem.Controls[3] is Label lblAmount)
                                {
                                    decimal price = Convert.ToDecimal(lblAmount.Text);
                                    lblAmount.Text = (price * Convert.ToDecimal(lblQty.Text)).ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        public void DeleteItem(string itemName)
        {
            //To delete item
            foreach (Control control in panelBill.Controls)
            {
                if (control is TableLayoutPanel tblItem)
                {
                    if (tblItem.Controls[1] is Label lblItemName)
                    {
                        if(lblItemName.Text.Trim() == itemName.Trim())
                        {
                            panelBill.Controls.Remove(tblItem);
                        }
                    }
                }
            }
        }

        public string BillValue
        {
            get
            {
                return this.lblAmount.Text;
            }
            set
            {
                this.lblAmount.Text = value;
            }
        }
    }
}
