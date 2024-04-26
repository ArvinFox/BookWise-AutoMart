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
    public partial class UserControlGuide2 : UserControl
    {
        public UserControlGuide2()
        {
            InitializeComponent();
            this.ParentChanged += UserControlGuide2_ParentChanged;
        }

        private void UserControlGuide2_ParentChanged(object sender, EventArgs e)
        {
            if(this.Parent != null)
            {
                this.Width = this.Parent.ClientSize.Width;
                this.Height = this.Parent.ClientSize.Height;
            }
        }
    }
}
