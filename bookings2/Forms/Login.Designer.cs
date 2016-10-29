namespace bookings2.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.txtEmpPass = new System.Windows.Forms.TextBox();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblEmpId
            // 
            resources.ApplyResources(this.lblEmpId, "lblEmpId");
            this.lblEmpId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmpId.Name = "lblEmpId";
            // 
            // txtEmpPass
            // 
            resources.ApplyResources(this.txtEmpPass, "txtEmpPass");
            this.txtEmpPass.Name = "txtEmpPass";
            // 
            // txtEmpNumber
            // 
            resources.ApplyResources(this.txtEmpNumber, "txtEmpNumber");
            this.txtEmpNumber.Name = "txtEmpNumber";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.txtEmpPass);
            this.Controls.Add(this.txtEmpNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.TextBox txtEmpPass;
        private System.Windows.Forms.TextBox txtEmpNumber;
    }
}