namespace BookWise_AutoMart
{
    partial class UserDisplayItemsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butSearch = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.tblCategoryNameContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.flpItemCardsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tblFilterSearchContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tblSearchContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tblCategoryNameContainer.SuspendLayout();
            this.tblFilterSearchContainer.SuspendLayout();
            this.tblSearchContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSearch
            // 
            this.butSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.butSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.Location = new System.Drawing.Point(392, 26);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(151, 41);
            this.butSearch.TabIndex = 7;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(20, 29);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(349, 35);
            this.txtItemName.TabIndex = 6;
            // 
            // tblCategoryNameContainer
            // 
            this.tblCategoryNameContainer.ColumnCount = 1;
            this.tblCategoryNameContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCategoryNameContainer.Controls.Add(this.lblCategoryName, 0, 0);
            this.tblCategoryNameContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblCategoryNameContainer.Location = new System.Drawing.Point(0, 0);
            this.tblCategoryNameContainer.Name = "tblCategoryNameContainer";
            this.tblCategoryNameContainer.RowCount = 1;
            this.tblCategoryNameContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCategoryNameContainer.Size = new System.Drawing.Size(1164, 100);
            this.tblCategoryNameContainer.TabIndex = 11;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(430, 27);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(304, 46);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "category Name";
            this.lblCategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpItemCardsContainer
            // 
            this.flpItemCardsContainer.AutoScroll = true;
            this.flpItemCardsContainer.BackColor = System.Drawing.Color.White;
            this.flpItemCardsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItemCardsContainer.Location = new System.Drawing.Point(0, 200);
            this.flpItemCardsContainer.Name = "flpItemCardsContainer";
            this.flpItemCardsContainer.Size = new System.Drawing.Size(1164, 565);
            this.flpItemCardsContainer.TabIndex = 10;
            // 
            // tblFilterSearchContainer
            // 
            this.tblFilterSearchContainer.ColumnCount = 2;
            this.tblFilterSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilterSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 642F));
            this.tblFilterSearchContainer.Controls.Add(this.tblSearchContainer, 1, 0);
            this.tblFilterSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFilterSearchContainer.Location = new System.Drawing.Point(0, 100);
            this.tblFilterSearchContainer.Name = "tblFilterSearchContainer";
            this.tblFilterSearchContainer.RowCount = 1;
            this.tblFilterSearchContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilterSearchContainer.Size = new System.Drawing.Size(1164, 100);
            this.tblFilterSearchContainer.TabIndex = 0;
            // 
            // tblSearchContainer
            // 
            this.tblSearchContainer.ColumnCount = 2;
            this.tblSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.16352F));
            this.tblSearchContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.83648F));
            this.tblSearchContainer.Controls.Add(this.txtItemName, 0, 0);
            this.tblSearchContainer.Controls.Add(this.butSearch, 1, 0);
            this.tblSearchContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSearchContainer.Location = new System.Drawing.Point(525, 3);
            this.tblSearchContainer.Name = "tblSearchContainer";
            this.tblSearchContainer.RowCount = 1;
            this.tblSearchContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSearchContainer.Size = new System.Drawing.Size(636, 94);
            this.tblSearchContainer.TabIndex = 8;
            // 
            // UserDisplayItemsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpItemCardsContainer);
            this.Controls.Add(this.tblFilterSearchContainer);
            this.Controls.Add(this.tblCategoryNameContainer);
            this.Name = "UserDisplayItemsPanel";
            this.Size = new System.Drawing.Size(1164, 765);
            this.Load += new System.EventHandler(this.displayItem_load);
            this.tblCategoryNameContainer.ResumeLayout(false);
            this.tblCategoryNameContainer.PerformLayout();
            this.tblFilterSearchContainer.ResumeLayout(false);
            this.tblSearchContainer.ResumeLayout(false);
            this.tblSearchContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TableLayoutPanel tblCategoryNameContainer;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.FlowLayoutPanel flpItemCardsContainer;
        private System.Windows.Forms.TableLayoutPanel tblFilterSearchContainer;
        private System.Windows.Forms.TableLayoutPanel tblSearchContainer;
    }
}
