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
    public partial class UserControlGuide3 : UserControl
    {
        public UserControlGuide3()
        {
            InitializeComponent();
            this.ParentChanged += UserControlGuide3_ParentChanged;
        }

        private void UserControlGuide3_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }
    }
}
