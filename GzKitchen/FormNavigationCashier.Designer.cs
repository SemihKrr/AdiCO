namespace GzKitchen
{
    partial class FormNavigationCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationCashier));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelCashier = new System.Windows.Forms.Panel();
            this.lblCashierEmail = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.picBoxCashier = new System.Windows.Forms.PictureBox();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.panelOrderedMenu = new System.Windows.Forms.Panel();
            this.btnCharge = new System.Windows.Forms.Button();
            this.lblOrderedMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuList = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.picBoxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblMenuList = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNavBar.SuspendLayout();
            this.panelCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCashier)).BeginInit();
            this.panelPayment.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(32)))));
            this.panelNavBar.Controls.Add(this.panelCashier);
            resources.ApplyResources(this.panelNavBar, "panelNavBar");
            this.panelNavBar.Name = "panelNavBar";
            // 
            // panelCashier
            // 
            this.panelCashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.panelCashier.Controls.Add(this.button1);
            this.panelCashier.Controls.Add(this.lblCashierEmail);
            this.panelCashier.Controls.Add(this.lblCashierName);
            this.panelCashier.Controls.Add(this.picBoxCashier);
            this.panelCashier.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.panelCashier, "panelCashier");
            this.panelCashier.Name = "panelCashier";
            // 
            // lblCashierEmail
            // 
            resources.ApplyResources(this.lblCashierEmail, "lblCashierEmail");
            this.lblCashierEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashierEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblCashierEmail.Name = "lblCashierEmail";
            this.lblCashierEmail.Click += new System.EventHandler(this.lblCashierEmail_Click);
            // 
            // lblCashierName
            // 
            resources.ApplyResources(this.lblCashierName, "lblCashierName");
            this.lblCashierName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCashierName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Click += new System.EventHandler(this.lblCashierName_Click);
            // 
            // picBoxCashier
            // 
            this.picBoxCashier.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.picBoxCashier, "picBoxCashier");
            this.picBoxCashier.Name = "picBoxCashier";
            this.picBoxCashier.TabStop = false;
            this.picBoxCashier.Click += new System.EventHandler(this.picBoxCashier_Click);
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.panelTotal);
            this.panelPayment.Controls.Add(this.panelOrderedMenu);
            this.panelPayment.Controls.Add(this.btnCharge);
            this.panelPayment.Controls.Add(this.lblOrderedMenu);
            resources.ApplyResources(this.panelPayment, "panelPayment");
            this.panelPayment.Name = "panelPayment";
            // 
            // panelTotal
            // 
            resources.ApplyResources(this.panelTotal, "panelTotal");
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Controls.Add(this.txtTotal);
            this.panelTotal.Name = "panelTotal";
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.lblTotal.Name = "lblTotal";
            // 
            // txtTotal
            // 
            resources.ApplyResources(this.txtTotal, "txtTotal");
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Name = "txtTotal";
            // 
            // panelOrderedMenu
            // 
            resources.ApplyResources(this.panelOrderedMenu, "panelOrderedMenu");
            this.panelOrderedMenu.Name = "panelOrderedMenu";
            // 
            // btnCharge
            // 
            this.btnCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.btnCharge, "btnCharge");
            this.btnCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCharge.Name = "btnCharge";
            this.btnCharge.UseVisualStyleBackColor = false;
            this.btnCharge.Click += new System.EventHandler(this.btnCharge_Click);
            // 
            // lblOrderedMenu
            // 
            resources.ApplyResources(this.lblOrderedMenu, "lblOrderedMenu");
            this.lblOrderedMenu.Name = "lblOrderedMenu";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelMenu.Controls.Add(this.panelMenuList);
            this.panelMenu.Controls.Add(this.panelSearch);
            this.panelMenu.Controls.Add(this.lblMenuList);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panelMenuList
            // 
            resources.ApplyResources(this.panelMenuList, "panelMenuList");
            this.panelMenuList.Name = "panelMenuList";
            // 
            // panelSearch
            // 
            resources.ApplyResources(this.panelSearch, "panelSearch");
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panelSearch.Controls.Add(this.picBoxSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Name = "panelSearch";
            // 
            // picBoxSearch
            // 
            resources.ApplyResources(this.picBoxSearch, "picBoxSearch");
            this.picBoxSearch.Name = "picBoxSearch";
            this.picBoxSearch.TabStop = false;
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lblMenuList
            // 
            resources.ApplyResources(this.lblMenuList, "lblMenuList");
            this.lblMenuList.Name = "lblMenuList";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNavigationCashier
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNavigationCashier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationCashier_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationCashier_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelCashier.ResumeLayout(false);
            this.panelCashier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCashier)).EndInit();
            this.panelPayment.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelCashier;
        private System.Windows.Forms.Label lblCashierEmail;
        private System.Windows.Forms.Label lblCashierName;
        private System.Windows.Forms.PictureBox picBoxCashier;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblMenuList;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picBoxSearch;
        private System.Windows.Forms.Panel panelMenuList;
        private System.Windows.Forms.Label lblOrderedMenu;
        private System.Windows.Forms.Button btnCharge;
        private System.Windows.Forms.Panel panelOrderedMenu;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
    }
}