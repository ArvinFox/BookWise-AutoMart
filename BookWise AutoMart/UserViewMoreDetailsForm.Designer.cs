﻿namespace BookWise_AutoMart
{
    partial class UserViewMoreDetailsForm
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.tblNoDataAvailable = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoDataAvailable = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewUserFeedbacks = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblDetailsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblContactRequired = new System.Windows.Forms.Label();
            this.lblEmailRequired = new System.Windows.Forms.Label();
            this.lblGenderRequired = new System.Windows.Forms.Label();
            this.colon4 = new System.Windows.Forms.Label();
            this.colon3 = new System.Windows.Forms.Label();
            this.lblNameRequired = new System.Windows.Forms.Label();
            this.colon2 = new System.Windows.Forms.Label();
            this.colon1 = new System.Windows.Forms.Label();
            this.colon = new System.Windows.Forms.Label();
            this.lblIUserName = new System.Windows.Forms.Label();
            this.txtRegisterDate = new System.Windows.Forms.TextBox();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnFemale = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblBorder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer.SuspendLayout();
            this.pnlTable.SuspendLayout();
            this.tblNoDataAvailable.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblDetailsLayout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.tblBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.pnlTable);
            this.pnlContainer.Controls.Add(this.tblButtons);
            this.pnlContainer.Controls.Add(this.tblDetailsLayout);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1325, 806);
            this.pnlContainer.TabIndex = 0;
            // 
            // pnlTable
            // 
            this.pnlTable.AutoScroll = true;
            this.pnlTable.Controls.Add(this.tblNoDataAvailable);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(0, 381);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1325, 318);
            this.pnlTable.TabIndex = 81;
            // 
            // tblNoDataAvailable
            // 
            this.tblNoDataAvailable.ColumnCount = 1;
            this.tblNoDataAvailable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNoDataAvailable.Controls.Add(this.lblNoDataAvailable, 0, 0);
            this.tblNoDataAvailable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNoDataAvailable.Location = new System.Drawing.Point(0, 0);
            this.tblNoDataAvailable.Name = "tblNoDataAvailable";
            this.tblNoDataAvailable.RowCount = 1;
            this.tblNoDataAvailable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNoDataAvailable.Size = new System.Drawing.Size(1325, 318);
            this.tblNoDataAvailable.TabIndex = 4;
            // 
            // lblNoDataAvailable
            // 
            this.lblNoDataAvailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoDataAvailable.AutoSize = true;
            this.lblNoDataAvailable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNoDataAvailable.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNoDataAvailable.Location = new System.Drawing.Point(437, 143);
            this.lblNoDataAvailable.Name = "lblNoDataAvailable";
            this.lblNoDataAvailable.Size = new System.Drawing.Size(450, 32);
            this.lblNoDataAvailable.TabIndex = 3;
            this.lblNoDataAvailable.Text = "There is no data available for this user";
            this.lblNoDataAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 1;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.8501F));
            this.tblButtons.Controls.Add(this.lblRequiredFields, 0, 0);
            this.tblButtons.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblButtons.Location = new System.Drawing.Point(0, 699);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 2;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.1028F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.8972F));
            this.tblButtons.Size = new System.Drawing.Size(1325, 107);
            this.tblButtons.TabIndex = 80;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(525, 0);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(274, 28);
            this.lblRequiredFields.TabIndex = 70;
            this.lblRequiredFields.Text = "* All fields must be filled";
            this.lblRequiredFields.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.7725F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.45302F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.77448F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.Controls.Add(this.btnViewUserFeedbacks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1319, 73);
            this.tableLayoutPanel1.TabIndex = 72;
            // 
            // btnViewUserFeedbacks
            // 
            this.btnViewUserFeedbacks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewUserFeedbacks.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewUserFeedbacks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUserFeedbacks.FlatAppearance.BorderSize = 0;
            this.btnViewUserFeedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUserFeedbacks.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUserFeedbacks.ForeColor = System.Drawing.Color.White;
            this.btnViewUserFeedbacks.Location = new System.Drawing.Point(317, 6);
            this.btnViewUserFeedbacks.Name = "btnViewUserFeedbacks";
            this.btnViewUserFeedbacks.Size = new System.Drawing.Size(192, 61);
            this.btnViewUserFeedbacks.TabIndex = 72;
            this.btnViewUserFeedbacks.Text = "User Feedbacks";
            this.btnViewUserFeedbacks.UseVisualStyleBackColor = false;
            this.btnViewUserFeedbacks.Click += new System.EventHandler(this.btnViewUserFeedbacks_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Brown;
            this.btnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(54, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(192, 61);
            this.btnDeleteUser.TabIndex = 71;
            this.btnDeleteUser.Text = "Remove User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1067, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 61);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(813, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(192, 61);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tblDetailsLayout
            // 
            this.tblDetailsLayout.ColumnCount = 4;
            this.tblDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.76923F));
            this.tblDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.23077F));
            this.tblDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 678F));
            this.tblDetailsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblDetailsLayout.Controls.Add(this.lblContactRequired, 3, 3);
            this.tblDetailsLayout.Controls.Add(this.lblEmailRequired, 3, 2);
            this.tblDetailsLayout.Controls.Add(this.lblGenderRequired, 3, 1);
            this.tblDetailsLayout.Controls.Add(this.colon4, 1, 4);
            this.tblDetailsLayout.Controls.Add(this.colon3, 1, 3);
            this.tblDetailsLayout.Controls.Add(this.lblNameRequired, 3, 0);
            this.tblDetailsLayout.Controls.Add(this.colon2, 1, 2);
            this.tblDetailsLayout.Controls.Add(this.colon1, 1, 1);
            this.tblDetailsLayout.Controls.Add(this.colon, 1, 0);
            this.tblDetailsLayout.Controls.Add(this.lblIUserName, 0, 0);
            this.tblDetailsLayout.Controls.Add(this.txtRegisterDate, 2, 4);
            this.tblDetailsLayout.Controls.Add(this.lblRegisterDate, 0, 4);
            this.tblDetailsLayout.Controls.Add(this.txtContact, 2, 3);
            this.tblDetailsLayout.Controls.Add(this.txtName, 2, 0);
            this.tblDetailsLayout.Controls.Add(this.txtEmail, 2, 2);
            this.tblDetailsLayout.Controls.Add(this.lblGender, 0, 1);
            this.tblDetailsLayout.Controls.Add(this.lblContact, 0, 3);
            this.tblDetailsLayout.Controls.Add(this.lblEmail, 0, 2);
            this.tblDetailsLayout.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tblDetailsLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblDetailsLayout.Location = new System.Drawing.Point(0, 72);
            this.tblDetailsLayout.Name = "tblDetailsLayout";
            this.tblDetailsLayout.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.tblDetailsLayout.RowCount = 5;
            this.tblDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetailsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblDetailsLayout.Size = new System.Drawing.Size(1325, 309);
            this.tblDetailsLayout.TabIndex = 79;
            // 
            // lblContactRequired
            // 
            this.lblContactRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContactRequired.AutoSize = true;
            this.lblContactRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblContactRequired.ForeColor = System.Drawing.Color.Red;
            this.lblContactRequired.Location = new System.Drawing.Point(1283, 205);
            this.lblContactRequired.Name = "lblContactRequired";
            this.lblContactRequired.Size = new System.Drawing.Size(22, 28);
            this.lblContactRequired.TabIndex = 86;
            this.lblContactRequired.Text = "*";
            this.lblContactRequired.Visible = false;
            // 
            // lblEmailRequired
            // 
            this.lblEmailRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailRequired.AutoSize = true;
            this.lblEmailRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblEmailRequired.ForeColor = System.Drawing.Color.Red;
            this.lblEmailRequired.Location = new System.Drawing.Point(1283, 148);
            this.lblEmailRequired.Name = "lblEmailRequired";
            this.lblEmailRequired.Size = new System.Drawing.Size(22, 28);
            this.lblEmailRequired.TabIndex = 85;
            this.lblEmailRequired.Text = "*";
            this.lblEmailRequired.Visible = false;
            // 
            // lblGenderRequired
            // 
            this.lblGenderRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenderRequired.AutoSize = true;
            this.lblGenderRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblGenderRequired.ForeColor = System.Drawing.Color.Red;
            this.lblGenderRequired.Location = new System.Drawing.Point(1283, 91);
            this.lblGenderRequired.Name = "lblGenderRequired";
            this.lblGenderRequired.Size = new System.Drawing.Size(22, 28);
            this.lblGenderRequired.TabIndex = 84;
            this.lblGenderRequired.Text = "*";
            this.lblGenderRequired.Visible = false;
            // 
            // colon4
            // 
            this.colon4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon4.AutoSize = true;
            this.colon4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.colon4.ForeColor = System.Drawing.Color.Black;
            this.colon4.Location = new System.Drawing.Point(536, 264);
            this.colon4.Name = "colon4";
            this.colon4.Size = new System.Drawing.Size(19, 28);
            this.colon4.TabIndex = 83;
            this.colon4.Text = ":";
            // 
            // colon3
            // 
            this.colon3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon3.AutoSize = true;
            this.colon3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.colon3.ForeColor = System.Drawing.Color.Black;
            this.colon3.Location = new System.Drawing.Point(536, 205);
            this.colon3.Name = "colon3";
            this.colon3.Size = new System.Drawing.Size(19, 28);
            this.colon3.TabIndex = 82;
            this.colon3.Text = ":";
            // 
            // lblNameRequired
            // 
            this.lblNameRequired.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNameRequired.AutoSize = true;
            this.lblNameRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblNameRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNameRequired.Location = new System.Drawing.Point(1283, 34);
            this.lblNameRequired.Name = "lblNameRequired";
            this.lblNameRequired.Size = new System.Drawing.Size(22, 28);
            this.lblNameRequired.TabIndex = 65;
            this.lblNameRequired.Text = "*";
            this.lblNameRequired.Visible = false;
            // 
            // colon2
            // 
            this.colon2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon2.AutoSize = true;
            this.colon2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.colon2.ForeColor = System.Drawing.Color.Black;
            this.colon2.Location = new System.Drawing.Point(536, 148);
            this.colon2.Name = "colon2";
            this.colon2.Size = new System.Drawing.Size(19, 28);
            this.colon2.TabIndex = 81;
            this.colon2.Text = ":";
            // 
            // colon1
            // 
            this.colon1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon1.AutoSize = true;
            this.colon1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.colon1.ForeColor = System.Drawing.Color.Black;
            this.colon1.Location = new System.Drawing.Point(536, 91);
            this.colon1.Name = "colon1";
            this.colon1.Size = new System.Drawing.Size(19, 28);
            this.colon1.TabIndex = 80;
            this.colon1.Text = ":";
            // 
            // colon
            // 
            this.colon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colon.AutoSize = true;
            this.colon.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.colon.ForeColor = System.Drawing.Color.Black;
            this.colon.Location = new System.Drawing.Point(536, 34);
            this.colon.Name = "colon";
            this.colon.Size = new System.Drawing.Size(19, 28);
            this.colon.TabIndex = 79;
            this.colon.Text = ":";
            // 
            // lblIUserName
            // 
            this.lblIUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIUserName.AutoSize = true;
            this.lblIUserName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblIUserName.ForeColor = System.Drawing.Color.Black;
            this.lblIUserName.Location = new System.Drawing.Point(23, 34);
            this.lblIUserName.Name = "lblIUserName";
            this.lblIUserName.Size = new System.Drawing.Size(126, 28);
            this.lblIUserName.TabIndex = 54;
            this.lblIUserName.Text = "Username";
            // 
            // txtRegisterDate
            // 
            this.txtRegisterDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterDate.BackColor = System.Drawing.Color.White;
            this.txtRegisterDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegisterDate.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.txtRegisterDate.Location = new System.Drawing.Point(601, 260);
            this.txtRegisterDate.Multiline = true;
            this.txtRegisterDate.Name = "txtRegisterDate";
            this.txtRegisterDate.ReadOnly = true;
            this.txtRegisterDate.Size = new System.Drawing.Size(648, 37);
            this.txtRegisterDate.TabIndex = 77;
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterDate.Location = new System.Drawing.Point(23, 264);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(212, 28);
            this.lblRegisterDate.TabIndex = 78;
            this.lblRegisterDate.Text = "Registration Date";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContact.BackColor = System.Drawing.Color.White;
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(601, 201);
            this.txtContact.MaxLength = 10;
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(648, 37);
            this.txtContact.TabIndex = 75;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(601, 30);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(648, 37);
            this.txtName.TabIndex = 52;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Gadugi", 15F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(601, 144);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(648, 37);
            this.txtEmail.TabIndex = 73;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(23, 91);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(95, 28);
            this.lblGender.TabIndex = 72;
            this.lblGender.Text = "Gender";
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(23, 205);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(141, 28);
            this.lblContact.TabIndex = 76;
            this.lblContact.Text = "Contact No";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(23, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 28);
            this.lblEmail.TabIndex = 74;
            this.lblEmail.Text = "Email";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioBtnFemale, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtnMale, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(589, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(672, 51);
            this.tableLayoutPanel2.TabIndex = 87;
            // 
            // radioBtnFemale
            // 
            this.radioBtnFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnFemale.AutoSize = true;
            this.radioBtnFemale.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFemale.Location = new System.Drawing.Point(447, 9);
            this.radioBtnFemale.Name = "radioBtnFemale";
            this.radioBtnFemale.Size = new System.Drawing.Size(113, 33);
            this.radioBtnFemale.TabIndex = 1;
            this.radioBtnFemale.TabStop = true;
            this.radioBtnFemale.Text = "Female";
            this.radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnMale.Location = new System.Drawing.Point(124, 9);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(88, 33);
            this.radioBtnMale.TabIndex = 0;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Male";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTitle
            // 
            this.tableLayoutPanelTitle.BackColor = System.Drawing.Color.IndianRed;
            this.tableLayoutPanelTitle.ColumnCount = 1;
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTitle.Name = "tableLayoutPanelTitle";
            this.tableLayoutPanelTitle.RowCount = 1;
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(1325, 72);
            this.tableLayoutPanelTitle.TabIndex = 47;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(498, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(329, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "More User Details";
            // 
            // tblBorder
            // 
            this.tblBorder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.tblBorder.ColumnCount = 3;
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.Controls.Add(this.pnlContainer, 1, 1);
            this.tblBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBorder.Location = new System.Drawing.Point(0, 0);
            this.tblBorder.Name = "tblBorder";
            this.tblBorder.RowCount = 3;
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblBorder.Size = new System.Drawing.Size(1337, 818);
            this.tblBorder.TabIndex = 2;
            // 
            // UserViewMoreDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 818);
            this.Controls.Add(this.tblBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserViewMoreDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserViewMoreDetailsForm";
            this.Load += new System.EventHandler(this.UserViewMoreDetailsForm_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlTable.ResumeLayout(false);
            this.tblNoDataAvailable.ResumeLayout(false);
            this.tblNoDataAvailable.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.tblButtons.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tblDetailsLayout.ResumeLayout(false);
            this.tblDetailsLayout.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.tblBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.TableLayoutPanel tblButtons;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tblDetailsLayout;
        private System.Windows.Forms.Label lblContactRequired;
        private System.Windows.Forms.Label lblEmailRequired;
        private System.Windows.Forms.Label lblGenderRequired;
        private System.Windows.Forms.Label colon4;
        private System.Windows.Forms.Label colon3;
        private System.Windows.Forms.Label lblNameRequired;
        private System.Windows.Forms.Label colon2;
        private System.Windows.Forms.Label colon1;
        private System.Windows.Forms.Label colon;
        private System.Windows.Forms.Label lblIUserName;
        private System.Windows.Forms.TextBox txtRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tblBorder;
        private System.Windows.Forms.Label lblNoDataAvailable;
        private System.Windows.Forms.TableLayoutPanel tblNoDataAvailable;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioBtnFemale;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.Button btnViewUserFeedbacks;
    }
}