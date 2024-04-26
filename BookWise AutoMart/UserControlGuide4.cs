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
    public partial class UserControlGuide4 : UserControl
    {
        public UserControlGuide4()
        {
            InitializeComponent();
            this.ParentChanged += UserControlGuide4_ParentChanged;
        }

        private void UserControlGuide4_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }
    }
}
