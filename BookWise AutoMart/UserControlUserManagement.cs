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
    public partial class UserControlUserManagement : UserControl
    {
        public UserControlUserManagement()
        {
            InitializeComponent();
            this.ParentChanged += UserControlUserManagement_ParentChanged;
        }

        private string connectionString = DatabaseString.GetUserDatabase();

        private void DisplayUserDetails()
        {
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
            tblHeading.BackColor = Color.DodgerBlue;

            Label lblUserID = new Label();
            lblUserID.Text = "ID";
            lblUserID.Dock = DockStyle.Fill;
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            lblUserID.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserID, 0, 0);

            Label lblUserType = new Label();
            lblUserType.Text = "User Type";
            lblUserType.Dock = DockStyle.Fill;
            lblUserType.TextAlign = ContentAlignment.MiddleCenter;
            lblUserType.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserType, 1, 0);

            Label lblUserName = new Label();
            lblUserName.Text = "User Name";
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserName, 2, 0);

            Label lblUserContact = new Label();
            lblUserContact.Text = "User Contact";
            lblUserContact.Dock = DockStyle.Fill;
            lblUserContact.TextAlign = ContentAlignment.MiddleCenter;
            lblUserContact.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserContact, 3, 0);

            Label lblUserEmail = new Label();
            lblUserEmail.Text = "User Email";
            lblUserEmail.Dock = DockStyle.Fill;
            lblUserEmail.TextAlign = ContentAlignment.MiddleCenter;
            lblUserEmail.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tblHeading.Controls.Add(lblUserEmail, 4, 0);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT 'Users' AS 
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
                                    guest_id DESC, user_id DESC;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
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
                                    lblUserIDData.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserIDData, 0, count);

                                    Label lblUserTypeData = new Label();
                                    lblUserTypeData.Dock = DockStyle.Fill;
                                    lblUserTypeData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserTypeData.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserTypeData, 1, count);

                                    Label lblUserNameData = new Label();
                                    lblUserNameData.Dock = DockStyle.Fill;
                                    lblUserNameData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserNameData.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserNameData, 2, count);

                                    Label lblUserContactData = new Label();
                                    lblUserContactData.Dock = DockStyle.Fill;
                                    lblUserContactData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserContactData.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserContactData, 3, count);

                                    Label lblUserEmailData = new Label();
                                    lblUserEmailData.Dock = DockStyle.Fill;
                                    lblUserEmailData.TextAlign = ContentAlignment.MiddleCenter;
                                    lblUserEmailData.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                                    tblData.Controls.Add(lblUserEmailData, 4, count);

                                    Button btnViewMore = new Button();
                                    btnViewMore.Dock = DockStyle.Fill;
                                    btnViewMore.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                                    btnViewMore.Text = "View More";
                                    btnViewMore.Click += (sender, e) =>
                                    {
                                        string userType = lblUserTypeData.Text;
                                        int id = Convert.ToInt32(lblUserIDData.Text);
                                        UserViewMoreDetailsForm form = new UserViewMoreDetailsForm(id, userType);
                                        form.ShowDialog();
                                    };
                                    tblData.Controls.Add(btnViewMore, 5, count);

                                    string sourceTable = reader["source_table"].ToString();

                                    if (sourceTable == "Users")
                                    {
                                        lblUserIDData.Text = reader["user_id"].ToString();
                                        lblUserTypeData.Text = "Customer";
                                        lblUserNameData.Text = reader["name"].ToString();
                                        lblUserContactData.Text = reader["contact_number"].ToString();
                                        lblUserEmailData.Text = reader["email"].ToString();
                                    }
                                    else if (sourceTable == "Guests")
                                    {
                                        lblUserIDData.Text = reader["guest_id"].ToString();
                                        lblUserTypeData.Text = "Guest";
                                        lblUserNameData.Text = reader["guest_name"].ToString();
                                        lblUserContactData.Text = reader["guest_contact_number"].ToString();
                                    }


                                    if (count % 2 == 0)
                                    {
                                        tblData.BackColor = Color.AliceBlue;
                                    }
                                    else
                                    {
                                        tblData.BackColor = Color.PaleGreen;
                                    }

                                    this.Controls.Add(tblData);
                                    count++;
                                }
                                this.Controls.Add(tblHeading);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception sqlex)
                    {
                        MessageBox.Show(sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void UserControlUserManagement_Load(object sender, EventArgs e)
        {
            DisplayUserDetails();
        }

        private void UserControlUserManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }    
        }
    }
}
