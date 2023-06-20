namespace GzKitchen
{
    partial class FormManageTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelButtonSaveCancel = new System.Windows.Forms.Panel();
            this.picBoxPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panelButtonSaveCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // dgvMenu
            // 
            resources.ApplyResources(this.dgvMenu, "dgvMenu");
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenu.EnableHeadersVisualStyles = false;
            this.dgvMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowTemplate.Height = 40;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellClick);
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.txtName.Name = "txtName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(166)))), ((int)(((byte)(155)))));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelButtonSaveCancel
            // 
            resources.ApplyResources(this.panelButtonSaveCancel, "panelButtonSaveCancel");
            this.panelButtonSaveCancel.Controls.Add(this.btnSave);
            this.panelButtonSaveCancel.Controls.Add(this.btnCancel);
            this.panelButtonSaveCancel.Name = "panelButtonSaveCancel";
            // 
            // picBoxPicture
            // 
            resources.ApplyResources(this.picBoxPicture, "picBoxPicture");
            this.picBoxPicture.Name = "picBoxPicture";
            this.picBoxPicture.TabStop = false;
            this.picBoxPicture.Click += new System.EventHandler(this.picBoxPicture_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormManageTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxPicture);
            this.Controls.Add(this.panelButtonSaveCancel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.lblName);
            this.Name = "FormManageTable";
            this.Load += new System.EventHandler(this.FormManageMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panelButtonSaveCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelButtonSaveCancel;
        private System.Windows.Forms.PictureBox picBoxPicture;
        private System.Windows.Forms.Label label1;
    }
}
