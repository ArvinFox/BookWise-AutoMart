namespace BookWise_AutoMart
{
    partial class AdminLoginForm
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
            this.tableLayoutPanelAdminCredentials = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnPasswordToggleVisibility = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAdminLoginBtn = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdminLoginTitle = new System.Windows.Forms.Label();
            this.picBoxAdminLogin = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tableLayoutPanelAdminCredentials.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.tableLayoutPanelAdminLoginBtn.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdminLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAdminCredentials
            // 
            this.tableLayoutPanelAdminCredentials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelAdminCredentials.ColumnCount = 2;
            this.tableLayoutPanelAdminCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdminCredentials.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdminCredentials.Controls.Add(this.lblAdminUsername, 0, 0);
            this.tableLayoutPanelAdminCredentials.Controls.Add(this.lblAdminPassword, 0, 1);
            this.tableLayoutPanelAdminCredentials.Controls.Add(this.txtAdminUsername, 1, 0);
            this.tableLayoutPanelAdminCredentials.Controls.Add(this.pnlPassword, 1, 1);
            this.tableLayoutPanelAdminCredentials.Location = new System.Drawing.Point(190, 372);
            this.tableLayoutPanelAdminCredentials.Name = "tableLayoutPanelAdminCredentials";
            this.tableLayoutPanelAdminCredentials.RowCount = 2;
            this.tableLayoutPanelAdminCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdminCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdminCredentials.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAdminCredentials.Size = new System.Drawing.Size(877, 174);
            this.tableLayoutPanelAdminCredentials.TabIndex = 11;
            // 
            // lblAdminUsername
            // 
            this.lblAdminUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdminUsername.AutoSize = true;
            this.lblAdminUsername.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUsername.Location = new System.Drawing.Point(3, 21);
            this.lblAdminUsername.Name = "lblAdminUsername";
            this.lblAdminUsername.Size = new System.Drawing.Size(329, 44);
            this.lblAdminUsername.TabIndex = 0;
            this.lblAdminUsername.Text = "Admin Username:";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(3, 108);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(195, 44);
            this.lblAdminPassword.TabIndex = 2;
            this.lblAdminPassword.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdminUsername.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUsername.Location = new System.Drawing.Point(441, 22);
            this.txtAdminUsername.MaxLength = 100;
            this.txtAdminUsername.Multiline = true;
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(395, 43);
            this.txtAdminUsername.TabIndex = 1;
            this.txtAdminUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminUsername_KeyPress);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.btnPasswordToggleVisibility);
            this.pnlPassword.Controls.Add(this.txtAdminPassword);
            this.pnlPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPassword.Location = new System.Drawing.Point(441, 90);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(433, 81);
            this.pnlPassword.TabIndex = 3;
            // 
            // btnPasswordToggleVisibility
            // 
            this.btnPasswordToggleVisibility.BackColor = System.Drawing.Color.White;
            this.btnPasswordToggleVisibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordToggleVisibility.Enabled = false;
            this.btnPasswordToggleVisibility.FlatAppearance.BorderSize = 0;
            this.btnPasswordToggleVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordToggleVisibility.Image = global::BookWise_AutoMart.Properties.Resources.hide;
            this.btnPasswordToggleVisibility.Location = new System.Drawing.Point(343, 22);
            this.btnPasswordToggleVisibility.Name = "btnPasswordToggleVisibility";
            this.btnPasswordToggleVisibility.Size = new System.Drawing.Size(54, 33);
            this.btnPasswordToggleVisibility.TabIndex = 17;
            this.btnPasswordToggleVisibility.TabStop = false;
            this.btnPasswordToggleVisibility.UseVisualStyleBackColor = false;
            this.btnPasswordToggleVisibility.Visible = false;
            this.btnPasswordToggleVisibility.Click += new System.EventHandler(this.btnPasswordToggleVisibility_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdminPassword.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.Location = new System.Drawing.Point(0, 18);
            this.txtAdminPassword.MaxLength = 20;
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(398, 44);
            this.txtAdminPassword.TabIndex = 3;
            this.txtAdminPassword.TextChanged += new System.EventHandler(this.txtAdminPassword_TextChanged);
            this.txtAdminPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdminPassword_KeyPress);
            // 
            // tableLayoutPanelAdminLoginBtn
            // 
            this.tableLayoutPanelAdminLoginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelAdminLoginBtn.ColumnCount = 1;
            this.tableLayoutPanelAdminLoginBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdminLoginBtn.Controls.Add(this.btnAdminLogin, 0, 0);
            this.tableLayoutPanelAdminLoginBtn.Location = new System.Drawing.Point(190, 565);
            this.tableLayoutPanelAdminLoginBtn.Name = "tableLayoutPanelAdminLoginBtn";
            this.tableLayoutPanelAdminLoginBtn.RowCount = 1;
            this.tableLayoutPanelAdminLoginBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAdminLoginBtn.Size = new System.Drawing.Size(876, 105);
            this.tableLayoutPanelAdminLoginBtn.TabIndex = 12;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdminLogin.BackColor = System.Drawing.Color.White;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(354, 18);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(168, 69);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.White;
            this.pnlAdmin.Controls.Add(this.lblAdminLoginTitle);
            this.pnlAdmin.Controls.Add(this.picBoxAdminLogin);
            this.pnlAdmin.Controls.Add(this.btnMinimize);
            this.pnlAdmin.Controls.Add(this.btnMaximize);
            this.pnlAdmin.Controls.Add(this.btnClose);
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1280, 40);
            this.pnlAdmin.TabIndex = 13;
            // 
            // lblAdminLoginTitle
            // 
            this.lblAdminLoginTitle.AutoSize = true;
            this.lblAdminLoginTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLoginTitle.Location = new System.Drawing.Point(43, 11);
            this.lblAdminLoginTitle.Name = "lblAdminLoginTitle";
            this.lblAdminLoginTitle.Size = new System.Drawing.Size(122, 24);
            this.lblAdminLoginTitle.TabIndex = 4;
            this.lblAdminLoginTitle.Text = "Admin Login";
            // 
            // picBoxAdminLogin
            // 
            this.picBoxAdminLogin.Image = global::BookWise_AutoMart.Properties.Resources.admin_avatar__20px_;
            this.picBoxAdminLogin.Location = new System.Drawing.Point(10, 8);
            this.picBoxAdminLogin.Name = "picBoxAdminLogin";
            this.picBoxAdminLogin.Size = new System.Drawing.Size(25, 25);
            this.picBoxAdminLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdminLogin.TabIndex = 3;
            this.picBoxAdminLogin.TabStop = false;
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
            // AdminLoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.tableLayoutPanelAdminCredentials);
            this.Controls.Add(this.tableLayoutPanelAdminLoginBtn);
            this.Controls.Add(this.pnlAdmin);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.tableLayoutPanelAdminCredentials.ResumeLayout(false);
            this.tableLayoutPanelAdminCredentials.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.tableLayoutPanelAdminLoginBtn.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdminLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdminCredentials;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnPasswordToggleVisibility;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdminLoginBtn;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblAdminLoginTitle;
        private System.Windows.Forms.PictureBox picBoxAdminLogin;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
    }
}