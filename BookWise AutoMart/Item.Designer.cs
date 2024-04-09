﻿namespace BookWise_AutoMart
{
    partial class Item
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
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.butAddCart = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butRemove = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblNameItem = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.panelDescription.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Red;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(4, 7);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblDiscount.Size = new System.Drawing.Size(75, 35);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = "10%";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDescription
            // 
            this.panelDescription.Controls.Add(this.butAddCart);
            this.panelDescription.Controls.Add(this.lblStock);
            this.panelDescription.Controls.Add(this.lblPrice);
            this.panelDescription.Controls.Add(this.tableLayoutPanel1);
            this.panelDescription.Controls.Add(this.lblNameItem);
            this.panelDescription.Location = new System.Drawing.Point(9, 261);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(183, 178);
            this.panelDescription.TabIndex = 7;
            // 
            // butAddCart
            // 
            this.butAddCart.BackColor = System.Drawing.Color.White;
            this.butAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddCart.Location = new System.Drawing.Point(37, 142);
            this.butAddCart.Name = "butAddCart";
            this.butAddCart.Size = new System.Drawing.Size(103, 32);
            this.butAddCart.TabIndex = 8;
            this.butAddCart.Text = "Buy";
            this.butAddCart.UseVisualStyleBackColor = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(10, 107);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 20);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "label2";
            this.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(59, 73);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "label2";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.butRemove, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butAdd, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtQty, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(104, 107);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(79, 23);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // butRemove
            // 
            this.butRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRemove.Location = new System.Drawing.Point(2, 2);
            this.butRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(26, 19);
            this.butRemove.TabIndex = 4;
            this.butRemove.Text = "-";
            this.butRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butRemove.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAdd.Location = new System.Drawing.Point(57, 2);
            this.butAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(20, 19);
            this.butAdd.TabIndex = 5;
            this.butAdd.Text = "+";
            this.butAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(32, 2);
            this.txtQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(21, 16);
            this.txtQty.TabIndex = 3;
            // 
            // lblNameItem
            // 
            this.lblNameItem.AutoSize = true;
            this.lblNameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameItem.Location = new System.Drawing.Point(10, 11);
            this.lblNameItem.MaximumSize = new System.Drawing.Size(173, 0);
            this.lblNameItem.Name = "lblNameItem";
            this.lblNameItem.Size = new System.Drawing.Size(57, 20);
            this.lblNameItem.TabIndex = 0;
            this.lblNameItem.Text = "label1";
            this.lblNameItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(9, 16);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(183, 244);
            this.image.TabIndex = 6;
            this.image.TabStop = false;
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.panelDescription);
            this.Controls.Add(this.image);
            this.Margin = new System.Windows.Forms.Padding(27, 50, 13, 20);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(197, 446);
            this.Load += new System.EventHandler(this.Item_load);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.Button butAddCart;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butRemove;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblNameItem;
        private System.Windows.Forms.PictureBox image;
    }
}