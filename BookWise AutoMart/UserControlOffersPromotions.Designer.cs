namespace BookWise_AutoMart
{
    partial class UserControlOffersPromotions
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
            this.pnlDisplayOffers = new System.Windows.Forms.Panel();
            this.pnlAddNewOffer = new System.Windows.Forms.Panel();
            this.btnAddNewOffer = new System.Windows.Forms.Button();
            this.pnlAddNewOffer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplayOffers
            // 
            this.pnlDisplayOffers.AutoScroll = true;
            this.pnlDisplayOffers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayOffers.Location = new System.Drawing.Point(0, 0);
            this.pnlDisplayOffers.Name = "pnlDisplayOffers";
            this.pnlDisplayOffers.Size = new System.Drawing.Size(1257, 684);
            this.pnlDisplayOffers.TabIndex = 0;
            // 
            // pnlAddNewOffer
            // 
            this.pnlAddNewOffer.Controls.Add(this.btnAddNewOffer);
            this.pnlAddNewOffer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddNewOffer.Location = new System.Drawing.Point(0, 612);
            this.pnlAddNewOffer.Name = "pnlAddNewOffer";
            this.pnlAddNewOffer.Size = new System.Drawing.Size(1257, 72);
            this.pnlAddNewOffer.TabIndex = 4;
            // 
            // btnAddNewOffer
            // 
            this.btnAddNewOffer.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddNewOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewOffer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewOffer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnAddNewOffer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAddNewOffer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewOffer.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewOffer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewOffer.Image = global::BookWise_AutoMart.Properties.Resources.add_new_item__white_;
            this.btnAddNewOffer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewOffer.Location = new System.Drawing.Point(3, 3);
            this.btnAddNewOffer.Name = "btnAddNewOffer";
            this.btnAddNewOffer.Size = new System.Drawing.Size(281, 64);
            this.btnAddNewOffer.TabIndex = 3;
            this.btnAddNewOffer.Text = "Add Offer";
            this.btnAddNewOffer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewOffer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewOffer.UseVisualStyleBackColor = false;
            this.btnAddNewOffer.Click += new System.EventHandler(this.btnAddNewOffer_Click);
            // 
            // UserControlOffersPromotions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.pnlAddNewOffer);
            this.Controls.Add(this.pnlDisplayOffers);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlOffersPromotions";
            this.Size = new System.Drawing.Size(1257, 684);
            this.Load += new System.EventHandler(this.UserControlOffersPromotions_Load);
            this.ParentChanged += new System.EventHandler(this.UserControlOffersPromotions_ParentChanged);
            this.pnlAddNewOffer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplayOffers;
        private System.Windows.Forms.Button btnAddNewOffer;
        private System.Windows.Forms.Panel pnlAddNewOffer;
    }
}
