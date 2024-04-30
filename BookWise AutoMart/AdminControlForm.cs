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
    public partial class AdminControlForm : Form
    {
        // used to refresh the form
        public static Button btnReloadInventoryManagementForm;
        public static Button btnReloadUserManagementForm;
        public static Button btnReloadOffersPromotionsForm;

        private UserControl currentlyDisplayedControl;  // current instance of UserControl
        string form;

        public AdminControlForm(string formControl)
        {
            InitializeComponent();

            btnReloadInventoryManagementForm = btnInventoryManagement;
            btnReloadUserManagementForm = btnUserManagement;
            btnReloadOffersPromotionsForm = btnOffersPromotions;

            form = formControl;
            lblCurrentControl.Text = formControl.ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool userLoginFound = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form is UserLogin)
                {
                    userLoginFound = true;
                    form.Show();
                    break;
                }
            }
            if (!userLoginFound)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Show();
            }

            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NavigateControl(UserControl userControl)
        {
            // Dispose of the currently displayed control, if it exists
            if (currentlyDisplayedControl != null)
            {
                currentlyDisplayedControl.Dispose();    // Dispose (close) exisiting UserControl instance
                currentlyDisplayedControl = null;
            }

            pnlDisplayControl.Controls.Clear();
            pnlDisplayControl.Controls.Add(userControl);
            currentlyDisplayedControl = userControl;
        }
        private void ResetPanelAndButtonColors()
        {
            btnInventoryManagement.BackColor = Color.FromArgb(76, 175, 80);
            btnUserManagement.BackColor = Color.FromArgb(33, 150, 243);
            btnOffersPromotions.BackColor = Color.FromArgb(255, 152, 0);

            tableLayoutPanelInventoryManagement.BackColor = SystemColors.Control;
            tableLayoutPanelUserManagement.BackColor = SystemColors.Control;
            tableLayoutPanelOffersPromotions.BackColor = SystemColors.Control;
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            NavigateControl(new UserControlInventoryManagement());
            lblCurrentControl.Text = "INVENTORY MANAGEMENT";

            ResetPanelAndButtonColors();
            btnInventoryManagement.BackColor = Color.FromArgb(56, 142, 60);
            tableLayoutPanelInventoryManagement.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            NavigateControl(new UserControlUserManagement());
            lblCurrentControl.Text = "USER MANAGEMENT";

            ResetPanelAndButtonColors();   
            btnUserManagement.BackColor = Color.FromArgb(21, 101, 192);
            tableLayoutPanelUserManagement.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnOffersPromotions_Click(object sender, EventArgs e)
        {
            NavigateControl(new UserControlOffersPromotions());
            lblCurrentControl.Text = "OFFERS && PROMOTIONS";

            ResetPanelAndButtonColors();
            btnOffersPromotions.BackColor = Color.FromArgb(230, 74, 25);
            tableLayoutPanelOffersPromotions.BackColor = Color.FromArgb(255, 255, 192);
        }
        
        private void AdminControlForm_Load(object sender, EventArgs e)
        {
            if (form == "Inventory Management")
            {
                btnInventoryManagement.PerformClick();
            }
            else if (form == "User Management")
            {
                btnUserManagement.PerformClick();
            }
            else if (form == "Offers && Promotions")
            {
                btnOffersPromotions.PerformClick();
            }
        }
    }
}
