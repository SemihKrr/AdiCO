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
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.picBoxAdmin = new System.Windows.Forms.PictureBox();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.btnManageMenu = new System.Windows.Forms.Panel();
            this.lblManageMenu = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnManageAccount.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).BeginInit();
            this.panelNavBar.SuspendLayout();
            this.btnManageMenu.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.btnLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageAccount.Controls.Add(this.pictureBox2);
            this.btnManageAccount.Controls.Add(this.lblManageAccount);
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.Location = new System.Drawing.Point(12, 14);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Padding = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Size = new System.Drawing.Size(196, 60);
            this.btnManageAccount.TabIndex = 5;
            this.btnManageAccount.Tag = "btnSideBar-Selected";
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageAccount.Location = new System.Drawing.Point(42, 2);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(152, 56);
            this.lblManageAccount.TabIndex = 10;
            this.lblManageAccount.Text = "Manage Account";
            this.lblManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageAccount.Click += new System.EventHandler(this.lblManageAccount_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.panelAdmin.Controls.Add(this.lblAdminEmail);
            this.panelAdmin.Controls.Add(this.lblAdminName);
            this.panelAdmin.Controls.Add(this.picBoxAdmin);
            this.panelAdmin.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(12, 12);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(760, 70);
            this.panelAdmin.TabIndex = 10;
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminEmail.Location = new System.Drawing.Point(59, 39);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(112, 15);
            this.lblAdminEmail.TabIndex = 15;
            this.lblAdminEmail.Text = "admin@gmail.com";
            this.lblAdminEmail.Click += new System.EventHandler(this.lblAdminEmail_Click);
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblAdminName.Location = new System.Drawing.Point(58, 15);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(97, 24);
            this.lblAdminName.TabIndex = 14;
            this.lblAdminName.Text = "Username";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // picBoxAdmin
            // 
            this.picBoxAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAdmin.Image")));
            this.picBoxAdmin.Location = new System.Drawing.Point(16, 19);
            this.picBoxAdmin.Name = "picBoxAdmin";
            this.picBoxAdmin.Size = new System.Drawing.Size(32, 32);
            this.picBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAdmin.TabIndex = 13;
            this.picBoxAdmin.TabStop = false;
            this.picBoxAdmin.Click += new System.EventHandler(this.picBoxAdmin_Click);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(32)))));
            this.panelNavBar.Controls.Add(this.panelAdmin);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Padding = new System.Windows.Forms.Padding(12);
            this.panelNavBar.Size = new System.Drawing.Size(784, 94);
            this.panelNavBar.TabIndex = 11;
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageMenu.Controls.Add(this.pictureBox3);
            this.btnManageMenu.Controls.Add(this.lblManageMenu);
            this.btnManageMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageMenu.Location = new System.Drawing.Point(12, 80);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Padding = new System.Windows.Forms.Padding(2);
            this.btnManageMenu.Size = new System.Drawing.Size(196, 60);
            this.btnManageMenu.TabIndex = 10;
            this.btnManageMenu.Tag = "btnSideBar-NotSelected";
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // lblManageMenu
            // 
            this.lblManageMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblManageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageMenu.Location = new System.Drawing.Point(42, 2);
            this.lblManageMenu.Name = "lblManageMenu";
            this.lblManageMenu.Size = new System.Drawing.Size(152, 56);
            this.lblManageMenu.TabIndex = 12;
            this.lblManageMenu.Text = "Manage Menu";
            this.lblManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblManageMenu.Click += new System.EventHandler(this.lblManageMenu_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 94);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(14);
            this.panelContent.Size = new System.Drawing.Size(564, 347);
            this.panelContent.TabIndex = 13;
            // 
            // panelSideBar
            // 
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.btnManageAccount);
            this.panelSideBar.Controls.Add(this.btnManageMenu);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 94);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(220, 347);
            this.panelSideBar.TabIndex = 12;
            // 
            // lblLogout
            // 
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Location = new System.Drawing.Point(57, 2);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(160, 62);
            this.lblLogout.TabIndex = 12;
            this.lblLogout.Text = "Logout";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Controls.Add(this.pictureBox1);
            this.btnLogout.Controls.Add(this.lblLogout);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 283);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(2);
            this.btnLogout.Size = new System.Drawing.Size(220, 64);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Tag = "btnSideBar-NotSelected";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // FormNavigationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelNavBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNavigationAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdiCO - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationAdmin_Load);
            this.btnManageAccount.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAdmin)).EndInit();
            this.panelNavBar.ResumeLayout(false);
            this.btnManageMenu.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.btnLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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