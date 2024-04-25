using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private Timer feedbackFormTimer;
        private int feedbackTimer = 0;
        private string connectionString = DatabaseString.GetUserDatabase();

        public Checkout()
        {
            InitializeComponent();
            panelBill = pnlBill;
            feedbackFormTimer = new Timer();
            feedbackFormTimer.Interval = 1000;
            feedbackFormTimer.Tick += FeedbackFormTimer_Tick;

            lblUserName.Text = GetUsername(UserPanel.id);
        }

        private string GetUsername(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "";

                if (UserPanel.user == "Customer")
                {
                    query = "SELECT name FROM Users WHERE user_id = @UserId";
                }
                else
                {
                    query = "SELECT guest_name FROM Guests WHERE guest_id = @UserId";
                }

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@UserId", id);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        // error
                    }
                }
            }

            return "User";
        }

        private void butCash_Click(object sender, EventArgs e)
        {
            StockUpdate();
        }

        private void butCard_Click(object sender, EventArgs e)
        {
            StockUpdate();
        }

        private void UpdateStock(string itemName, int quantity, int itemStock)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET stock = @Stock WHERE item_name = @ItemName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@Stock", itemStock - quantity);
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        //---------Error-----------
                    }
                }

            }
        }

        private int GetStock(string ItemName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT stock FROM Items WHERE item_name = @ItemName";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@ItemName", ItemName);
                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            return (int)result;
                        }
                    }
                    catch (Exception)
                    {
                        //-------error---------
                    }
                }
            }
            return -1;
        }

        private void StockUpdate()
        {
            feedbackFormTimer.Start();

            foreach (Control control in panelBill.Controls)
            {
                if (control is TableLayoutPanel tblItem)
                {
                    if (tblItem.Controls[1] is Label lblItemName && tblItem.Controls[0] is Label lblQty)
                    {
                        int quantity = Convert.ToInt32(lblQty.Text.Trim());
                        string itemName = lblItemName.Text.Trim();
                        int itemStock = GetStock(itemName);
                        UpdateStock(itemName, quantity, itemStock);
                    }
                }
            }
            pictureBoxBack.Visible = false;
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
            lblQty.Font = new Font("Segoe UI", 13);
            tblBillItem.Controls.Add(lblQty, 0, 0);

            Label lblItemName = new Label();
            lblItemName.Text = itemName;
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            lblItemName.Font = new Font("Segoe UI", 12);
            tblBillItem.Controls.Add(lblItemName, 1, 0);

            Label lblUnitPrice = new Label();
            lblUnitPrice.Text = price.ToString();
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitPrice.Font = new Font("Segoe UI", 13);
            tblBillItem.Controls.Add(lblUnitPrice, 2, 0);

            Label lblAmount = new Label();
            lblAmount.Text = (price * quantity).ToString();
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            lblAmount.Font = new Font("Segoe UI", 13);
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            bool userPanelFound = false;
            foreach(Form form in Application.OpenForms)
            {
                if(form is UserPanel)
                {
                    userPanelFound = true;
                    form.Show();
                    break;
                }
            }
            if(!userPanelFound)
            {
                UserPanel userPanel = new UserPanel(UserPanel.id, UserPanel.user);
                userPanel.Show();
            }
            this.Hide();
        }

        private void FeedbackFormTimer_Tick(object sender, EventArgs e)
        {
            feedbackTimer++;
            if(feedbackTimer >= 3)
            {
                feedbackFormTimer.Stop();   

                bool feedbackFormFound = false;
                foreach (Form form in Application.OpenForms)
                {
                    if (form is UserFeedbackForm)
                    {
                        feedbackFormFound = true;
                        form.ShowDialog();
                        break;
                    }
                }
                if (!feedbackFormFound)
                {
                    UserFeedbackForm userFeedbackForm = new UserFeedbackForm();
                    userFeedbackForm.ShowDialog();
                }
            }
        }
    }
}
