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
        UserControlInventoryManagement inventoryForm;
        /*UserControlUserManagement userForm;*/
        /*UserControlOffersPromotions offersPromotionsForm;*/
        /*UserControlReportsAnalytics reportsAnalyticsForm;*/

        string form;

        public AdminControlForm(string formControl)
        {
            InitializeComponent();

            inventoryForm = new UserControlInventoryManagement();
            /*userForm = new UserControlUserManagement();
            offersPromotionsForm = new UserControlOffersPromotions();
            btnReportsAnalytics = new UserControlReportsAnalytics();*/

            form = formControl;
            lblCurrentControl.Text = formControl.ToUpper();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void NavigateControl(UserControl userControl)
        {
            pnlDisplayControl.Controls.Clear();
            pnlDisplayControl.Controls.Add(userControl);
        }
        private void ResetPanelAndButtonColors()
        {
            btnInventoryManagement.BackColor = Color.FromArgb(76, 175, 80);
            btnUserManagement.BackColor = Color.FromArgb(33, 150, 243);
            btnOffersPromotions.BackColor = Color.FromArgb(255, 152, 0);
            btnReportsAnalytics.BackColor = Color.FromArgb(156, 39, 176);

            tableLayoutPanelInventoryManagement.BackColor = SystemColors.Control;
            tableLayoutPanelUserManagement.BackColor = SystemColors.Control;
            tableLayoutPanelOffersPromotions.BackColor = SystemColors.Control;
            tableLayoutPanelReportsAnalytics.BackColor = SystemColors.Control;
        }

        private void btnInventoryManagement_Click(object sender, EventArgs e)
        {
            NavigateControl(inventoryForm);
            lblCurrentControl.Text = "INVENTORY MANAGEMENT";

            ResetPanelAndButtonColors();
            btnInventoryManagement.BackColor = Color.FromArgb(56, 142, 60);
            tableLayoutPanelInventoryManagement.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            /*NavigateControl(userForm);*/
            lblCurrentControl.Text = "USER MANAGEMENT";

            ResetPanelAndButtonColors();
            btnUserManagement.BackColor = Color.FromArgb(21, 101, 192);
            tableLayoutPanelUserManagement.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnOffersPromotions_Click(object sender, EventArgs e)
        {
            /*NavigateControl(offersPromotionsForm);*/
            lblCurrentControl.Text = "OFFERS && PROMOTIONS";

            ResetPanelAndButtonColors();
            btnOffersPromotions.BackColor = Color.FromArgb(230, 74, 25);
            tableLayoutPanelOffersPromotions.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnReportsAnalytics_Click(object sender, EventArgs e)
        {
            /*NavigateControl(reportsAnalyticsForm);*/
            lblCurrentControl.Text = "REPORTING && ANALYTICS";

            ResetPanelAndButtonColors();
            btnReportsAnalytics.BackColor = Color.FromArgb(106, 27, 154);
            tableLayoutPanelReportsAnalytics.BackColor = Color.FromArgb(255, 255, 192);
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
            else if (form == "Reporting && Analytics")
            {
                btnReportsAnalytics.PerformClick();
            }
        }
    }
}
