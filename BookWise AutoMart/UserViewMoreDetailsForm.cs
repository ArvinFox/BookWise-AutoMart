using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserViewMoreDetailsForm : Form
    {
        private readonly int id;
        private readonly string userType;

        private readonly SqlConnection conn = new SqlConnection(DatabaseString.GetUserDatabase());

        public UserViewMoreDetailsForm(int userID, string user)
        {
            InitializeComponent();
            id = userID;
            userType = user;
            Placeholder(txtName, "Enter new name...");
            Placeholder(txtContact, "Enter new contact number...");
            Placeholder(txtEmail, "Enter new Email...");
        }
        private void UserViewMoreDetailsForm_Load(object sender, EventArgs e)
        {
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
            tblHeading.BackColor = Color.IndianRed;
            tblHeading.ForeColor = Color.White;
            tblHeading.Height = 55;

            Label lblOrderID = new Label();
            lblOrderID.Text = "Order ID";
            lblOrderID.Dock = DockStyle.Fill;
            lblOrderID.TextAlign = ContentAlignment.MiddleCenter;
            lblOrderID.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblOrderID, 0, 0);

            Label lblItemName = new Label();
            lblItemName.Text = "Item Name";
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleCenter;
            lblItemName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblItemName, 1, 0);

            Label lblUnitPrice = new Label();
            lblUnitPrice.Text = "Unit Price";
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitPrice.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUnitPrice, 2, 0);

            Label lblQuantity = new Label();
            lblQuantity.Text = "Quantity";
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            lblQuantity.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblQuantity, 3, 0);

            Label lblTotal = new Label();
            lblTotal.Text = "Amount Paid";
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblTotal.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblTotal, 4, 0);

            Label lblPaymentMethod = new Label();
            lblPaymentMethod.Text = "Payment Method";
            lblPaymentMethod.Dock = DockStyle.Fill;
            lblPaymentMethod.TextAlign = ContentAlignment.MiddleCenter;
            lblPaymentMethod.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblPaymentMethod, 5, 0);

            Label lblOrderDate = new Label();
            lblOrderDate.Text = "Order Date";
            lblOrderDate.Dock = DockStyle.Fill;
            lblOrderDate.TextAlign = ContentAlignment.MiddleCenter;
            lblOrderDate.Font = new Font("Segoe UI", 14, FontStyle.Bold);
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

                //Disable the visibility of Feedbackbutton for Guests
                btnViewUserFeedbacks.Visible = false;
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
                                    tblData.BackColor = Color.PaleTurquoise;
                                }
                                else
                                {
                                    tblData.BackColor = Color.White;
                                }

                                pnlTable.Controls.Add(tblData);
                                count++;
                                
                            }
                            pnlTable.Controls.Add(tblHeading);
                            tblNoDataAvailable.Visible = false;
                        }
                        else
                        {
                            tblHeading.Visible = false;
                        }
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
                                    radioBtnFemale.Visible = false;
                                    radioBtnMale.Visible = false;
                                    txtEmail.Text = "No Data Available";
                                    txtContact.Text = reader["guest_contact_number"].ToString();
                                    txtRegisterDate.Text = "No Data Available";
                                    txtEmail.ReadOnly = true;
                                    txtRegisterDate.ReadOnly = true;

                                }
                                else
                                {
                                    txtName.Text = reader["name"].ToString();
                                    if (reader["gender"].ToString() == "Male")
                                    {
                                        radioBtnMale.Checked = true;
                                    }
                                    else
                                    {
                                        radioBtnFemale.Checked = true;
                                    }
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
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteUserDetails();
            } 
        }
        
        private void DeleteUserDetails() //To delete user's details
        {
            try
            {
                conn.Open();

                string deleteOrdersQuery = "";
                string deleteFeedBack = "";

                if (userType == "Guest")
                {
                    deleteOrdersQuery = $"DELETE FROM Orders WHERE order_guest_id = {id}";
                    string deleteOrderItemsQuery = $"DELETE FROM Order_Items WHERE order_items_order_id IN (SELECT order_id FROM Orders WHERE order_guest_id = {id})";
                    SqlCommand deleteOrderItemsCommand = new SqlCommand(deleteOrderItemsQuery, conn);
                    deleteOrderItemsCommand.ExecuteNonQuery();
                }
                else
                {
                    // First, delete feedback associated with the user
                    deleteFeedBack = $"DELETE FROM FeedBack WHERE feedback_user_id = {id}";
                    SqlCommand deleteFeedbackCommand = new SqlCommand(deleteFeedBack, conn);
                    deleteFeedbackCommand.ExecuteNonQuery();

                    // Next, delete all order items associated with the orders placed by the user
                    string deleteOrderItemsQuery = $"DELETE FROM Order_Items WHERE order_items_order_id IN (SELECT order_id FROM Orders WHERE order_user_id = {id})";
                    SqlCommand deleteOrderItemsCommand = new SqlCommand(deleteOrderItemsQuery, conn);
                    deleteOrderItemsCommand.ExecuteNonQuery();

                    // Finally, delete the orders
                    deleteOrdersQuery = $"DELETE FROM Orders WHERE order_user_id = {id}";
                }

                SqlCommand deleteOrdersCommand = new SqlCommand(deleteOrdersQuery, conn);
                deleteOrdersCommand.ExecuteNonQuery();

                string deleteUserQuery = "";

                if (userType == "Guest")
                {
                    deleteUserQuery = $"DELETE FROM Guests WHERE guest_id = {id}";
                }
                else
                {
                    deleteUserQuery = $"DELETE FROM Users WHERE user_id = {id}";
                }

                SqlCommand deleteUserCommand = new SqlCommand(deleteUserQuery, conn);
                deleteUserCommand.ExecuteNonQuery();

                MessageBox.Show("User Successfully Removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                this.Close();
                //To refresh the whole Table after deleting an user
                AdminControlForm.btnReloadUserManagementForm.PerformClick();
            }
        }

        private void UpdateUserDetails() //To perform an update for the existing user
        {
            string query = "";
            if (userType == "Guest")
            {
                query = $@"UPDATE Guests 
                        SET guest_name = @newGuestName, guest_contact_number = @newGuestContact
                        WHERE guest_id = {id}";
            }
            else
            {
                query = $@"UPDATE Users 
                        SET name = @newUserName, gender = @newUserGender, email = @newUserEmail, contact_number = @newUserContact
                        WHERE user_id = {id}";
            }

            try
            {
                using (SqlCommand updateUserCommand = new SqlCommand(query, conn))
                {
                    conn.Open();
                    if (userType == "Guest")
                    {
                        updateUserCommand.Parameters.AddWithValue("@newGuestName", txtName.Text);
                        updateUserCommand.Parameters.AddWithValue("@newGuestContact", txtContact.Text);
                        updateUserCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        updateUserCommand.Parameters.AddWithValue("@newUserName", txtName.Text);
                        updateUserCommand.Parameters.AddWithValue("@newUserGender", (radioBtnFemale.Checked) ? "Female" : "Male");
                        updateUserCommand.Parameters.AddWithValue("@newUserEmail", txtEmail.Text);
                        updateUserCommand.Parameters.AddWithValue("@newUserContact", txtContact.Text);
                        updateUserCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("User details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
                conn.Close();

                //To refresh the whole Table after updating an user
                AdminControlForm.btnReloadUserManagementForm.PerformClick();
            }
        }

        private bool ValidateDetails()
        {
            // Reset visibility of error labels and clear previous error messages
            lblRequiredFields.Visible = false;
            lblNameRequired.Visible = false;
            lblContactRequired.Visible = false;
            lblGenderRequired.Visible = false;
            lblEmailRequired.Visible = false;

            bool isValid = true;

            // Validation for Name field
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Trim() == "Enter new name...")
            {
                lblNameRequired.Visible = true;
                lblRequiredFields.Visible = true;
                isValid = false;

                lblRequiredFields.Text = "* All fields must be filled!";
            }

            // Validation for Email field using regular expression
            if (userType != "Guest")
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Trim() == "Enter new Email...")
                {
                    lblEmailRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                    isValid = false;

                    lblRequiredFields.Text = "* All fields must be filled!";
                }
                else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    lblEmailRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                    isValid = false;

                    lblRequiredFields.Text = "* Email format should abc@example.com!";
                }
            }

            // Validation for Contact field - should contain exactly 10 digits
            if (string.IsNullOrWhiteSpace(txtContact.Text) || txtContact.Text.Trim() == "Enter new contact number...")
            {
                lblContactRequired.Visible = true;
                lblRequiredFields.Visible = true;
                isValid = false;

                lblRequiredFields.Text = "* All fields must be filled!";
            }
            else if (!Regex.IsMatch(txtContact.Text, @"^\d{10}$"))
            {
                lblContactRequired.Visible = true;
                lblRequiredFields.Visible = true;
                isValid = false;

                lblRequiredFields.Text = " * Contact should only contains numbers && length must be 10 numbers only!";
                isValid = false;
            }

            return isValid;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails())
                return;

            UpdateUserDetails();         
        }
        private void Placeholder(TextBox textBox, string placeholder)
        {
            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }

        private void btnViewUserFeedbacks_Click(object sender, EventArgs e)
        {
            UserViewAllFeedbacks userViewAllFeedbacks = new UserViewAllFeedbacks(id);
            userViewAllFeedbacks.ShowDialog();
        }
    }
}
