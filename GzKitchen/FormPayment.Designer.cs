namespace GzKitchen
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.lblTableNo = new System.Windows.Forms.Label();
            this.btnProceedPayment = new System.Windows.Forms.Button();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.txtTotalPayment = new System.Windows.Forms.Label();
            this.lblAmountTendered = new System.Windows.Forms.Label();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableNo
            // 
            resources.ApplyResources(this.lblTableNo, "lblTableNo");
            this.lblTableNo.Name = "lblTableNo";
            // 
            // btnProceedPayment
            // 
            resources.ApplyResources(this.btnProceedPayment, "btnProceedPayment");
            this.btnProceedPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(209)))), ((int)(((byte)(42)))));
            this.btnProceedPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnProceedPayment.Name = "btnProceedPayment";
            this.btnProceedPayment.UseVisualStyleBackColor = false;
            this.btnProceedPayment.Click += new System.EventHandler(this.btnProceedPayment_Click);
            // 
            // lblTotalPayment
            // 
            resources.ApplyResources(this.lblTotalPayment, "lblTotalPayment");
            this.lblTotalPayment.Name = "lblTotalPayment";
            // 
            // txtTableNo
            // 
            resources.ApplyResources(this.txtTableNo, "txtTableNo");
            this.txtTableNo.Name = "txtTableNo";
            // 
            // txtTotalPayment
            // 
            resources.ApplyResources(this.txtTotalPayment, "txtTotalPayment");
            this.txtTotalPayment.Name = "txtTotalPayment";
            // 
            // lblAmountTendered
            // 
            resources.ApplyResources(this.lblAmountTendered, "lblAmountTendered");
            this.lblAmountTendered.Name = "lblAmountTendered";
            // 
            // txtAmountTendered
            // 
            resources.ApplyResources(this.txtAmountTendered, "txtAmountTendered");
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmountTendered_KeyUp);
            // 
            // lblChange
            // 
            resources.ApplyResources(this.lblChange, "lblChange");
            this.lblChange.Name = "lblChange";
            // 
            // txtChange
            // 
            resources.ApplyResources(this.txtChange, "txtChange");
            this.txtChange.Name = "txtChange";
            // 
            // FormPayment
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ControlBox = false;
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.lblAmountTendered);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.btnProceedPayment);
            this.Controls.Add(this.txtAmountTendered);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lblTableNo);
            this.Name = "FormPayment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPayment_FormClosed);
            this.Load += new System.EventHandler(this.FormPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Button btnProceedPayment;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.Label txtTotalPayment;
        private System.Windows.Forms.Label lblAmountTendered;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label txtChange;
    }
}