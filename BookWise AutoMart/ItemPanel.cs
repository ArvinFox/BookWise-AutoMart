using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BookWise_AutoMart
{
    public partial class ItemPanel : Panel
    {
        private string connectionString = DatabaseString.GetUserDatabase();

        // Import the HideCaret function (to hide the cursor in the custom text box)
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public ItemPanel(string itemName, string itemDescription, decimal price, Image image, int discount)
        {
            int tempStock = GetTempStock(itemName);

            // TableLayoutPanel to align everything 
            TableLayoutPanel tableLayoutItemPanel = new TableLayoutPanel();
            tableLayoutItemPanel.Dock = DockStyle.Fill;
            tableLayoutItemPanel.ColumnCount = 1;
            tableLayoutItemPanel.RowCount = 2;
            tableLayoutItemPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40));
            tableLayoutItemPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60));
            tableLayoutItemPanel.AutoSize = true;

            // PictureBox for image
            PictureBox picBoxItemImage = new PictureBox();
            picBoxItemImage.Anchor = AnchorStyles.None;
            picBoxItemImage.Image = image;
            picBoxItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxItemImage.Size = new Size(150, 200);
            tableLayoutItemPanel.Controls.Add(picBoxItemImage, 0, 0);// First column, first row

            // Panel to store item details
            Panel panelItemDetails = new Panel();
            panelItemDetails.Dock = DockStyle.Fill;
            panelItemDetails.AutoSize = true;

            // Textbox for Item Name
            TextBox txtItemName = CreateTextBox(itemName, new Font("Segoe UI", 14, FontStyle.Bold), true);

            // Textbox for Discription
            TextBox txtItemDescription = CreateTextBox(itemDescription, new Font("Segoe UI", 12), true);

            // Textbox for Item Price
            TextBox txtItemPrice = CreateTextBox("Rs. " + price.ToString(), new Font("Segoe UI", 12), false);

            // Textbox for Item Stock
            TextBox txtItemStock = CreateTextBox("Stock: " + tempStock.ToString(), new Font("Segoe UI", 12, FontStyle.Bold), false);

            //check stock status
            UpdateStockStatus(txtItemStock, GetTempStock(itemName));

            //Textbox to display discounts
            TextBox txtDiscount = new TextBox();
            txtDiscount.Height = 20;
            txtDiscount.Width = 60;
            txtDiscount.TextAlign = HorizontalAlignment.Center;
            txtDiscount.BorderStyle = BorderStyle.None;
            txtDiscount.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            txtDiscount.Dock = DockStyle.Right;
            txtDiscount.ReadOnly = true;
            txtDiscount.GotFocus += (sender, e) =>
            {
                HideCaret(((TextBox)sender).Handle);
            };
            this.Controls.Add(txtDiscount);

            //Check the item discount status 
            if (discount > 0)
            {
                txtDiscount.ForeColor = Color.White;
                txtDiscount.BackColor = Color.Red;
                txtDiscount.Text = discount.ToString() + "%";
            }
            else
            {
                txtDiscount.Visible = false;
            }

            //Panel to store Add Remove buttons with qty textbox
            Panel panelButtons = new Panel();
            panelButtons.AutoSize = true;
            panelButtons.Dock = DockStyle.Top;

            //table layout panel to store add remove buttons
            TableLayoutPanel tlpButtons = new TableLayoutPanel();
            tlpButtons.AutoSize = false;
            tlpButtons.ColumnCount = 3;
            tlpButtons.RowCount = 1;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            tlpButtons.Width = 176;
            tlpButtons.Height = 45;
            tlpButtons.Dock = DockStyle.Top;

            //Add a textbox to enter quantity
            TextBox txtQty = new TextBox();
            txtQty.Text = "0";
            txtQty.Width = 52;
            txtQty.Height = 35;
            txtQty.MaxLength = 2;
            txtQty.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            tlpButtons.Controls.Add(txtQty, 1, 0);
            txtQty.TextAlign = HorizontalAlignment.Center;
            txtQty.Anchor = AnchorStyles.None;
            txtQty.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            };
            txtQty.TextChanged += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtQty.Text.Trim()))
                {
                    txtQty.Text = "0";
                }
            };

            //create a button for Remove
            Button butRemove = new Button();
            butRemove.Text = " - ";
            butRemove.Width = 52;
            butRemove.Height = 30;
            butRemove.BackColor = Color.Red;
            butRemove.ForeColor = Color.White;
            tlpButtons.Controls.Add(butRemove, 0, 0);
            butRemove.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            butRemove.TextAlign = ContentAlignment.MiddleCenter;
            butRemove.FlatStyle = FlatStyle.Flat;
            butRemove.FlatAppearance.BorderSize = 0;
            butRemove.Anchor = AnchorStyles.None;
            butRemove.Click += (sender, e) =>
            {
                foreach (char c in txtQty.Text.Trim())
                {
                    if (!char.IsDigit(c))
                    {
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(txtQty.Text.Trim()))
                {
                    return;
                }
                int qty = Convert.ToInt32(txtQty.Text);
                if (qty <= 0)
                {
                    txtQty.Text = "0";
                    return;
                }
                qty--;
                txtQty.Text = qty.ToString();
            };

            //create a button for add
            Button butAdd = new Button();
            butAdd.Text = " + ";
            butAdd.Width = 52;
            butAdd.Height = 30;
            butAdd.BackColor = Color.Green;
            butAdd.ForeColor = Color.White;
            tlpButtons.Controls.Add(butAdd, 2, 0);
            butAdd.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            butAdd.TextAlign = ContentAlignment.MiddleCenter;
            butAdd.FlatStyle = FlatStyle.Flat;
            butAdd.FlatAppearance.BorderSize = 0;
            butAdd.Anchor = AnchorStyles.None;
            butAdd.Click += (sender, e) =>
            {
                foreach (char c in txtQty.Text.Trim())
                {
                    if (!char.IsDigit(c))
                    {
                        return;
                    }
                }

                if (string.IsNullOrWhiteSpace(txtQty.Text.Trim()))
                {
                    return;
                }
                int qty = Convert.ToInt32(txtQty.Text);
                if (qty >= 99)
                {
                    return;
                }
                qty++;
                txtQty.Text = qty.ToString();
            };

            //Add tablelayout panel to panel
            panelButtons.Controls.Add(tlpButtons);

            // "Add to Cart" Button
            Button btnBuyItem = new Button();
            btnBuyItem.Text = "Add to Cart";
            btnBuyItem.FlatStyle = FlatStyle.Flat;
            btnBuyItem.FlatAppearance.BorderSize = 0;
            btnBuyItem.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            btnBuyItem.BackColor = Color.Orange;
            btnBuyItem.ForeColor = Color.Black;
            btnBuyItem.TabStop = false;
            btnBuyItem.Dock = DockStyle.Top;
            btnBuyItem.Height = 40;
            btnBuyItem.Cursor = Cursors.Hand;
            btnBuyItem.Click += (sender, e) =>
            {
                tempStock = GetTempStock(itemName);
                int qty= Convert.ToInt32((txtQty.Text.Trim()));
                //To Prevent adding "0" items to the cart
                if (qty <= 0)
                {
                    txtQty.Text = "0";
                    return;
                }
                //To display a message when the quantity that enter will exceed the current stock
                if (qty > tempStock)
                {
                    OutOfStockForm outOfStockForm = new OutOfStockForm(tempStock, txtQty);
                    outOfStockForm.ShowDialog();
                }
                else
                {
                    if(!ItemExists(itemName,qty))
                    {
                        //Add items to the cart
                        AddToCart(qty, itemName, price,txtItemStock,tempStock);
                        UpdateTempStock(itemName,-qty,GetTempStock(itemName));
                        UserPanel.checkoutForm.AddToBill(qty,itemName,price);
                    }
                    UpdateStockStatus(txtItemStock, GetTempStock(itemName));
                    //Update Total
                    UpdateTotal();
                }
            };

            // Add labels and "Add to Cart" button to details panel
            panelItemDetails.Controls.Add(btnBuyItem);
            panelItemDetails.Controls.Add(panelButtons);
            panelItemDetails.Controls.Add(txtItemStock);
            panelItemDetails.Controls.Add(txtItemPrice);
            panelItemDetails.Controls.Add(txtItemDescription);
            panelItemDetails.Controls.Add(txtItemName);

            // Add details panel to table layout panel
            tableLayoutItemPanel.Controls.Add(panelItemDetails, 0, 1); //(0,1) - first column second row

            // Add table layout panel to DisplayItemsPanel
            this.Controls.Add(tableLayoutItemPanel);
            this.MinimumSize = new Size(200, 50);
            this.Margin = new Padding(20, 20, 0, 0); // Set left margin
            this.BackColor = Color.White;
            this.AutoSize = true;
        }

        // Method to create and configure text boxes
        private TextBox CreateTextBox(string text, Font font, bool adjustHeightForMultipleLines)
        {
            TextBox textBox = new TextBox();
            textBox.Text = text;
            textBox.Font = font;
            textBox.Multiline = true;
            textBox.WordWrap = true;
            textBox.ReadOnly = true;
            textBox.BackColor = Color.White;
            textBox.Dock = DockStyle.Top;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.BorderStyle = BorderStyle.None;
            //To hide the cursor in the textbox
            textBox.GotFocus += (sender, e) =>
            {
                HideCaret(((TextBox)sender).Handle);
            };

            // Calculate the height based on the text content
            int lineHeight = TextRenderer.MeasureText("A", font).Height;
            int lines = textBox.Lines.Length;

            if (adjustHeightForMultipleLines && lines > 0)
                lines += 2; // Add 2 to the lines count for ItemName and ItemDescription

            int newHeight = lineHeight * lines;
            textBox.Height = Math.Max(newHeight, 35); // Set minimum height

            return textBox;
        }

        private void UpdateTempStock(string Name,int quantity,int tempStock)
        {
            if(quantity > 0)
            {
                foreach (Control control in UserPanel.pnl.Controls)
                {
                    if (control is TableLayoutPanel tblItem)
                    {
                        if (tblItem.Controls[0] is Label lblQty)
                        {
                            quantity = Convert.ToInt32(lblQty.Text);
                        }
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Items SET temporary_stock = @tempStock WHERE item_name = @itemName";

                using(SqlCommand cmd = new SqlCommand(query,connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@tempStock",tempStock + quantity );
                        cmd.Parameters.AddWithValue("@itemName", Name);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        //---------------
                    }
                }
            }
        }

        private int GetTempStock(string itemName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT temporary_stock FROM Items WHERE item_name = @itemName ";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@itemName", itemName);

                        connection.Open();
                        object result = cmd.ExecuteScalar();

                        if(result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                    catch (Exception)
                    {
                        //---------------
                    }
                }
            }
            return -1;
        }

        private void UpdateStockStatus(TextBox text,int stock)
        {
            if (stock == 0)
            {
                text.Text = "Out of stock";
                text.ForeColor = Color.Red;
            }
            else
            {
                text.Text = "In stock";
                text.ForeColor = Color.Green;
            }
        }

        public void AddToCart(int qty,string itemName, decimal price,TextBox text,int tempStock)
        {
            TableLayoutPanel tblCartItem = new TableLayoutPanel();

            tblCartItem.ColumnCount = 5;
            tblCartItem.RowCount = 1;
            tblCartItem.Width = this.Width;
            tblCartItem.Height = 55;
            tblCartItem.BackColor = Color.White;
            tblCartItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.17F));
            tblCartItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.29F));
            tblCartItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.09F));
            tblCartItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.59F));
            tblCartItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.86F));
            tblCartItem.Dock = DockStyle.Top;

            Label lblQty = new Label();
            lblQty.Text = qty.ToString();
            lblQty.Dock = DockStyle.Fill;
            lblQty.TextAlign = ContentAlignment.MiddleCenter;
            lblQty.Font = new Font("Segoe UI", 10);
            tblCartItem.Controls.Add(lblQty, 0, 0);

            Label lblItemName = new Label();
            lblItemName.Text = itemName;
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            lblItemName.Font = new Font("Segoe UI", 8);
            tblCartItem.Controls.Add(lblItemName, 1, 0);

            Label lblUnitPrice = new Label();
            lblUnitPrice.Text = price.ToString();
            lblUnitPrice.Dock = DockStyle.Fill;
            lblUnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblUnitPrice.Font = new Font("Segoe UI", 10);
            tblCartItem.Controls.Add(lblUnitPrice, 2, 0);

            Label lblAmount = new Label();
            lblAmount.Text = (price * qty).ToString();
            lblAmount.Dock = DockStyle.Fill;
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            lblAmount.Font = new Font("Segoe UI", 10);
            tblCartItem.Controls.Add(lblAmount, 3, 0);

            PictureBox picDeleteItem = new PictureBox();
            picDeleteItem.SizeMode = PictureBoxSizeMode.Zoom;
            picDeleteItem.Cursor = Cursors.Hand;
            picDeleteItem.Size = new Size(20,20);
            picDeleteItem.Image = Properties.Resources.delete__blue_;
            picDeleteItem.Dock = DockStyle.Fill;
            tblCartItem.Controls.Add(picDeleteItem, 4, 0);
            picDeleteItem.Click += (sender, e) =>
            {
                UpdateTempStock(itemName, qty, GetTempStock(itemName));
                UpdateStockStatus(text, GetTempStock(itemName));
                UserPanel.pnl.Controls.Remove(tblCartItem);
                UserPanel.checkoutForm.DeleteItem(itemName);
                UpdateTotal();
            };

            UserPanel.pnl.Controls.Add(tblCartItem);
        }

        private bool ItemExists(string itemName,int quantity)
        {
            foreach (Control control in UserPanel.pnl.Controls)
            {
                if (control is TableLayoutPanel tblItem)
                {
                    if (tblItem.Controls[1] is Label lblItemName)
                    {
                        if(lblItemName.Text.Trim() == itemName.Trim())
                        {
                            if(tblItem.Controls[0] is Label lblQty)
                            {
                                int currentQty = Convert.ToInt32(lblQty.Text);
                                lblQty.Text = (currentQty + quantity).ToString();

                                if(tblItem.Controls[3] is Label lblAmount)
                                {
                                    decimal price = Convert.ToDecimal(lblAmount.Text);
                                    lblAmount.Text = (price * Convert.ToDecimal(lblQty.Text)).ToString();
                                }
                            }
                            UserPanel.checkoutForm.UpdateQuantity(itemName, quantity);
                            return true;
                        }
                    }
                }
            }
            return false;
        }



        private void UpdateTotal()
        {
            decimal sum = 0;

            //To display the total amount
            foreach (Control control in UserPanel.pnl.Controls)
            {
                if(control is TableLayoutPanel tblSum)
                {
                    if(tblSum.Controls[3] is Label lblAmount)
                    {
                        sum += Convert.ToDecimal(lblAmount.Text);
                    }
                }
            }
            UserPanel.total.Text = sum.ToString();
        }
    }
}

