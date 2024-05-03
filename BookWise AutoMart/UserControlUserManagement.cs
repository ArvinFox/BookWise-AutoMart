using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class UserControlUserManagement : UserControl
    {
        public UserControlUserManagement()
        {
            InitializeComponent();
            this.ParentChanged += UserControlUserManagement_ParentChanged;
            Placeholder(txtSearchBar,"Enter Username or Email...");
            PopulateUsersComboBox();
            DisplayUserDetails();
        }

        private readonly string connectionString = DatabaseString.GetUserDatabase();

        private void DisplayUserDetails(string filterOption = null, string searchedUser = null)
        {
            pnlUserDetails.Controls.Clear();

            TableLayoutPanel tblHeading = new TableLayoutPanel();
            
            tblHeading.ColumnCount = 6;
            tblHeading.RowCount = 1;
            tblHeading.Width = this.Width;
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            tblHeading.Dock = DockStyle.Top;
            tblHeading.BackColor = Color.FromArgb(21, 101, 192);

            Label lblUserID = new Label();
            lblUserID.Text = "ID";
            lblUserID.Dock = DockStyle.Fill;
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            lblUserID.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserID, 0, 0);

            Label lblUserType = new Label();
            lblUserType.Text = "User Type";
            lblUserType.Dock = DockStyle.Fill;
            lblUserType.TextAlign = ContentAlignment.MiddleCenter;
            lblUserType.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserType, 1, 0);

            Label lblUserName = new Label();
            lblUserName.Text = "User Name";
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserName.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserName, 2, 0);

            Label lblUserContact = new Label();
            lblUserContact.Text = "User Contact";
            lblUserContact.Dock = DockStyle.Fill;
            lblUserContact.TextAlign = ContentAlignment.MiddleCenter;
            lblUserContact.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserContact, 3, 0);

            Label lblUserEmail = new Label();
            lblUserEmail.Text = "User Email";
            lblUserEmail.Dock = DockStyle.Fill;
            lblUserEmail.TextAlign = ContentAlignment.MiddleCenter;
            lblUserEmail.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserEmail, 4, 0);

                      
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "";

                // not filtered item and not searched item (filterOption == null && searchedusername == null)
                if (string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedUser))
                {
                    /*query = @"SELECT 'Users' AS 
                            source_table, 
                            user_id, 
                            name, 
                            gender, 
                            email, 
                            contact_number, 
                            registration_date, 
                        NULL AS guest_id, 
                            NULL AS guest_name, 
                            NULL AS guest_contact_number 
                        FROM 
                            Users 
                        UNION ALL 
                        SELECT 'Guests' AS 
                            source_table, 
                            NULL, NULL, NULL, NULL, NULL, NULL, 
                            guest_id, 
                            guest_name, 
                            guest_contact_number 
                        FROM 
                            Guests 
                        ORDER BY 
                            guest_id DESC, user_id DESC;";*/
                    query = @"SELECT 'Customer' AS userType,
                                user_id AS userId,
                                name AS userName,
                                gender AS userGender,
                                email AS userEmail,
                                contact_number AS userContact,
                                registration_date AS userRegistration
                            FROM Users 
                            UNION
                            SELECT 'Guest' AS userType,
                                guest_id AS userId,
                                guest_name AS userName,
                                NULL AS userGender,
                                NULL AS userEmail,
                                guest_contact_number AS userContact,
                                NULL AS userRegistration
                            FROM Guests
                            ORDER BY userId DESC";
                }
                
                // filtered item but not searched user (filterOption != null && searchedusername == null)
                else if (!string.IsNullOrEmpty(filterOption) && string.IsNullOrEmpty(searchedUser))
                {
                    if (filterOption.Equals("Customers"))
                    {
                        query = @"SELECT 'Customer' AS userType,
                                user_id AS userId,
                                name AS userName,
                                gender AS userGender,
                                email AS userEmail,
                                contact_number AS userContact,
                                registration_date AS userRegistration
                            FROM Users
                            ORDER BY userID DESC";
                    }
                    else
                    {
                        query = @"SELECT 'Guest' AS userType,
                                guest_id AS userId,
                                guest_name AS userName,
                                NULL AS userGender,
                                NULL AS userEmail,
                                guest_contact_number AS userContact,
                                NULL AS userRegistration
                            FROM Guests
                            ORDER BY userId DESC";
                    }  
                }

                // not filtered item but searched item (filterOption == null && searchedusername != null)
                else if (string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedUser))
                {
                    query = @"SELECT 'Customer' AS userType,
                                user_id AS userId,
                                name AS userName,
                                gender AS userGender,
                                email AS userEmail,
                                contact_number AS userContact,
                                registration_date AS userRegistration
                            FROM Users
                            WHERE (name LIKE @searchUser OR email LIKE @searchUser)
                            UNION
                            SELECT 'Guest' AS userType,
                                guest_id AS userId,
                                guest_name AS userName,
                                NULL AS userGender,
                                NULL AS userEmail,
                                guest_contact_number AS userContact,
                                NULL AS userRegistration
                            FROM Guests
                            WHERE guest_name LIKE @searchUser
                            ORDER BY userId DESC";
                }

                // filtered item and searched item (filterOption != null && searchedusername != null)
                else if (!string.IsNullOrEmpty(filterOption) && !string.IsNullOrEmpty(searchedUser))
                {
                    if (filterOption.Equals("Customers"))
                    {
                        query = @"SELECT 'Customer' AS userType,
                                user_id AS userId,
                                name AS userName,
                                gender AS userGender,
                                email AS userEmail,
                                contact_number AS userContact,
                                registration_date AS userRegistration
                            FROM Users
                            WHERE (name LIKE @searchUser OR email LIKE @searchUser)
                            ORDER BY userId DESC";
                    }
                    else
                    {
                        query = @"SELECT 'Guest' AS userType,
                                guest_id AS userId,
                                guest_name AS userName,
                                NULL AS userGender,
                                NULL AS userEmail,
                                guest_contact_number AS userContact,
                                NULL AS userRegistration
                            FROM Guests
                            WHERE guest_name LIKE @searchUser
                            ORDER BY userId DESC";
                    }
                }
                

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(searchedUser))
                        {
                            command.Parameters.AddWithValue("@searchUser", $"%{searchedUser}%");
                        }

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int count = 0;
                                while (reader.Read())
                                {
                                    TableLayoutPanel tblData = new TableLayoutPanel();

                                    tblData.ColumnCount = 6;
                                    tblData.Width = this.Width;
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                    tblData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
                                    tblData.Dock = DockStyle.Top;

                                    Label lblUserIDData = new Label();
                                    lblUserIDData.Dock = DockStyle.Fill;
                                    lblUserIDData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserIDData.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserIDData, 0, count);

                                    Label lblUserTypeData = new Label();
                                    lblUserTypeData.Dock = DockStyle.Fill;
                                    lblUserTypeData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserTypeData.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserTypeData, 1, count);

                                    Label lblUserNameData = new Label();
                                    lblUserNameData.Dock = DockStyle.Fill;
                                    lblUserNameData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserNameData.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserNameData, 2, count);

                                    Label lblUserContactData = new Label();
                                    lblUserContactData.Dock = DockStyle.Fill;
                                    lblUserContactData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserContactData.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserContactData, 3, count);

                                    Label lblUserEmailData = new Label();
                                    lblUserEmailData.Dock = DockStyle.Fill;
                                    lblUserEmailData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserEmailData.Font = new Font("Segoe UI", 13, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserEmailData, 4, count);

                                    Button btnViewMore = new Button();
                                    btnViewMore.FlatStyle = FlatStyle.Flat;
                                    btnViewMore.FlatAppearance.BorderSize = 0;
                                    btnViewMore.Anchor = AnchorStyles.None;
                                    btnViewMore.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                                    btnViewMore.Text = "View More";
                                    btnViewMore.Cursor = Cursors.Hand;
                                    btnViewMore.BackColor = Color.FromArgb(21, 101, 192);
                                    btnViewMore.ForeColor = Color.White;
                                    btnViewMore.Size = new Size(240, 90);
                                    btnViewMore.Click += (sender, e) =>
                                    {
                                        string userType = lblUserTypeData.Text;
                                        int id = Convert.ToInt32(lblUserIDData.Text);
                                        UserViewMoreDetailsForm form = new UserViewMoreDetailsForm(id, userType);
                                        form.ShowDialog();
                                    };
                                    tblData.Controls.Add(btnViewMore, 5, count);

                                    //Populating User Data
                                    lblUserIDData.Text = reader["userId"].ToString();
                                    lblUserTypeData.Text = reader["userType"].ToString();
                                    lblUserNameData.Text = reader["userName"].ToString();
                                    lblUserContactData.Text = reader["userContact"].ToString();
                                    lblUserEmailData.Text = reader["userEmail"].ToString();
                                    /* if (userTable == "Customers")
                                    {
                                        lblUserIDData.Text = reader["userId"].ToString();
                                        lblUserTypeData.Text = "Customer";
                                        lblUserNameData.Text = reader["userName"].ToString();
                                        lblUserContactData.Text = reader["userContact"].ToString();
                                        lblUserEmailData.Text = reader["userEmail"].ToString();
                                    }
                                    else if (userTable == "Guests")
                                    {
                                        lblUserIDData.Text = reader["userId"].ToString();
                                        lblUserTypeData.Text = "Guest";
                                        lblUserNameData.Text = reader["userName"].ToString();
                                        lblUserContactData.Text = reader["userContact"].ToString();
                                    }*/


                                    if (count % 2 == 0)
                                    {
                                        tblData.BackColor = Color.PaleTurquoise;
                                    }
                                    else
                                    {
                                        tblData.BackColor = Color.White;
                                    }

                                    pnlUserDetails.Controls.Add(tblData);
                                    count++;
                                }
                                pnlUserDetails.Controls.Add(tblHeading);
                            }
                            else
                            {
                                Label noDataAvilable = new Label();
                                noDataAvilable.Text = "No Data Available...";
                                noDataAvilable.ForeColor = Color.Gray;
                                noDataAvilable.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                                noDataAvilable.Dock = DockStyle.Fill;
                                noDataAvilable.TextAlign = ContentAlignment.MiddleCenter;

                                pnlUserDetails.Controls.Add(noDataAvilable);
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
                        connection.Close();
                    }
                }
            }
        }


        private void UserControlUserManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }    
        }
        private void PopulateUsersComboBox()
        {
            comboBoxFilterUsers.Items.Clear(); //Clear the items in the combo box

            //Adding Selection options to the comboBox
            comboBoxFilterUsers.Items.Add("All Users");
            comboBoxFilterUsers.Items.Add("Customers");
            comboBoxFilterUsers.Items.Add("Guests");

            comboBoxFilterUsers.SelectedIndex = 0;
  
        }
       
        //Placeholder for the search bar
        private void Placeholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

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

        private void FilteringUsers(object sender, EventArgs e)
        {
            string searchedUser = txtSearchBar.Text.Trim();
            string selectedUserType = comboBoxFilterUsers.SelectedItem?.ToString();

            if(!string.IsNullOrEmpty(selectedUserType))
            {
                if (selectedUserType.Equals("All Users"))
                {
                    if (string.IsNullOrWhiteSpace(searchedUser) || searchedUser.Equals("Enter Username or Email..."))
                    {
                        DisplayUserDetails();
                    }
                    else
                    {
                        DisplayUserDetails(null, searchedUser);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(searchedUser) || searchedUser.Equals("Enter Username or Email..."))
                    {
                        DisplayUserDetails(selectedUserType, null);
                    }
                    else
                    {
                        DisplayUserDetails(selectedUserType, searchedUser);
                    }
                }
            }
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            bool userLoginFound = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is UserLogin)
                {
                    userLoginFound = true;
                    form.Show();
                    break;
                }
            }
            if (!userLoginFound)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
            }

            AdminDashboardForm.adminControlForm.Close();
        }
    }
}
