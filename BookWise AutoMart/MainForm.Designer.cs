namespace BookWise_AutoMart
{
    partial class MainForm
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
            this.tableLayoutPanelMainForm = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.pnlWelcomeUser = new System.Windows.Forms.Panel();
            this.lblWelcomeUserTitle = new System.Windows.Forms.Label();
            this.picBoxWelcomeUser = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMainForm.SuspendLayout();
            this.pnlWelcomeUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcomeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMainForm
            // 
            this.tableLayoutPanelMainForm.ColumnCount = 2;
            this.tableLayoutPanelMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainForm.Controls.Add(this.btnLogin, 1, 0);
            this.tableLayoutPanelMainForm.Controls.Add(this.btnGuest, 0, 0);
            this.tableLayoutPanelMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainForm.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanelMainForm.Name = "tableLayoutPanelMainForm";
            this.tableLayoutPanelMainForm.RowCount = 1;
            this.tableLayoutPanelMainForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainForm.Size = new System.Drawing.Size(1280, 984);
            this.tableLayoutPanelMainForm.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(852, 440);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 104);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnGuest
            // 
            this.btnGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuest.BackColor = System.Drawing.Color.White;
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.Location = new System.Drawing.Point(212, 440);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(216, 104);
            this.btnGuest.TabIndex = 0;
            this.btnGuest.TabStop = false;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = false;
            // 
            // pnlWelcomeUser
            // 
            this.pnlWelcomeUser.Controls.Add(this.lblWelcomeUserTitle);
            this.pnlWelcomeUser.Controls.Add(this.picBoxWelcomeUser);
            this.pnlWelcomeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcomeUser.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcomeUser.Name = "pnlWelcomeUser";
            this.pnlWelcomeUser.Size = new System.Drawing.Size(1280, 40);
            this.pnlWelcomeUser.TabIndex = 12;
            // 
            // lblWelcomeUserTitle
            // 
            this.lblWelcomeUserTitle.AutoSize = true;
            this.lblWelcomeUserTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUserTitle.Location = new System.Drawing.Point(43, 9);
            this.lblWelcomeUserTitle.Name = "lblWelcomeUserTitle";
            this.lblWelcomeUserTitle.Size = new System.Drawing.Size(146, 24);
            this.lblWelcomeUserTitle.TabIndex = 4;
            this.lblWelcomeUserTitle.Text = "Welcome, User!";
            // 
            // picBoxWelcomeUser
            // 
            this.picBoxWelcomeUser.Image = global::BookWise_AutoMart.Properties.Resources.smile__20px_;
            this.picBoxWelcomeUser.Location = new System.Drawing.Point(10, 8);
            this.picBoxWelcomeUser.Name = "picBoxWelcomeUser";
            this.picBoxWelcomeUser.Size = new System.Drawing.Size(25, 25);
            this.picBoxWelcomeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWelcomeUser.TabIndex = 3;
            this.picBoxWelcomeUser.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.tableLayoutPanelMainForm);
            this.Controls.Add(this.pnlWelcomeUser);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 1024);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.tableLayoutPanelMainForm.ResumeLayout(false);
            this.pnlWelcomeUser.ResumeLayout(false);
            this.pnlWelcomeUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcomeUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainForm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Panel pnlWelcomeUser;
        private System.Windows.Forms.Label lblWelcomeUserTitle;
        private System.Windows.Forms.PictureBox picBoxWelcomeUser;
    }
}

