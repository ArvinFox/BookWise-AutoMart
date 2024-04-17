using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            // Subscribe to the ParentChanged event to update the size when the parent changes
            this.ParentChanged += UserControlUserManagement_ParentChanged;
        }

        private void UserControlUserManagement_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                // To take the entire screen size
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }
    }
}
