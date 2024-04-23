using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWise_AutoMart
{
    public class DatabaseString
    {
        public static string GetUserDatabase()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\arvin\OneDrive\Desktop\BookWise-AutoMart\BookWise AutoMart\BookWiseAutoMart.mdf"";Integrated Security=True";
        }
        public static string GetAdminDatabase()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\arvin\OneDrive\Desktop\BookWise-AutoMart\BookWise AutoMart\Admin_BookWiseAutoMart.mdf"";Integrated Security=True";
        }
    }
}
