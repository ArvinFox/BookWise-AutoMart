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
    public partial class AdminEditOfferForm : Form
    {
        private readonly int id;
        private string applicableItems = "";

        private readonly string connectionString = DatabaseString.GetUserDatabase();

        public AdminEditOfferForm(int offerId)
        {
            InitializeComponent();

            id = offerId;

            PopulateItemsComboBox();
            Placeholder(txtOfferName, "Enter Offer Name");
            Placeholder(txtDiscountPercentage, "Enter Discount (%)");
        }

        private void PopulateItemsComboBox()
        {
            comboBoxApplicableItems.Items.Clear(); // Clear the items in the combo box

            comboBoxApplicableItems.Items.Add("Select an Item");

            comboBoxApplicableItems.SelectedIndex = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Items";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemName = reader["item_name"].ToString();
                                comboBoxApplicableItems.Items.Add(itemName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void DisplaySelectedItems(string items)
        {
            pnlSelectedItems.Controls.Clear();  // Clear existing items

            // Split the applicable items into individual item ids
            string[] itemIds = items.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Iterate through each item id and fetch its name (from Items table)
            foreach (string itemId in itemIds)
            {
                int itemIdInt = Convert.ToInt32(itemId.Trim());
                string itemName = GetItemNameById(itemIdInt);

                // Item container
                TableLayoutPanel tblItem = new TableLayoutPanel();
                tblItem.Dock = DockStyle.Top;
                tblItem.ColumnCount = 2;
                tblItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
                tblItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
                tblItem.Height = 40;

                Label lblItem = new Label();
                lblItem.AutoSize = true;
                lblItem.Anchor = AnchorStyles.Left;
                lblItem.Text = $"[{itemIdInt}] {itemName}";
                tblItem.Controls.Add(lblItem, 0, 0);

                Button btnRemoveItem = new Button();
                btnRemoveItem.Anchor = AnchorStyles.None;
                btnRemoveItem.FlatStyle = FlatStyle.Flat;
                btnRemoveItem.FlatAppearance.BorderSize = 0;
                btnRemoveItem.Font = new Font("Gadugi", 11, FontStyle.Bold);
                btnRemoveItem.Size = new Size(110, 30);
                btnRemoveItem.Text = "Remove";
                btnRemoveItem.Cursor = Cursors.Hand;
                btnRemoveItem.BackColor = Color.Tomato;
                btnRemoveItem.ForeColor = Color.White;
                btnRemoveItem.Tag = itemId;
                btnRemoveItem.Click += (sender, e) =>
                {
                    if (pnlSelectedItems.Controls.Count == 1)
                    {
                        ResetSelectedItems();
                    }

                    // remove the item ID from the applicableItems string
                    string itemIdToRemove = btnRemoveItem.Tag.ToString();
                    string[] updatedItemIds = itemIds.Where(id => id != itemIdToRemove).ToArray();
                    string updatedItems = string.Join(",", updatedItemIds);

                    // update the applicableItems string
                    applicableItems = updatedItems;

                    itemIds = updatedItemIds;

                    // get the parent row of the button
                    TableLayoutPanel parentTableLayoutPanel = (TableLayoutPanel)btnRemoveItem.Parent;

                    // remove the corresponding row (table layout panel)
                    pnlSelectedItems.Controls.Remove(parentTableLayoutPanel);
                };
                tblItem.Controls.Add(btnRemoveItem, 1, 0);

                pnlSelectedItems.Controls.Add(tblItem);
            }
        }
        private string GetItemNameById(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT item_name FROM Items WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ItemId", itemId);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            return "Unknown item";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving item name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return "Unknown item";
                    }
                }
            }
        }
        private void UpdateOffer()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Offers SET offer_name = @OfferName, offer_start_date = @OfferStartDate, offer_end_date = @OfferEndDate, discount_percentage = @DiscountPercentage, applicable_items = @ApplicableItems, is_active = @IsActive WHERE offer_id = @OfferId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@OfferName", txtOfferName.Text.Trim());
                        command.Parameters.AddWithValue("@OfferStartDate", Convert.ToDateTime(dtpStartDate.Value).ToShortDateString());
                        command.Parameters.AddWithValue("@OfferEndDate", Convert.ToDateTime(dtpEndDate.Value).ToShortDateString());
                        command.Parameters.AddWithValue("@DiscountPercentage", txtDiscountPercentage.Text.Trim());
                        command.Parameters.AddWithValue("@ApplicableItems", applicableItems);
                        command.Parameters.AddWithValue("@IsActive", radActive.Checked ? true : false);
                        command.Parameters.AddWithValue("@OfferId", lblId.Text.Trim());

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Offer details updated successfully.", "Update Offer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                            AdminControlForm.btnReloadOffersPromotionsForm.PerformClick();   // Refresh form
                        }
                        else
                        {
                            MessageBox.Show("Failed to update offer details.", "Update Offer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating offer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxApplicableItems.SelectedItem.ToString();

            if (selectedItem.Equals("Select an Item"))
            {
                lblApplicableItemsError.Visible = true;
                return;
            }
            else
            {
                lblApplicableItemsError.Visible = false;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT item_id FROM Items WHERE item_name = @ItemName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@ItemName", selectedItem);

                            connection.Open();

                            int itemId = (int)command.ExecuteScalar();

                            if (applicableItems.Split(',').Any(s => s.Trim() == itemId.ToString()))
                            {
                                lblApplicableItemsError.Text = "Item already added";
                                lblApplicableItemsError.Visible = true;
                            }
                            else
                            {
                                // Add selected item id to applicable items
                                if (applicableItems.Trim() == "")
                                {
                                    applicableItems += itemId;
                                }
                                else
                                {
                                    applicableItems += ", " + itemId;
                                }

                                DisplaySelectedItems(applicableItems);  // update the items
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving item id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            string errors = "";

            if (IsFieldEmpty(txtOfferName) && IsFieldEmpty(txtDiscountPercentage) && (!radActive.Checked && !radInactive.Checked))
            {
                errors += "Please fill out all the fields\n";
            }
            else
            {
                if (IsFieldEmpty(txtOfferName))
                {
                    errors += "Please enter offer name\n";
                }

                if (!IsValidDate(dtpStartDate, dtpEndDate))
                {
                    errors += "Invalid date\n";
                }

                if (IsFieldEmpty(txtDiscountPercentage))
                {
                    errors += "Please enter offer discount (%)\n";
                }
                else if (!IsValidDiscount(txtDiscountPercentage))
                {
                    errors += "Invalid discount\n";
                }

                if (applicableItems.Trim() == "" || applicableItems.Trim() == ",")
                {
                    errors += "Please add applicable items to the offer\n";
                }

                if (!radActive.Checked && !radInactive.Checked)
                {
                    errors += "Please select the status of the offer\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                DisplayErrorMessages(errors);
                return;
            }

            UpdateOffer();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminEditOfferForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * From Offers WHERE offer_id = @OfferId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@OfferId", id);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                lblId.Text = id.ToString();
                                txtOfferName.Text = reader["offer_name"].ToString();
                                dtpStartDate.Value = Convert.ToDateTime(reader["offer_start_date"]);
                                dtpEndDate.Value = Convert.ToDateTime(reader["offer_end_date"]);
                                txtDiscountPercentage.Text = reader["discount_percentage"].ToString();
                                if ((bool)reader["is_active"] == true)
                                {
                                    radActive.Checked = true;
                                }
                                else
                                {
                                    radInactive.Checked = true;
                                }

                                applicableItems = reader["applicable_items"].ToString();

                                DisplaySelectedItems(applicableItems);
                            }
                            else
                            {
                                lblId.Text = "Error";
                                txtOfferName.Text = "Error";
                                dtpStartDate.Text = "Error";
                                dtpEndDate.Text = "Error";
                                txtDiscountPercentage.Text = "Error";
                                comboBoxApplicableItems.Items.Clear();
                                pnlSelectedItems.Controls.Clear();

                                MessageBox.Show("Offer does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                btnCancel.PerformClick();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
        private void ResetSelectedItems()
        {
            pnlSelectedItems.Controls.Clear();

            // Item container
            TableLayoutPanel tblNoItems = new TableLayoutPanel();
            tblNoItems.Dock = DockStyle.Top;
            tblNoItems.ColumnCount = 1;
            tblNoItems.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tblNoItems.Height = 40;

            Label lblNoItems = new Label();
            lblNoItems.AutoSize = true;
            lblNoItems.Anchor = AnchorStyles.Left;
            lblNoItems.ForeColor = SystemColors.GrayText;
            lblNoItems.Text = "Add Items to the Offer";
            tblNoItems.Controls.Add(lblNoItems, 0, 0);

            pnlSelectedItems.Controls.Add(tblNoItems);
        }

        private void DisplayErrorMessages(string errors)
        {
            string[] errorMessages = errors.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // split the errors into sub-errors (separated using the new line character)
            // StringSplitOptions.RemoveEmptyEntries --> excludes any empty strings

            foreach (string errorMessage in errorMessages)
            {
                if (errorMessage.Contains("Please fill out all the fields"))
                {
                    lblFieldsError.Visible = true;
                    lblOfferNameError.Visible = true;
                    lblDiscountPercentageError.Visible = true;
                    lblDisplaySelectedItemsError.Visible = true;
                    lblOfferStatusError.Visible = true;
                }

                if (errorMessage.Contains("Please enter offer name"))
                {
                    lblOfferNameError.Visible = true;
                    lblFieldsError.Visible = true;
                }

                if (errorMessage.Contains("Invalid date"))
                {
                    lblEndDateError.Visible = true;
                }

                if (errorMessage.Contains("Please enter offer discount (%)") || errorMessage.Contains("Invalid discount"))
                {
                    if (errorMessage.Contains("Please enter offer discount (%)"))
                    {
                        lblDiscountPercentageError.Text = "*";
                        lblFieldsError.Visible = true;
                    }
                    else if (errorMessage.Contains("Invalid discount"))
                    {
                        lblDiscountPercentageError.Text = "Invalid discount";
                    }

                    lblDiscountPercentageError.Visible = true;
                }

                if (errorMessage.Contains("Please add applicable items to the offer"))
                {
                    lblDisplaySelectedItemsError.Visible = true;
                    lblFieldsError.Visible = true;
                }

                if (errorMessage.Contains("Please select the status of the offer"))
                {
                    lblOfferStatusError.Visible = true;
                    lblFieldsError.Visible = true;
                }
            }
        }
        private void ClearErrorMessages()
        {
            lblDiscountPercentageError.Text = "*";
            lblApplicableItemsError.Text = "Select an Item to Add";

            lblFieldsError.Visible = false;
            lblOfferNameError.Visible = false;
            lblStartDateError.Visible = false;
            lblEndDateError.Visible = false;
            lblDiscountPercentageError.Visible = false;
            lblApplicableItemsError.Visible = false;
            lblDisplaySelectedItemsError.Visible = false;
            lblOfferStatusError.Visible = false;
        }

        private bool IsFieldEmpty(TextBox textBox = null, RichTextBox rtb = null)
        {
            if (textBox == txtOfferName)
            {
                if (textBox.Text.Trim() == "Enter Offer Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtDiscountPercentage)
            {
                if (textBox.Text.Trim() == "Enter Discount (%)" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsValidDiscount(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out decimal discount))
            {
                if (discount >= 0) // Discount cannot be negative
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool IsValidDate(DateTimePicker dtpStartDate, DateTimePicker dtpEndDate)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (endDate > startDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtOfferName_TextChanged(object sender, EventArgs e)
        {
            lblOfferNameError.Visible = false;
        }
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDateError.Visible = false;
        }
        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDateError.Visible = false;
        }
        private void txtDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            lblDiscountPercentageError.Visible = false;
        }
        private void comboBoxApplicableItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblApplicableItemsError.Visible = false;
        }
        private void radActive_CheckedChanged(object sender, EventArgs e)
        {
            lblOfferStatusError.Visible = false;
        }
        private void radInactive_CheckedChanged(object sender, EventArgs e)
        {
            lblOfferStatusError.Visible = false;
        }

        private void txtOfferName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dtpStartDate.Focus();
            }
        }
        private void dtpStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dtpEndDate.Focus();
            }
        }
        private void dtpEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtDiscountPercentage.Focus();
            }
        }
        private void txtDiscountPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                comboBoxApplicableItems.Focus();
            }
        }
        private void comboBoxApplicableItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAddItem.PerformClick();
            }
        }
        private void radActive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSave.PerformClick();
            }
        }
        private void radInactive_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSave.PerformClick();
            }
        }
    }
}
