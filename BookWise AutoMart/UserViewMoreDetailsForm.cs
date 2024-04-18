using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserViewMoreDetailsForm : Form
    {
        int id;
        string userType;

        SqlConnection conn = new SqlConnection(DatabaseString.GetUserDatabase());

        public UserViewMoreDetailsForm(int userID, string user)
        {
            InitializeComponent();
            id = userID;
            userType = user;
        }
        private void UserViewMoreDetailsForm_Load(object sender, EventArgs e)
        {
            //Label to tell when there is no order data related to the selected user
            Label lblDataUnavailable = new Label();
            lblDataUnavailable.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblDataUnavailable.ForeColor = Color.DarkGray;
            lblDataUnavailable.Visible = false;
            lblDataUnavailable.Text = "There is no order data available";
            lblDataUnavailable.TextAlign = ContentAlignment.MiddleCenter;
            lblDataUnavailable.Dock = DockStyle.Bottom;

            //Loading user's order history into the tablelayoutpanel
            TableLayoutPanel tblHeading = new TableLayoutPanel();

            tblHeading.ColumnCount = 7;
            tblHeading.RowCount = 1;
            tblHeading.Width = this.Width;
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.Dock = DockStyle.Top;
            tblHeading.BackColor = Color.DodgerBlue;
            tblHeading.Height = 55;

            Label lblOrderID = new Label();
            lblOrderID.Text = "Order ID";
            lblOrderID.Dock = DockStyle.Fill;
            lblOrderID.TextAlign = ContentAlignment.MiddleCenter;
            lblOrderID.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblOrderID, 0, 0);

            Label lblItemName = new Label();
            lblItemName.Text = "Item Name";
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleCenter;
            lblItemName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblItemName, 1, 0);

            Label lblUnitPrice = new Label();
            lblUnitPrice.Text = "Unit Price";
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitPrice.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUnitPrice, 2, 0);

            Label lblQuantity = new Label();
            lblQuantity.Text = "Quantity";
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            lblQuantity.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblQuantity, 3, 0);

            Label lblTotal = new Label();
            lblTotal.Text = "Amount Paid";
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblTotal, 4, 0);

            Label lblPaymentMethod = new Label();
            lblPaymentMethod.Text = "Payment Method";
            lblPaymentMethod.Dock = DockStyle.Fill;
            lblPaymentMethod.TextAlign = ContentAlignment.MiddleCenter;
            lblPaymentMethod.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblPaymentMethod, 5, 0);

            Label lblOrderDate = new Label();
            lblOrderDate.Text = "Order Date";
            lblOrderDate.Dock = DockStyle.Fill;
            lblOrderDate.TextAlign = ContentAlignment.MiddleCenter;
            lblOrderDate.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblOrderDate, 6, 0);

            string orderHistoryQuery = $@"
                    SELECT Orders.order_id AS OrderID, 
                    Items.item_name AS ItemName,
                    Items.price AS UnitPrice,
                    Order_Items.quantity AS Quantity,
                    (Order_Items.quantity * Items.price) AS AmountPaid,
                    Orders.order_date AS OrderDate,
                    Orders.payment_method AS PaymentMethod
                FROM 
                    Orders
                INNER JOIN 
                    Order_Items ON Orders.order_id = Order_Items.order_items_order_id
                INNER JOIN 
                    Items ON Order_Items.order_items_item_id = Items.item_id
                WHERE ";

            if (userType == "Guest")
            {
                orderHistoryQuery += $"Orders.order_guest_id = {id}";
            }
            else
            {
                orderHistoryQuery += $"Orders.order_user_id = {id}";
            }

            using (SqlCommand command = new SqlCommand(orderHistoryQuery, conn))
            {
                try
                {
                    conn.Open();
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            int count = 0;
                            while (reader.Read())
                            {
                                TableLayoutPanel tblData = new TableLayoutPanel();

                                tblData.ColumnCount = 7;
                                tblData.RowCount = 1;
                                tblData.Width = this.Width;
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblData.Dock = DockStyle.Top;
                                tblData.BackColor = Color.DodgerBlue;
                                tblData.Height = 55;

                                Label lblOrderIDData = new Label();
                                lblOrderIDData.Text = "Order ID";
                                lblOrderIDData.Dock = DockStyle.Fill;
                                lblOrderIDData.TextAlign = ContentAlignment.MiddleCenter;
                                lblOrderIDData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblOrderIDData, 0, 0);

                                Label lblItemNameData = new Label();
                                lblItemNameData.Text = "Item Name";
                                lblItemNameData.Dock = DockStyle.Fill;
                                lblItemNameData.TextAlign = ContentAlignment.MiddleCenter;
                                lblItemNameData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblItemNameData, 1, 0);

                                Label lblUnitPriceData = new Label();
                                lblUnitPriceData.Text = "Unit Price";
                                lblUnitPriceData.Dock = DockStyle.Fill;
                                lblUnitPriceData.TextAlign = ContentAlignment.MiddleCenter;
                                lblUnitPriceData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblUnitPriceData, 2, 0);

                                Label lblQuantityData = new Label();
                                lblQuantityData.Text = "Quantity";
                                lblQuantityData.Dock = DockStyle.Fill;
                                lblQuantityData.TextAlign = ContentAlignment.MiddleCenter;
                                lblQuantityData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblQuantityData, 3, 0);

                                Label lblTotalData = new Label();
                                lblTotalData.Text = "Amount Paid";
                                lblTotalData.Dock = DockStyle.Fill;
                                lblTotalData.TextAlign = ContentAlignment.MiddleCenter;
                                lblTotalData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblTotalData, 4, 0);

                                Label lblPaymentMethodData = new Label();
                                lblPaymentMethodData.Text = "Payment Method";
                                lblPaymentMethodData.Dock = DockStyle.Fill;
                                lblPaymentMethodData.TextAlign = ContentAlignment.MiddleCenter;
                                lblPaymentMethodData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblPaymentMethodData, 5, 0);

                                Label lblOrderDateData = new Label();
                                lblOrderDateData.Text = "Order Date";
                                lblOrderDateData.Dock = DockStyle.Fill;
                                lblOrderDateData.TextAlign = ContentAlignment.MiddleCenter;
                                lblOrderDateData.Font = new Font("Segoe UI", 12);
                                tblData.Controls.Add(lblOrderDateData, 6, 0);

                                if (userType == "Guest")
                                {
                                    lblOrderIDData.Text = reader["OrderID"].ToString();
                                    lblItemNameData.Text = reader["ItemName"].ToString();
                                    lblUnitPriceData.Text = reader["UnitPrice"].ToString();
                                    lblQuantityData.Text = reader["Quantity"].ToString();
                                    lblTotalData.Text = reader["AmountPaid"].ToString();
                                    lblPaymentMethodData.Text = reader["PaymentMethod"].ToString();
                                    lblOrderDateData.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy");
                                }
                                else
                                {
                                    lblOrderIDData.Text = reader["OrderID"].ToString();
                                    lblItemNameData.Text = reader["ItemName"].ToString();
                                    lblUnitPriceData.Text = reader["UnitPrice"].ToString();
                                    lblQuantityData.Text = reader["Quantity"].ToString();
                                    lblTotalData.Text = reader["AmountPaid"].ToString();
                                    lblPaymentMethodData.Text = reader["PaymentMethod"].ToString();
                                    lblOrderDateData.Text = Convert.ToDateTime(reader["OrderDate"]).ToString("dd/MM/yyyy");                                }

                                //for table colors
                                if (count % 2 == 0)
                                {
                                    tblData.BackColor = Color.AliceBlue;
                                }
                                else
                                {
                                    tblData.BackColor = Color.PaleGreen;
                                }

                                pnlTable.Controls.Add(tblData);
                                count++;
                                
                            } 
                        }
                        pnlTable.Controls.Add(tblHeading);
                    }
                }
                catch (SqlException sqlex) 
                {
                    MessageBox.Show(sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    conn.Close();
                }
            }
                

            //Showing more details of the user

            string query = $"SELECT * FROM Users WHERE user_id={id}";
            bool isGuest = false;

            if (userType == "Guest")
            {
                query = $"SELECT * FROM Guests WHERE guest_id={id}";
                isGuest = true;
            }
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        { 
                            while (reader.Read()) 
                            {
                                if (isGuest)
                                {
                                    txtName.Text = reader["guest_name"].ToString();
                                    txtGender.Text = "-------";
                                    txtEmail.Text = "-------";
                                    txtContact.Text = reader["guest_contact_number"].ToString();
                                    txtRegisterDate.Text = "-------";
                                    txtGender.ReadOnly = true;
                                    txtEmail.ReadOnly = true;
                                    txtRegisterDate.ReadOnly = true;
                                }
                                else
                                {
                                    txtName.Text = reader["name"].ToString();
                                    txtGender.Text = reader["gender"].ToString();
                                    txtEmail.Text = reader["email"].ToString();
                                    txtContact.Text = reader["contact_number"].ToString();
                                    txtRegisterDate.Text = Convert.ToDateTime(reader["registration_date"]).ToString("dd/MM/yyyy");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Records Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show(sqlex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
