using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BookWise_AutoMart
{
    public partial class AdminEditItemForm : Form
    {
        // Timer for incrementing stock
        private Timer incrementTimer = new Timer();
        // Timer for decrementing stock
        private Timer decrementTimer = new Timer();

        private int id;
        byte[] previousImageData;
        private bool imageChanged = false;
        private int categoryId;
        private string subcategoryName;

        private string connectionString = DatabaseString.GetUserDatabase();

        public AdminEditItemForm(int itemId)
        {
            InitializeComponent();

            // Initialize and configure timers
            incrementTimer.Interval = 100;
            incrementTimer.Tick += (sender, e) => pictureBoxIncrementStock_Click(sender, e);
            decrementTimer.Interval = 100;
            decrementTimer.Tick += (sender, e) => pictureBoxDecrementStock_Click(sender, e);

            id = itemId;

            Placeholder("Enter Item Name", txtItemName, null);
            Placeholder("Enter Item Description", null, rtbItemDescription);
            Placeholder("Enter Item Price", txtPrice, null);
            Placeholder("Enter Item Stock", txtStock, null);
        }

        private void PopulateSubCategoriesComboBox()
        {
            comboBoxSubcategories.Items.Clear(); // Clear the items in the combo box

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT subcategory_name
                                 FROM SubCategories
                                 WHERE SubCategories.subcategory_category_id = @CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string subcategoryName = reader["subcategory_name"].ToString();
                                comboBoxSubcategories.Items.Add(subcategoryName);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AdminEditItemForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT Items.*, SubCategories.*
                                 FROM Items
                                 LEFT JOIN SubCategories ON Items.item_subcategory_id = SubCategories.subcategory_id
                                 WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ItemId", id);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                lblId.Text = id.ToString();
                                txtItemName.Text = reader["item_name"].ToString();
                                rtbItemDescription.Text = reader["item_description"].ToString();
                                txtPrice.Text = reader["price"].ToString();
                                txtStock.Text = reader["stock"].ToString();

                                categoryId = (int)reader["item_category_id"];
                                subcategoryName = reader["subcategory_name"].ToString();

                                PopulateSubCategoriesComboBox();

                                foreach (var item in comboBoxSubcategories.Items)
                                {
                                    if (item.ToString() == subcategoryName)
                                    {
                                        comboBoxSubcategories.SelectedItem = item;
                                        break;
                                    }
                                }

                                previousImageData = (byte[])reader["image"];

                                Image image;
                                using (MemoryStream ms = new MemoryStream(previousImageData))
                                {
                                    image = Image.FromStream(ms);
                                }

                                pictureBoxImage.Image = image;
                            }
                            else
                            {
                                lblId.Text = "Error";
                                txtItemName.Text = "Error";
                                rtbItemDescription.Text = "Error";
                                txtPrice.Text = "Error";
                                txtStock.Text = "Error";

                                pictureBoxImage.Image = null;

                                MessageBox.Show("Item does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            // Do not allow multiple file selection
            openFileDialog.Multiselect = false;

            // Display OpenFileDialog by calling ShowDialog method
            DialogResult result = openFileDialog.ShowDialog();

            // Check if the user selected a file
            if (result == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                try
                {
                    // Load the selected image
                    Image selectedImage = Image.FromFile(filePath);
                    pictureBoxImage.Image = selectedImage;
                    imageChanged = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the selected image: " + ex.Message);
                }
            }
        }
        private void DisplayErrorMessages(string errors)
        {
            string[] errorMessages = errors.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
            // split the errors into sub-errors (separated using the new line character)
            // StringSplitOptions.RemoveEmptyEntries --> excludes any empty strings

            foreach (string errorMessage in errorMessages)
            {
                if (errorMessage.Contains("Please fill out all the fields"))
                {
                    lblRequiredFields.Visible = true;
                    lblItemNameRequired.Visible = true;
                    lblItemDescriptionRequired.Visible = true;
                    lblPriceRequired.Visible = true;
                    lblStockRequired.Visible = true;
                }

                if (errorMessage.Contains("Please enter item name"))
                {
                    lblItemNameRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Please enter item description"))
                {
                    lblItemDescriptionRequired.Visible = true;
                    lblRequiredFields.Visible = true;
                }

                if (errorMessage.Contains("Please enter item price") || errorMessage.Contains("Please enter a valid price"))
                {
                    if (errorMessage.Contains("Please enter item price"))
                    {
                        lblPriceRequired.Text = "*";
                        lblRequiredFields.Visible = true;
                    }
                    else if (errorMessage.Contains("Please enter a valid price"))
                    {
                        lblPriceRequired.Text = "Please enter a valid price";
                    }

                    lblPriceRequired.Visible = true;
                }

                if (errorMessage.Contains("Please enter item stock") || errorMessage.Contains("Please enter a valid stock"))
                {
                    if (errorMessage.Contains("Please enter item stock"))
                    {
                        lblStockRequired.Text = "*";
                        lblRequiredFields.Visible = true;
                    }
                    else if (errorMessage.Contains("Please enter a valid stock"))
                    {
                        lblStockRequired.Text = "Please enter a valid stock";
                    }

                    lblStockRequired.Visible = true;
                }
            }
        }
        private void ClearErrorMessages()
        {
            lblPriceRequired.Text = "*";
            lblStockRequired.Text = "*";

            lblRequiredFields.Visible = false;
            lblItemNameRequired.Visible = false;
            lblItemDescriptionRequired.Visible = false;
            lblPriceRequired.Visible = false;
            lblStockRequired.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ClearErrorMessages();

            string errors = "";

            if (IsFieldEmpty(txtItemName) && IsFieldEmpty(null, rtbItemDescription) && IsFieldEmpty(txtPrice) && IsFieldEmpty(txtStock))
            {
                errors += "Please fill out all the fields\n";
            }
            else
            {
                if (IsFieldEmpty(txtItemName))
                {
                    errors += "Please enter item name\n";
                }

                if (IsFieldEmpty(null, rtbItemDescription))
                {
                    errors += "Please enter item description\n";
                }

                if (IsFieldEmpty(txtPrice))
                {
                    errors += "Please enter item price\n";
                }
                else if (!IsValidPrice(txtPrice))
                {
                    errors += "Please enter a valid price\n";
                }

                if (IsFieldEmpty(txtStock))
                {
                    errors += "Please enter item stock\n";
                }
                else if (!IsValidStock(txtStock))
                {
                    errors += "Please enter a valid stock\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                DisplayErrorMessages(errors);
                return;
            }
            
            UpdateItem();
        }
        private void UpdateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET item_name = @ItemName, item_description = @ItemDescription, item_subcategory_id = @SubcategoryId, price = @Price, stock = @Stock, temporary_stock = @Stock, image = @ImageData WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ItemId", id);
                        command.Parameters.AddWithValue("@ItemName", $"{txtItemName.Text.Trim()}");
                        command.Parameters.AddWithValue("@ItemDescription", $"{rtbItemDescription.Text.Trim()}");

                        string selectedSubcategory = comboBoxSubcategories.SelectedItem.ToString();
                        int subcategoryId = GetSubcategoryId(selectedSubcategory);
                        command.Parameters.AddWithValue("@SubcategoryId", subcategoryId);

                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text.Trim()));
                        command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text.Trim()));

                        byte[] imageData;

                        // check if item image changed
                        if (imageChanged)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pictureBoxImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                imageData = ms.ToArray();
                            }
                        }
                        else
                        {
                            imageData = previousImageData;
                        }

                        command.Parameters.AddWithValue("@ImageData", imageData);
                    
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item details updated successfully.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();   // Refresh form
                        }
                        else
                        {
                            MessageBox.Show("Failed to update item details.", "Update Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int GetSubcategoryId(string subcategoryName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT subcategory_id FROM SubCategories WHERE subcategory_name = @SubcategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@SubcategoryName", subcategoryName);

                        connection.Open();

                        int subcategoryId = (int)command.ExecuteScalar();

                        return subcategoryId;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving subcategory id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return -1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"[Item ID: {id}]\nAre you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteItem(id);
            }
        }
        private void DeleteItem(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Items WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ItemId", id);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"[Item ID: {id}]\nItem deleted successfully.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                            AdminControlForm.btnReloadInventoryManagementForm.PerformClick();   // Refresh form
                        }
                        else
                        {
                            MessageBox.Show($"[Item ID: {id}]\nUnable to delete item.", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Placeholder(string placeholder, TextBox textBox = null, RichTextBox rtb = null)
        {
            if (textBox == null)
            {
                rtb.GotFocus += (sender, e) =>
                {
                    if (rtb.Text == placeholder)
                    {
                        rtb.Text = "";
                        rtb.ForeColor = SystemColors.WindowText;
                    }
                };

                rtb.LostFocus += (sender, e) =>
                {
                    if (string.IsNullOrWhiteSpace(rtb.Text))
                    {
                        rtb.Text = placeholder;
                        rtb.ForeColor = SystemColors.GrayText;
                    }
                };
            }
            else
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
        }

        private bool IsFieldEmpty(TextBox textBox = null, RichTextBox rtb = null)
        {
            if (textBox == null)
            {
                if (rtb == rtbItemDescription)
                {
                    if (rtb.Text.Trim() == "Enter Item Description" || string.IsNullOrWhiteSpace(rtb.Text))
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (textBox == txtItemName)
                {
                    if (textBox.Text.Trim() == "Enter Item Name" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (textBox == txtPrice)
                {
                    if (textBox.Text.Trim() == "Enter Item Price" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
                else if (textBox == txtStock)
                {
                    if (textBox.Text.Trim() == "Enter Item Stock" || string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool IsValidPrice(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out decimal price))
            {
                if (price >= 0) // Price cannot be negative
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
        private bool IsValidStock(TextBox textBox)
        {
            string stock = textBox.Text.Trim();

            foreach (char character in stock)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            // Stock cannot be negative
            if (Convert.ToInt32(stock) < 0)
            {
                return false;
            }

            return true;
        }

        private void pictureBoxIncrementStock_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtStock))
            {
                incrementTimer.Stop();
                DisplayErrorMessages("Please enter item stock");
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                incrementTimer.Stop();
                DisplayErrorMessages("Please enter a valid stock");
                return;
            }

            int stock = Convert.ToInt32(txtStock.Text);
            stock++;
            txtStock.Text = stock.ToString();
        }
        private void pictureBoxIncrementStock_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.LightGray;
        }
        private void pictureBoxIncrementStock_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxIncrementStock.BackColor = SystemColors.Control;
        }
        private void pictureBoxIncrementStock_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.Gray;
            incrementTimer.Start();
        }
        private void pictureBoxIncrementStock_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxIncrementStock.BackColor = Color.LightGray;
            incrementTimer.Stop();
        }

        private void pictureBoxDecrementStock_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtStock))
            {
                decrementTimer.Stop();
                DisplayErrorMessages("Please enter item stock");
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                decrementTimer.Stop();
                DisplayErrorMessages("Please enter a valid stock");
                return;
            }

            int stock = Convert.ToInt32(txtStock.Text);

            if (stock == 0)
            {
                decrementTimer.Stop();
                MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            stock--;
            txtStock.Text = stock.ToString();
        }
        private void pictureBoxDecrementStock_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.LightGray;
        }
        private void pictureBoxDecrementStock_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDecrementStock.BackColor = SystemColors.Control;
        }
        private void pictureBoxDecrementStock_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.Gray;
            decrementTimer.Start();
        }
        private void pictureBoxDecrementStock_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxDecrementStock.BackColor = Color.LightGray;
            decrementTimer.Stop();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtItemName))
            {
                lblItemNameRequired.Visible = false;
            }
        }
        private void rtbItemDescription_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(null, rtbItemDescription))
            {
                lblItemDescriptionRequired.Visible = false;
            }
        }
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtPrice))
            {
                lblPriceRequired.Visible = false;
            }
        }
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            if (!IsFieldEmpty(txtStock))
            {
                lblStockRequired.Visible = false;
            }
        }
    }
}
