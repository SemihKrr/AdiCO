namespace GzKitchen
{
    partial class FormNavigationAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationAdmin));
            this.btnManageAccount = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnManageMenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblManageMenu = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnManageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.btnManageMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.btnLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageAccount
            // 
            resources.ApplyResources(this.btnManageAccount, "btnManageAccount");
            this.btnManageAccount.Controls.Add(this.pictureBox2);
            this.btnManageAccount.Controls.Add(this.lblManageAccount);
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Tag = "btnSideBar-Selected";
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lblManageAccount
            // 
            resources.ApplyResources(this.lblManageAccount, "lblManageAccount");
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Click += new System.EventHandler(this.lblManageAccount_Click);
            // 
            // panelAdmin
            // 
            resources.ApplyResources(this.panelAdmin, "panelAdmin");
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.panelAdmin.Controls.Add(this.lblAdminEmail);
            this.panelAdmin.Controls.Add(this.lblAdminName);
            this.panelAdmin.Controls.Add(this.picBoxAdmin);
            this.panelAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAdmin.Name = "panelAdmin";
            // 
            // lblAdminEmail
            // 
            resources.ApplyResources(this.lblAdminEmail, "lblAdminEmail");
            this.lblAdminEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Click += new System.EventHandler(this.lblAdminEmail_Click);
            // 
            // lblAdminName
            // 
            resources.ApplyResources(this.lblAdminName, "lblAdminName");
            this.lblAdminName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // picBoxAdmin
            // 
            resources.ApplyResources(this.picBoxAdmin, "picBoxAdmin");
            this.picBoxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.TabStop = false;
            this.picBoxAdmin.Click += new System.EventHandler(this.picBoxAdmin_Click);
            // 
            // panelNavBar
            // 
            resources.ApplyResources(this.panelNavBar, "panelNavBar");
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(32)))));
            this.panelNavBar.Controls.Add(this.panelAdmin);
            this.panelNavBar.Name = "panelNavBar";
            // 
            // btnManageMenu
            // 
            resources.ApplyResources(this.btnManageMenu, "btnManageMenu");
            this.btnManageMenu.Controls.Add(this.pictureBox3);
            this.btnManageMenu.Controls.Add(this.lblManageMenu);
            this.btnManageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Tag = "btnSideBar-NotSelected";
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // lblManageMenu
            // 
            resources.ApplyResources(this.lblManageMenu, "lblManageMenu");
            this.lblManageMenu.Name = "lblManageMenu";
            this.lblManageMenu.Click += new System.EventHandler(this.lblManageMenu_Click);
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            // 
            // panelSideBar
            // 
            resources.ApplyResources(this.panelSideBar, "panelSideBar");
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.btnManageAccount);
            this.panelSideBar.Controls.Add(this.btnManageMenu);
            this.panelSideBar.Name = "panelSideBar";
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Controls.Add(this.pictureBox1);
            this.btnLogout.Controls.Add(this.lblLogout);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Tag = "btnSideBar-NotSelected";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblLogout
            // 
            resources.ApplyResources(this.lblLogout, "lblLogout");
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // FormNavigationAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelNavBar);
            this.Name = "FormNavigationAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationAdmin_Load);
            this.btnManageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.btnManageMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.btnLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel btnManageAccount;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.PictureBox picBoxAdmin;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Panel btnManageMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Label lblManageMenu;
        private System.Windows.Forms.Panel btnLogout;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}