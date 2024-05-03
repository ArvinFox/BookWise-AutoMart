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
    public partial class UserControlOffersPromotions : UserControl
    {
        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public UserControlOffersPromotions()
        {
            InitializeComponent();

            // Subscribe to the ParentChanged event to update the size when the parent changes
            this.ParentChanged += UserControlOffersPromotions_ParentChanged;
        }

        private void DisplayOffers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Offers ORDER BY offer_id DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                int count = 0;  // current row

                                TableLayoutPanel tblOffersHeading = new TableLayoutPanel();
                                tblOffersHeading.Dock = DockStyle.Top;
                                tblOffersHeading.Width = this.Width;
                                tblOffersHeading.ColumnCount = 8;
                                tblOffersHeading.BackColor = Color.Gold;
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                tblOffersHeading.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250));

                                // Offer ID
                                Label lblOfferIdHeading = new Label();
                                lblOfferIdHeading.Text = "Offer ID";
                                lblOfferIdHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferIdHeading.Dock = DockStyle.Fill;
                                lblOfferIdHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferIdHeading, 0, count);

                                // Offer Name
                                Label lblOfferNameHeading = new Label();
                                lblOfferNameHeading.Text = "Offer Name";
                                lblOfferNameHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferNameHeading.Dock = DockStyle.Fill;
                                lblOfferNameHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferNameHeading, 1, count);

                                // Offer Start Date
                                Label lblOfferStartDateHeading = new Label();
                                lblOfferStartDateHeading.Text = "Offer Start Date";
                                lblOfferStartDateHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferStartDateHeading.Dock = DockStyle.Fill;
                                lblOfferStartDateHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferStartDateHeading, 2, count);

                                // Offer End Date
                                Label lblOfferEndDateHeading = new Label();
                                lblOfferEndDateHeading.Text = "Offer End Date";
                                lblOfferEndDateHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferEndDateHeading.Dock = DockStyle.Fill;
                                lblOfferEndDateHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferEndDateHeading, 3, count);

                                // Offer Discount Percentage
                                Label lblOfferDiscountPercentageHeading = new Label();
                                lblOfferDiscountPercentageHeading.Text = "Discount Percentage";
                                lblOfferDiscountPercentageHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferDiscountPercentageHeading.Dock = DockStyle.Fill;
                                lblOfferDiscountPercentageHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferDiscountPercentageHeading, 4, count);

                                // Offer Applicable Items
                                Label lblOfferApplicableItemsHeading = new Label();
                                lblOfferApplicableItemsHeading.Text = "Applicable Items";
                                lblOfferApplicableItemsHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferApplicableItemsHeading.Dock = DockStyle.Fill;
                                lblOfferApplicableItemsHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferApplicableItemsHeading, 5, count);

                                // Offer Status
                                Label lblOfferStatusHeading = new Label();
                                lblOfferStatusHeading.Text = "Active";
                                lblOfferStatusHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblOfferStatusHeading.Dock = DockStyle.Fill;
                                lblOfferStatusHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblOfferStatusHeading, 6, count);

                                // Action
                                Label lblActionHeading = new Label();
                                lblActionHeading.Text = "Action";
                                lblActionHeading.Font = new Font("Gadugi", 14, FontStyle.Bold);
                                lblActionHeading.Dock = DockStyle.Fill;
                                lblActionHeading.TextAlign = ContentAlignment.MiddleCenter;
                                tblOffersHeading.Controls.Add(lblActionHeading, 7, count);

                                while (reader.Read())
                                {
                                    // Create a new row for each offer
                                    TableLayoutPanel tblOffers = new TableLayoutPanel();
                                    tblOffers.Dock = DockStyle.Top;
                                    tblOffers.Width = this.Width;
                                    tblOffers.ColumnCount = 8;
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10));
                                    tblOffers.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250));

                                    // change background row by row (even numbered rows)
                                    if (count % 2 == 0)
                                    {
                                        tblOffers.BackColor = Color.LightBlue;
                                    }
                                    else
                                    {
                                        tblOffers.BackColor = Color.LightGray;
                                    }

                                    // Offer ID
                                    Label lblOfferId = new Label();
                                    lblOfferId.Text = reader["offer_id"].ToString();
                                    int offerId = Convert.ToInt32(lblOfferId.Text); // used to manage offers
                                    lblOfferId.Font = new Font("Gadugi", 13);
                                    lblOfferId.Dock = DockStyle .Fill;
                                    lblOfferId.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferId, 0, count);

                                    // Offer Name
                                    Label lblOfferName = new Label();
                                    lblOfferName.Text = reader["offer_name"].ToString();
                                    lblOfferName.Font = new Font("Gadugi", 13);
                                    lblOfferName.Dock = DockStyle.Fill;
                                    lblOfferName.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferName, 1, count);

                                    // Offer Start Date
                                    Label lblOfferStartDate = new Label();
                                    lblOfferStartDate.Text = ((DateTime)reader["offer_start_date"]).ToShortDateString();
                                    lblOfferStartDate.Font = new Font("Gadugi", 13);
                                    lblOfferStartDate.Dock = DockStyle.Fill;
                                    lblOfferStartDate.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferStartDate, 2, count);

                                    // Offer End Date
                                    Label lblOfferEndDate = new Label();
                                    lblOfferEndDate.Text = ((DateTime)reader["offer_end_date"]).ToShortDateString();
                                    lblOfferEndDate.Font = new Font("Gadugi", 13);
                                    lblOfferEndDate.Dock = DockStyle.Fill;
                                    lblOfferEndDate.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferEndDate, 3, count);

                                    // Offer Discount Percentage
                                    Label lblOfferDiscountPercentage = new Label();
                                    lblOfferDiscountPercentage.Text = reader["discount_percentage"].ToString() + "%";
                                    lblOfferDiscountPercentage.Font = new Font("Gadugi", 13);
                                    lblOfferDiscountPercentage.Dock = DockStyle.Fill;
                                    lblOfferDiscountPercentage.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferDiscountPercentage, 4, count);

                                    // Offer Applicable Items
                                    Label lblOfferApplicableItems = new Label();
                                    lblOfferApplicableItems.Text = reader["applicable_items"].ToString();
                                    lblOfferApplicableItems.Font = new Font("Gadugi", 13);
                                    lblOfferApplicableItems.Dock = DockStyle.Fill;
                                    lblOfferApplicableItems.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferApplicableItems, 5, count);

                                    // Offer Status
                                    Label lblOfferStatus = new Label();
                                    lblOfferStatus.Text = reader["is_active"].ToString();
                                    lblOfferStatus.Font = new Font("Gadugi", 13);
                                    lblOfferStatus.Dock = DockStyle.Fill;
                                    lblOfferStatus.TextAlign = ContentAlignment.MiddleCenter;
                                    tblOffers.Controls.Add(lblOfferStatus, 6, count);

                                    // Action buttons container
                                    TableLayoutPanel tblActionButtons = new TableLayoutPanel();
                                    tblActionButtons.ColumnCount = 2;
                                    tblActionButtons.Dock = DockStyle.Fill;
                                    tblActionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                                    tblActionButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                                    // Action --> Edit button
                                    Button btnEditOffer = new Button();
                                    btnEditOffer.FlatStyle = FlatStyle.Flat;
                                    btnEditOffer.FlatAppearance.BorderSize = 0;
                                    btnEditOffer.Anchor = AnchorStyles.None;
                                    btnEditOffer.Font = new Font("Gadugi", 13, FontStyle.Bold);
                                    btnEditOffer.Text = "Edit";
                                    btnEditOffer.Cursor = Cursors.Hand;
                                    btnEditOffer.BackColor = Color.DodgerBlue;
                                    btnEditOffer.ForeColor = Color.White;
                                    btnEditOffer.Size = new Size(120, 45);
                                    btnEditOffer.Click += (sender, e) =>
                                    {
                                        bool adminEditOfferFormFound = false;

                                        foreach (Form form in Application.OpenForms)
                                        {
                                            if (form is AdminEditOfferForm)
                                            {
                                                form.ShowDialog();
                                                adminEditOfferFormFound = true;
                                                break;
                                            }
                                        }

                                        if (!adminEditOfferFormFound)
                                        {
                                            AdminEditOfferForm adminEditOfferForm = new AdminEditOfferForm(offerId);
                                            adminEditOfferForm.ShowDialog();
                                        }
                                    };
                                    tblActionButtons.Controls.Add(btnEditOffer, 0, 0);

                                    // Action --> Delete button
                                    Button btnDeleteOffer = new Button();
                                    btnDeleteOffer.FlatStyle = FlatStyle.Flat;
                                    btnDeleteOffer.FlatAppearance.BorderSize = 0;
                                    btnDeleteOffer.Anchor = AnchorStyles.None;
                                    btnDeleteOffer.Font = new Font("Gadugi", 13, FontStyle.Bold);
                                    btnDeleteOffer.Text = "Delete";
                                    btnDeleteOffer.Cursor = Cursors.Hand;
                                    btnDeleteOffer.BackColor = Color.Red;
                                    btnDeleteOffer.ForeColor = Color.White;
                                    btnDeleteOffer.Size = new Size(120, 45);
                                    btnDeleteOffer.Click += (sender, e) =>
                                    {
                                        DialogResult result = MessageBox.Show($"[Offer ID: {offerId}]\nAre you sure you want to delete this offer?", "Delete Offer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                        if (result == DialogResult.Yes)
                                        {
                                            DeleteOffer(offerId);
                                        }
                                    };
                                    tblActionButtons.Controls.Add(btnDeleteOffer, 1, 0);

                                    // Add Action buttons container to table (main)
                                    tblOffers.Controls.Add(tblActionButtons, 7, count);

                                    count++;

                                    // Add the row to the UserControl
                                    tblOffers.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                                    tblOffers.Padding = new Padding(5); // Add some padding
                                    tblOffers.Margin = new Padding(5); // Add margin between rows

                                    pnlDisplayOffers.Controls.Add(tblOffers);
                                }

                                pnlDisplayOffers.Controls.Add(tblOffersHeading);
                            }
                            else
                            {
                                Label noOffersLabel = new Label();
                                noOffersLabel.Text = "No offers available.";
                                noOffersLabel.ForeColor = Color.DarkGray;
                                noOffersLabel.Font = new Font("Gadugi", 15, FontStyle.Bold);
                                noOffersLabel.TextAlign = ContentAlignment.MiddleCenter;
                                noOffersLabel.Padding = new Padding(12);
                                noOffersLabel.AutoSize = true;

                                pnlDisplayOffers.Controls.Add(noOffersLabel);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving offers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UserControlOffersPromotions_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                // To take the entire screen size
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }

        private void UserControlOffersPromotions_Load(object sender, EventArgs e)
        {
            this.Padding = new Padding(10);
            DisplayOffers();
        }

        private void DeleteOffer(int offerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Offers WHERE offer_id = @OfferId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@OfferId", offerId);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Offer deleted successfully.", "Delete Offer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AdminControlForm.btnReloadOffersPromotionsForm.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Unable to delete offer.", "Delete Offer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error delete offer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnAddNewOffer_Click(object sender, EventArgs e)
        {
            bool adminAddNewOfferFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is AdminAddNewOfferForm)
                {
                    form.ShowDialog();
                    adminAddNewOfferFormFound = true;
                    break;
                }
            }

            if (!adminAddNewOfferFormFound)
            {
                AdminAddNewOfferForm adminAddNewOfferForm = new AdminAddNewOfferForm();
                adminAddNewOfferForm.ShowDialog();
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
