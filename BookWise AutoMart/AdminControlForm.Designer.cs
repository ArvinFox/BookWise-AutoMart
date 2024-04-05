namespace BookWise_AutoMart
{
    partial class AdminControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdminControlTitle = new System.Windows.Forms.Label();
            this.picBoxAdminControl = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanelAdminNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInventoryManagement = new System.Windows.Forms.TableLayoutPanel();
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.tableLayoutPanelUserManagement = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelOffersPromotions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelReportsAnalytics = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnOffersPromotions = new System.Windows.Forms.Button();
            this.btnReportsAnalytics = new System.Windows.Forms.Button();
            this.tableLayoutPanelCurrentControl = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentControl = new System.Windows.Forms.Label();
            this.pnlDisplayControl = new System.Windows.Forms.Panel();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdminControl)).BeginInit();
            this.tableLayoutPanelAdminNavigation.SuspendLayout();
            this.tableLayoutPanelInventoryManagement.SuspendLayout();
            this.tableLayoutPanelUserManagement.SuspendLayout();
            this.tableLayoutPanelOffersPromotions.SuspendLayout();
            this.tableLayoutPanelReportsAnalytics.SuspendLayout();
            this.tableLayoutPanelCurrentControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.lblAdminControlTitle);
            this.pnlAdmin.Controls.Add(this.picBoxAdminControl);
            this.pnlAdmin.Controls.Add(this.btnMinimize);
            this.pnlAdmin.Controls.Add(this.btnMaximize);
            this.pnlAdmin.Controls.Add(this.btnClose);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1280, 40);
            this.pnlAdmin.TabIndex = 14;
            // 
            // lblAdminControlTitle
            // 
            this.lblAdminControlTitle.AutoSize = true;
            this.lblAdminControlTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControlTitle.Location = new System.Drawing.Point(43, 12);
            this.lblAdminControlTitle.Name = "lblAdminControlTitle";
            this.lblAdminControlTitle.Size = new System.Drawing.Size(139, 24);
            this.lblAdminControlTitle.TabIndex = 4;
            this.lblAdminControlTitle.Text = "Admin Control";
            // 
            // picBoxAdminControl
            // 
            this.picBoxAdminControl.Image = global::BookWise_AutoMart.Properties.Resources.admin_control__20px_;
            this.picBoxAdminControl.Location = new System.Drawing.Point(10, 8);
            this.picBoxAdminControl.Name = "picBoxAdminControl";
            this.picBoxAdminControl.Size = new System.Drawing.Size(25, 25);
            this.picBoxAdminControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdminControl.TabIndex = 3;
            this.picBoxAdminControl.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::BookWise_AutoMart.Properties.Resources.minimize__20px_;
            this.btnMinimize.Location = new System.Drawing.Point(1115, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(55, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::BookWise_AutoMart.Properties.Resources.maximize__20px_;
            this.btnMaximize.Location = new System.Drawing.Point(1170, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(55, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::BookWise_AutoMart.Properties.Resources.close__20px_;
            this.btnClose.Location = new System.Drawing.Point(1225, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tableLayoutPanelAdminNavigation
            // 
            this.tableLayoutPanelAdminNavigation.ColumnCount = 4;
            this.tableLayoutPanelAdminNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAdminNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAdminNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAdminNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelAdminNavigation.Controls.Add(this.tableLayoutPanelReportsAnalytics, 3, 0);
            this.tableLayoutPanelAdminNavigation.Controls.Add(this.tableLayoutPanelOffersPromotions, 2, 0);
            this.tableLayoutPanelAdminNavigation.Controls.Add(this.tableLayoutPanelUserManagement, 1, 0);
            this.tableLayoutPanelAdminNavigation.Controls.Add(this.tableLayoutPanelInventoryManagement, 0, 0);
            this.tableLayoutPanelAdminNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelAdminNavigation.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanelAdminNavigation.Name = "tableLayoutPanelAdminNavigation";
            this.tableLayoutPanelAdminNavigation.RowCount = 1;
            this.tableLayoutPanelAdminNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAdminNavigation.Size = new System.Drawing.Size(1280, 180);
            this.tableLayoutPanelAdminNavigation.TabIndex = 15;
            // 
            // tableLayoutPanelInventoryManagement
            // 
            this.tableLayoutPanelInventoryManagement.ColumnCount = 1;
            this.tableLayoutPanelInventoryManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInventoryManagement.Controls.Add(this.btnInventoryManagement, 0, 0);
            this.tableLayoutPanelInventoryManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInventoryManagement.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelInventoryManagement.Name = "tableLayoutPanelInventoryManagement";
            this.tableLayoutPanelInventoryManagement.RowCount = 1;
            this.tableLayoutPanelInventoryManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInventoryManagement.Size = new System.Drawing.Size(314, 174);
            this.tableLayoutPanelInventoryManagement.TabIndex = 0;
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventoryManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnInventoryManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventoryManagement.FlatAppearance.BorderSize = 0;
            this.btnInventoryManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnInventoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryManagement.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryManagement.ForeColor = System.Drawing.Color.White;
            this.btnInventoryManagement.Location = new System.Drawing.Point(57, 43);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(199, 87);
            this.btnInventoryManagement.TabIndex = 7;
            this.btnInventoryManagement.TabStop = false;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = false;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // tableLayoutPanelUserManagement
            // 
            this.tableLayoutPanelUserManagement.ColumnCount = 1;
            this.tableLayoutPanelUserManagement.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserManagement.Controls.Add(this.btnUserManagement, 0, 0);
            this.tableLayoutPanelUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserManagement.Location = new System.Drawing.Point(323, 3);
            this.tableLayoutPanelUserManagement.Name = "tableLayoutPanelUserManagement";
            this.tableLayoutPanelUserManagement.RowCount = 1;
            this.tableLayoutPanelUserManagement.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUserManagement.Size = new System.Drawing.Size(314, 174);
            this.tableLayoutPanelUserManagement.TabIndex = 1;
            // 
            // tableLayoutPanelOffersPromotions
            // 
            this.tableLayoutPanelOffersPromotions.ColumnCount = 1;
            this.tableLayoutPanelOffersPromotions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOffersPromotions.Controls.Add(this.btnOffersPromotions, 0, 0);
            this.tableLayoutPanelOffersPromotions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOffersPromotions.Location = new System.Drawing.Point(643, 3);
            this.tableLayoutPanelOffersPromotions.Name = "tableLayoutPanelOffersPromotions";
            this.tableLayoutPanelOffersPromotions.RowCount = 1;
            this.tableLayoutPanelOffersPromotions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOffersPromotions.Size = new System.Drawing.Size(314, 174);
            this.tableLayoutPanelOffersPromotions.TabIndex = 2;
            // 
            // tableLayoutPanelReportsAnalytics
            // 
            this.tableLayoutPanelReportsAnalytics.ColumnCount = 1;
            this.tableLayoutPanelReportsAnalytics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReportsAnalytics.Controls.Add(this.btnReportsAnalytics, 0, 0);
            this.tableLayoutPanelReportsAnalytics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReportsAnalytics.Location = new System.Drawing.Point(963, 3);
            this.tableLayoutPanelReportsAnalytics.Name = "tableLayoutPanelReportsAnalytics";
            this.tableLayoutPanelReportsAnalytics.RowCount = 1;
            this.tableLayoutPanelReportsAnalytics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReportsAnalytics.Size = new System.Drawing.Size(314, 174);
            this.tableLayoutPanelReportsAnalytics.TabIndex = 3;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(57, 43);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(199, 87);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.TabStop = false;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnOffersPromotions
            // 
            this.btnOffersPromotions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOffersPromotions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnOffersPromotions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOffersPromotions.FlatAppearance.BorderSize = 0;
            this.btnOffersPromotions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(25)))));
            this.btnOffersPromotions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOffersPromotions.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOffersPromotions.ForeColor = System.Drawing.Color.White;
            this.btnOffersPromotions.Location = new System.Drawing.Point(57, 43);
            this.btnOffersPromotions.Name = "btnOffersPromotions";
            this.btnOffersPromotions.Size = new System.Drawing.Size(199, 87);
            this.btnOffersPromotions.TabIndex = 7;
            this.btnOffersPromotions.TabStop = false;
            this.btnOffersPromotions.Text = "Offers && Promotions";
            this.btnOffersPromotions.UseVisualStyleBackColor = false;
            this.btnOffersPromotions.Click += new System.EventHandler(this.btnOffersPromotions_Click);
            // 
            // btnReportsAnalytics
            // 
            this.btnReportsAnalytics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReportsAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnReportsAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportsAnalytics.FlatAppearance.BorderSize = 0;
            this.btnReportsAnalytics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(27)))), ((int)(((byte)(154)))));
            this.btnReportsAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportsAnalytics.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportsAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnReportsAnalytics.Location = new System.Drawing.Point(57, 43);
            this.btnReportsAnalytics.Name = "btnReportsAnalytics";
            this.btnReportsAnalytics.Size = new System.Drawing.Size(199, 87);
            this.btnReportsAnalytics.TabIndex = 7;
            this.btnReportsAnalytics.TabStop = false;
            this.btnReportsAnalytics.Text = "Reporting && Analytics";
            this.btnReportsAnalytics.UseVisualStyleBackColor = false;
            this.btnReportsAnalytics.Click += new System.EventHandler(this.btnReportsAnalytics_Click);
            // 
            // tableLayoutPanelCurrentControl
            // 
            this.tableLayoutPanelCurrentControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanelCurrentControl.ColumnCount = 1;
            this.tableLayoutPanelCurrentControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentControl.Controls.Add(this.lblCurrentControl, 0, 0);
            this.tableLayoutPanelCurrentControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelCurrentControl.Location = new System.Drawing.Point(0, 220);
            this.tableLayoutPanelCurrentControl.Name = "tableLayoutPanelCurrentControl";
            this.tableLayoutPanelCurrentControl.RowCount = 1;
            this.tableLayoutPanelCurrentControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCurrentControl.Size = new System.Drawing.Size(1280, 50);
            this.tableLayoutPanelCurrentControl.TabIndex = 16;
            // 
            // lblCurrentControl
            // 
            this.lblCurrentControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentControl.AutoSize = true;
            this.lblCurrentControl.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentControl.ForeColor = System.Drawing.Color.White;
            this.lblCurrentControl.Location = new System.Drawing.Point(477, 3);
            this.lblCurrentControl.Name = "lblCurrentControl";
            this.lblCurrentControl.Size = new System.Drawing.Size(326, 44);
            this.lblCurrentControl.TabIndex = 0;
            this.lblCurrentControl.Text = "@Current Control";
            // 
            // pnlDisplayControl
            // 
            this.pnlDisplayControl.AutoSize = true;
            this.pnlDisplayControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayControl.Location = new System.Drawing.Point(0, 270);
            this.pnlDisplayControl.Name = "pnlDisplayControl";
            this.pnlDisplayControl.Size = new System.Drawing.Size(1280, 754);
            this.pnlDisplayControl.TabIndex = 17;
            // 
            // AdminControlForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.pnlDisplayControl);
            this.Controls.Add(this.tableLayoutPanelCurrentControl);
            this.Controls.Add(this.tableLayoutPanelAdminNavigation);
            this.Controls.Add(this.pnlAdmin);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "AdminControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminControlForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminControlForm_Load);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdminControl)).EndInit();
            this.tableLayoutPanelAdminNavigation.ResumeLayout(false);
            this.tableLayoutPanelInventoryManagement.ResumeLayout(false);
            this.tableLayoutPanelUserManagement.ResumeLayout(false);
            this.tableLayoutPanelOffersPromotions.ResumeLayout(false);
            this.tableLayoutPanelReportsAnalytics.ResumeLayout(false);
            this.tableLayoutPanelCurrentControl.ResumeLayout(false);
            this.tableLayoutPanelCurrentControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblAdminControlTitle;
        private System.Windows.Forms.PictureBox picBoxAdminControl;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdminNavigation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReportsAnalytics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOffersPromotions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInventoryManagement;
        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnReportsAnalytics;
        private System.Windows.Forms.Button btnOffersPromotions;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCurrentControl;
        private System.Windows.Forms.Label lblCurrentControl;
        private System.Windows.Forms.Panel pnlDisplayControl;
    }
}