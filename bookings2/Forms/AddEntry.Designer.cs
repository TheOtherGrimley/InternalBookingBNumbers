namespace bookings2.Forms
{
    partial class AddEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntry));
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtMcCombs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtPax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPickup = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(114, 230);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(171, 21);
            this.cboType.TabIndex = 8;
            this.cboType.Text = "Please Select";
            // 
            // txtMcCombs
            // 
            this.txtMcCombs.BackColor = System.Drawing.Color.White;
            this.txtMcCombs.Location = new System.Drawing.Point(114, 257);
            this.txtMcCombs.Name = "txtMcCombs";
            this.txtMcCombs.Size = new System.Drawing.Size(171, 20);
            this.txtMcCombs.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 126;
            this.label1.Text = "McCombs Ref:";
            // 
            // lblRefNo
            // 
            this.lblRefNo.AutoSize = true;
            this.lblRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblRefNo.Location = new System.Drawing.Point(155, 13);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(130, 17);
            this.lblRefNo.TabIndex = 125;
            this.lblRefNo.Text = "BNUMBER HERE";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(66, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(73, 13);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 117;
            this.label18.Text = "B-Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 124;
            this.label11.Text = "Tour type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(73, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 118;
            this.label17.Text = "Pax:";
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(114, 205);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(171, 20);
            this.txtPayment.TabIndex = 7;
            // 
            // txtPax
            // 
            this.txtPax.BackColor = System.Drawing.Color.White;
            this.txtPax.Location = new System.Drawing.Point(114, 47);
            this.txtPax.Name = "txtPax";
            this.txtPax.Size = new System.Drawing.Size(171, 20);
            this.txtPax.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 123;
            this.label12.Text = "Payment type:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 119;
            this.label16.Text = "Name:";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.Location = new System.Drawing.Point(114, 179);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(171, 20);
            this.txtRate.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(114, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 122;
            this.label13.Text = "Rate:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 120;
            this.label15.Text = "Pickup:";
            // 
            // txtPickup
            // 
            this.txtPickup.BackColor = System.Drawing.Color.White;
            this.txtPickup.Location = new System.Drawing.Point(114, 99);
            this.txtPickup.Name = "txtPickup";
            this.txtPickup.Size = new System.Drawing.Size(171, 20);
            this.txtPickup.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 121;
            this.label14.Text = "Travel Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(114, 154);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(171, 20);
            this.dtpDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 128;
            this.label2.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(114, 285);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(171, 20);
            this.txtNotes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 131;
            this.label3.Text = "Hotel booked from:";
            // 
            // txtHotel
            // 
            this.txtHotel.BackColor = System.Drawing.Color.White;
            this.txtHotel.Location = new System.Drawing.Point(114, 125);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.ReadOnly = true;
            this.txtHotel.Size = new System.Drawing.Size(171, 20);
            this.txtHotel.TabIndex = 4;
            this.txtHotel.DoubleClick += new System.EventHandler(this.openHotels);
            // 
            // AddEntry
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHotel);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtMcCombs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRefNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtPax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPickup);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Bnumber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEntry_FormClosed);
            this.Load += new System.EventHandler(this.AddEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtMcCombs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRefNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtPax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPickup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotel;
    }
}