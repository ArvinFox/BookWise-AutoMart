using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public partial class AdminEditItemForm : Form
    {
        // Timer for incrementing stock
        private Timer incrementTimer = new Timer();
        // Timer for decrementing stock
        private Timer decrementTimer = new Timer();

        int id;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\arvin\\source\\repos\\BookWise-AutoMart\\BookWise AutoMart\\BookWiseAutoMart.mdf\";Integrated Security=True";

        public AdminEditItemForm(int itemId)
        {
            InitializeComponent();

            // Initialize and configure timers
            incrementTimer.Interval = 100;
            incrementTimer.Tick += (sender, e) => pictureBoxIncrementStock_Click(sender, e);
            decrementTimer.Interval = 100;
            decrementTimer.Tick += (sender, e) => pictureBoxDecrementStock_Click(sender, e);

            id = itemId;

            Placeholder(txtItemName, "Enter Item Name");
            Placeholder(txtItemDescription, "Enter Item Description");
            Placeholder(txtPrice, "Enter Item Price");
            Placeholder(txtStock, "Enter Item Stock");
        }

        private void AdminEditItemForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Items WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", id);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                lblId.Text = id.ToString();
                                txtItemName.Text = reader["item_name"].ToString();
                                txtItemDescription.Text = reader["item_description"].ToString();
                                txtPrice.Text = reader["price"].ToString();
                                txtStock.Text = reader["stock"].ToString();

                                byte[] imageData = (byte[])reader["image"];

                                Image image;
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    image = Image.FromStream(ms);
                                }

                                pictureBoxImage.Image = image;
                            }
                            else
                            {
                                lblId.Text = "Error";
                                txtItemName.Text = "Error";
                                txtItemDescription.Text = "Error";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the selected image: " + ex.Message);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (IsFieldEmpty(txtItemName) && IsFieldEmpty(txtItemDescription) && IsFieldEmpty(txtPrice) && IsFieldEmpty(txtStock))
            {
                errors += "Please fill out all the fields.\n";
            }
            else
            {
                if (IsFieldEmpty(txtItemName))
                {
                    errors += "Please enter item name.\n";
                }

                if (IsFieldEmpty(txtItemDescription))
                {
                    errors += "Please enter item description.\n";
                }

                if (IsFieldEmpty(txtPrice))
                {
                    errors += "Please enter item price.\n";
                }
                else if (!IsValidPrice(txtPrice))
                {
                    errors += "Please enter a valid price.\n";
                }

                if (IsFieldEmpty(txtStock))
                {
                    errors += "Please enter item stock.\n";
                }
                else if (!IsValidStock(txtStock))
                {
                    errors += "Please enter a valid stock.\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateItem();
        }
        private void UpdateItem()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET item_name = @ItemName, item_description = @ItemDescription, price = @Price, stock = @Stock, image = @ImageData WHERE item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", id);
                    command.Parameters.AddWithValue("@ItemName", $"{txtItemName.Text}");
                    command.Parameters.AddWithValue("@ItemDescription", $"{txtItemDescription.Text}");
                    command.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                    command.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));

                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBoxImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageData = ms.ToArray();
                    }
                    command.Parameters.AddWithValue("@ImageData", imageData);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update item details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating item details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"[Item ID: {id}]\nAre you sure you want to delete this item?", "Item Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    command.Parameters.AddWithValue("@ItemId", id);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"[Item ID: {id}]\nItem deleted successfully.", "Item Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnCancel.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show($"[Item ID: {id}]\nUnable to delete item.", "Item Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error in deleting item: {ex.Message}", "Item Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool IsFieldEmpty(TextBox textBox)
        {
            if (textBox == txtItemName)
            {
                if (textBox.Text.Trim() == "Enter Item Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtItemDescription)
            {
                if (textBox.Text.Trim() == "Enter Item Description" || string.IsNullOrWhiteSpace(textBox.Text))
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
                MessageBox.Show("Please enter item stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                incrementTimer.Stop();
                MessageBox.Show("Please enter a valid stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter item stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsValidStock(txtStock))
            {
                decrementTimer.Stop();
                MessageBox.Show("Please enter a valid stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
