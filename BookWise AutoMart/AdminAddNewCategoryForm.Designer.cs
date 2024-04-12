namespace BookWise_AutoMart
{
    partial class AdminAddNewCategoryForm
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
            this.tblBorder = new System.Windows.Forms.TableLayoutPanel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPaneltxt = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNewCategoryRequired = new System.Windows.Forms.Label();
            this.tblBorder.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.tableLayoutPaneltxt.SuspendLayout();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.SuspendLayout();
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
            this.tblBorder.Size = new System.Drawing.Size(750, 289);
            this.tblBorder.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.lblNewCategoryRequired);
            this.pnlContainer.Controls.Add(this.tableLayoutPaneltxt);
            this.pnlContainer.Controls.Add(this.tableLayoutPanelTitle);
            this.pnlContainer.Controls.Add(this.btnCancel);
            this.pnlContainer.Controls.Add(this.btnSave);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(6, 6);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(738, 277);
            this.pnlContainer.TabIndex = 0;
            // 
            // tableLayoutPaneltxt
            // 
            this.tableLayoutPaneltxt.ColumnCount = 1;
            this.tableLayoutPaneltxt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPaneltxt.Controls.Add(this.txtNewCategory, 0, 0);
            this.tableLayoutPaneltxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPaneltxt.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPaneltxt.Name = "tableLayoutPaneltxt";
            this.tableLayoutPaneltxt.RowCount = 1;
            this.tableLayoutPaneltxt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPaneltxt.Size = new System.Drawing.Size(738, 131);
            this.tableLayoutPaneltxt.TabIndex = 42;
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewCategory.BackColor = System.Drawing.Color.White;
            this.txtNewCategory.Font = new System.Drawing.Font("Gadugi", 19F);
            this.txtNewCategory.ForeColor = System.Drawing.Color.Black;
            this.txtNewCategory.Location = new System.Drawing.Point(129, 41);
            this.txtNewCategory.Multiline = true;
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(480, 48);
            this.txtNewCategory.TabIndex = 29;
            this.txtNewCategory.TextChanged += new System.EventHandler(this.txtNewCategory_TextChanged);
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
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(738, 72);
            this.tableLayoutPanelTitle.TabIndex = 38;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gadugi", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(195, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(348, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Category";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(606, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 61);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(471, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 61);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNewCategoryRequired
            // 
            this.lblNewCategoryRequired.AutoSize = true;
            this.lblNewCategoryRequired.Font = new System.Drawing.Font("Gadugi", 14F);
            this.lblNewCategoryRequired.ForeColor = System.Drawing.Color.Red;
            this.lblNewCategoryRequired.Location = new System.Drawing.Point(14, 233);
            this.lblNewCategoryRequired.Name = "lblNewCategoryRequired";
            this.lblNewCategoryRequired.Size = new System.Drawing.Size(318, 28);
            this.lblNewCategoryRequired.TabIndex = 43;
            this.lblNewCategoryRequired.Text = "*Please enter category name";
            this.lblNewCategoryRequired.Visible = false;
            // 
            // AdminAddNewCategoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 289);
            this.Controls.Add(this.tblBorder);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAddNewCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAddNewCategoryForm";
            this.tblBorder.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.tableLayoutPaneltxt.ResumeLayout(false);
            this.tableLayoutPaneltxt.PerformLayout();
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tableLayoutPanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBorder;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPaneltxt;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNewCategoryRequired;
    }
}