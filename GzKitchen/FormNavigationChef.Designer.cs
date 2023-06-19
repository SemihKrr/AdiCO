namespace GzKitchen
{
    partial class FormNavigationChef
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavigationChef));
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.panelChef = new System.Windows.Forms.Panel();
            this.lblChefEmail = new System.Windows.Forms.Label();
            this.lblChefName = new System.Windows.Forms.Label();
            this.picBoxChef = new System.Windows.Forms.PictureBox();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.comboOrderAndTable = new System.Windows.Forms.ComboBox();
            this.lblMenuToCook = new System.Windows.Forms.Label();
            this.panelMenuToCook = new System.Windows.Forms.Panel();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.timerShowBtnConfirmChanges = new System.Windows.Forms.Timer(this.components);
            this.panelNavBar.SuspendLayout();
            this.panelChef.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChef)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(83)))), ((int)(((byte)(32)))));
            this.panelNavBar.Controls.Add(this.panelChef);
            resources.ApplyResources(this.panelNavBar, "panelNavBar");
            this.panelNavBar.Name = "panelNavBar";
            // 
            // panelChef
            // 
            this.panelChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.panelChef.Controls.Add(this.lblChefEmail);
            this.panelChef.Controls.Add(this.lblChefName);
            this.panelChef.Controls.Add(this.picBoxChef);
            this.panelChef.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.panelChef, "panelChef");
            this.panelChef.Name = "panelChef";
            // 
            // lblChefEmail
            // 
            resources.ApplyResources(this.lblChefEmail, "lblChefEmail");
            this.lblChefEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChefEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblChefEmail.Name = "lblChefEmail";
            this.lblChefEmail.Click += new System.EventHandler(this.lblChefEmail_Click);
            // 
            // lblChefName
            // 
            resources.ApplyResources(this.lblChefName, "lblChefName");
            this.lblChefName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChefName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblChefName.Name = "lblChefName";
            this.lblChefName.Click += new System.EventHandler(this.lblChefName_Click);
            // 
            // picBoxChef
            // 
            this.picBoxChef.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.picBoxChef, "picBoxChef");
            this.picBoxChef.Name = "picBoxChef";
            this.picBoxChef.TabStop = false;
            this.picBoxChef.Click += new System.EventHandler(this.picBoxChef_Click);
            // 
            // lblTableNo
            // 
            resources.ApplyResources(this.lblTableNo, "lblTableNo");
            this.lblTableNo.Name = "lblTableNo";
            // 
            // comboOrderAndTable
            // 
            this.comboOrderAndTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderAndTable.FormattingEnabled = true;
            resources.ApplyResources(this.comboOrderAndTable, "comboOrderAndTable");
            this.comboOrderAndTable.Name = "comboOrderAndTable";
            this.comboOrderAndTable.SelectedIndexChanged += new System.EventHandler(this.comboOrderAndTable_SelectedIndexChanged);
            // 
            // lblMenuToCook
            // 
            resources.ApplyResources(this.lblMenuToCook, "lblMenuToCook");
            this.lblMenuToCook.Name = "lblMenuToCook";
            // 
            // panelMenuToCook
            // 
            resources.ApplyResources(this.panelMenuToCook, "panelMenuToCook");
            this.panelMenuToCook.Name = "panelMenuToCook";
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            resources.ApplyResources(this.btnConfirmChanges, "btnConfirmChanges");
            this.btnConfirmChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // timerShowBtnConfirmChanges
            // 
            this.timerShowBtnConfirmChanges.Interval = 10;
            this.timerShowBtnConfirmChanges.Tick += new System.EventHandler(this.timerShowBtnConfirmChanges_Tick);
            // 
            // FormNavigationChef
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ControlBox = false;
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.panelMenuToCook);
            this.Controls.Add(this.comboOrderAndTable);
            this.Controls.Add(this.lblMenuToCook);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.panelNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNavigationChef";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavigationChef_FormClosed);
            this.Load += new System.EventHandler(this.FormNavigationChef_Load);
            this.panelNavBar.ResumeLayout(false);
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChef)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.Label lblChefEmail;
        private System.Windows.Forms.Label lblChefName;
        private System.Windows.Forms.PictureBox picBoxChef;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.ComboBox comboOrderAndTable;
        private System.Windows.Forms.Label lblMenuToCook;
        private System.Windows.Forms.Panel panelMenuToCook;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Timer timerShowBtnConfirmChanges;
    }
}