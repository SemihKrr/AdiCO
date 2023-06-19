namespace GzKitchen
{
    partial class OrderedMenuLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderedMenuLayout));
            this.lblOrderedMenuSubtotal = new System.Windows.Forms.Label();
            this.lblOrderedMenuQty = new System.Windows.Forms.Label();
            this.picBoxOrderedMenu = new System.Windows.Forms.PictureBox();
            this.lblOrderedMenuPrice = new System.Windows.Forms.Label();
            this.lblOrderedMenuName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderedMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderedMenuSubtotal
            // 
            resources.ApplyResources(this.lblOrderedMenuSubtotal, "lblOrderedMenuSubtotal");
            this.lblOrderedMenuSubtotal.Name = "lblOrderedMenuSubtotal";
            // 
            // lblOrderedMenuQty
            // 
            resources.ApplyResources(this.lblOrderedMenuQty, "lblOrderedMenuQty");
            this.lblOrderedMenuQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblOrderedMenuQty.Name = "lblOrderedMenuQty";
            // 
            // picBoxOrderedMenu
            // 
            resources.ApplyResources(this.picBoxOrderedMenu, "picBoxOrderedMenu");
            this.picBoxOrderedMenu.Name = "picBoxOrderedMenu";
            this.picBoxOrderedMenu.TabStop = false;
            // 
            // lblOrderedMenuPrice
            // 
            resources.ApplyResources(this.lblOrderedMenuPrice, "lblOrderedMenuPrice");
            this.lblOrderedMenuPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblOrderedMenuPrice.Name = "lblOrderedMenuPrice";
            // 
            // lblOrderedMenuName
            // 
            resources.ApplyResources(this.lblOrderedMenuName, "lblOrderedMenuName");
            this.lblOrderedMenuName.Name = "lblOrderedMenuName";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OrderedMenuLayout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.lblOrderedMenuQty);
            this.Controls.Add(this.lblOrderedMenuSubtotal);
            this.Controls.Add(this.lblOrderedMenuPrice);
            this.Controls.Add(this.lblOrderedMenuName);
            this.Controls.Add(this.picBoxOrderedMenu);
            this.Controls.Add(this.btnDelete);
            this.Name = "OrderedMenuLayout";
            this.Load += new System.EventHandler(this.OrderedMenuLayout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrderedMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderedMenuPrice;
        private System.Windows.Forms.Label lblOrderedMenuQty;
        private System.Windows.Forms.Label lblOrderedMenuSubtotal;
        private System.Windows.Forms.PictureBox picBoxOrderedMenu;
        private System.Windows.Forms.Label lblOrderedMenuName;
        private System.Windows.Forms.Label btnDelete;
    }
}
