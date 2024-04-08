using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise_AutoMart
{
    public class CategoriesButton : Button
    {
        private static CategoriesButton currentlyClickedButton = null;

        public CategoriesButton(string category)
        {
            this.Text = category;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Blue;
            this.Dock = DockStyle.Top;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Gadugi", 15, FontStyle.Bold);
            this.Height = 60;
            this.Cursor = Cursors.Hand;
            this.TabStop = true;

            this.MouseEnter += (sender, e) =>
            {
                if (this != currentlyClickedButton)
                {
                    this.BackColor = Color.Blue;
                    this.ForeColor = Color.White;
                }
            };

            this.MouseLeave += (sender, e) =>
            {
                if (this != currentlyClickedButton)
                {
                    this.BackColor = Color.Transparent;
                    this.ForeColor = Color.Blue;
                }
            };

            this.Click += (sender, e) =>
            {
                if (currentlyClickedButton != null)
                {
                    currentlyClickedButton.BackColor = Color.Transparent;
                    currentlyClickedButton.ForeColor = Color.Blue;
                }

                currentlyClickedButton = this;
                this.BackColor = Color.DodgerBlue;
                this.ForeColor = Color.White;
            };
        }
    }
}
