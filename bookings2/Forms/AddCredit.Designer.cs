namespace bookings2.Forms
{
    partial class AddCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCredit));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.cboTours = new System.Windows.Forms.ComboBox();
            this.cboCCType = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.dtpBookedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(178, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Pax:";
            // 
            // txtPax
            // 
            this.txtPax.BackColor = System.Drawing.Color.White;
            this.txtPax.Location = new System.Drawing.Point(125, 91);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(171, 20);
            this.txtPax.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "Booked from:";
            // 
            // txtHotel
            // 
            this.txtHotel.BackColor = System.Drawing.Color.White;
            this.txtHotel.Location = new System.Drawing.Point(125, 65);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.ReadOnly = true;
            this.txtHotel.Size = new System.Drawing.Size(171, 20);
            this.txtHotel.TabIndex = 2;
            this.txtHotel.DoubleClick += new System.EventHandler(this.SelectHotel);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 128;
            this.label17.Text = "Tour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 136;
            this.label4.Text = "Rate:";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.Location = new System.Drawing.Point(125, 117);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(171, 20);
            this.txtRate.TabIndex = 4;
            // 
            // cboTours
            // 
            this.cboTours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTours.Location = new System.Drawing.Point(125, 12);
            this.cboTours.Name = "cboTours";
            this.cboTours.Size = new System.Drawing.Size(171, 21);
            this.cboTours.TabIndex = 1;
            // 
            // cboCCType
            // 
            this.cboCCType.FormattingEnabled = true;
            this.cboCCType.Location = new System.Drawing.Point(125, 143);
            this.cboCCType.Name = "cboCCType";
            this.cboCCType.Size = new System.Drawing.Size(171, 21);
            this.cboCCType.TabIndex = 5;
            this.cboCCType.Text = "Office";
            this.cboCCType.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(49, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(68, 13);
            this.lblLocation.TabIndex = 141;
            this.lblLocation.Text = "CC Location:";
            this.lblLocation.Visible = false;
            // 
            // dtpBookedDate
            // 
            this.dtpBookedDate.Location = new System.Drawing.Point(125, 39);
            this.dtpBookedDate.Name = "dtpBookedDate";
            this.dtpBookedDate.Size = new System.Drawing.Size(171, 20);
            this.dtpBookedDate.TabIndex = 142;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Date taken:";
            // 
            // AddCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBookedDate);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cboCCType);
            this.Controls.Add(this.cboTours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.label17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new CC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCredit_FormClosed);
            this.Load += new System.EventHandler(this.AddCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.ComboBox cboTours;
        private System.Windows.Forms.ComboBox cboCCType;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.DateTimePicker dtpBookedDate;
        private System.Windows.Forms.Label label3;
    }
}