using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BookWise_AutoMart
{
    public class DisplayUserDetails : Panel
    {
        public DisplayUserDetails() 
        { 
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();

            tableLayoutPanel.ColumnCount = 6;
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.520564F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.17234F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.43764F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.44653F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.43478F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142F));
            tableLayoutPanel.Dock = DockStyle.Top;

            Label lblUserID = new Label();
            lblUserID.Text = "User ID";
            lblUserID.Anchor = AnchorStyles.None;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel.Controls.Add(lblUserID, 0, 0);

            Label lblUserType = new Label();
            lblUserType.Text = "User Type";
            lblUserType.Anchor = AnchorStyles.None;
            lblUserType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel.Controls.Add(lblUserType, 1, 0);

            Label lblUserName = new Label();
            lblUserName.Text = "User Name";
            lblUserName.Anchor = AnchorStyles.None;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel.Controls.Add(lblUserName, 2, 0);

            Label lblUserContact = new Label();
            lblUserContact.Text = "User Contact";
            lblUserContact.Anchor = AnchorStyles.None;
            lblUserContact.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel.Controls.Add(lblUserContact, 3, 0);

            Label lblUserEmail = new Label();
            lblUserEmail.Text = "User Email";
            lblUserEmail.Anchor = AnchorStyles.None;
            lblUserEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tableLayoutPanel.Controls.Add(lblUserEmail, 4, 0);

            this.Controls.Add(tableLayoutPanel);
        }
    }
}