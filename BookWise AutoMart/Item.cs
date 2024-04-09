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
    public partial class Item : UserControl
    {

        SqlConnection connectionString = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Laptop Outlet\\OneDrive\\Desktop\\C#\\BookWise-AutoMart\\BookWise AutoMart\\BookWiseAutoMart.mdf\";Integrated Security=True");

        private int item_id;

        public Item(int id)
        {
            InitializeComponent();
            item_id = id;
        }

        private void Item_load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Items WHERE item_id = {item_id}";

            SqlCommand cmd = new SqlCommand(query, connectionString);
            connectionString.Open();
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                data.Read();
                //get data from the Items table
                lblNameItem.Text = data["item_name"].ToString();
                lblPrice.Text = data["price"].ToString();
                //lblDiscount.Text = data["Discount"].ToString() + "%";
                byte[] img = (byte[])(data["image"]);
                if (img != null)
                {
                    using (MemoryStream mstream = new MemoryStream(img))
                    {
                        image.Image = Image.FromStream(mstream);
                    }
                }
                else
                {
                    image.Image = null;
                }

                //get the stock from Items table and check the stock status
                int qty = Convert.ToInt32(data["stock"]);
                if (qty == 0)
                {
                    lblStock.Text = "Out of stock";
                    lblStock.ForeColor = Color.Red;
                }
                else
                {
                    lblStock.Text = "In stock";
                    lblStock.ForeColor = Color.Green;
                }
                connectionString.Close();
            }
        }
    }
}

