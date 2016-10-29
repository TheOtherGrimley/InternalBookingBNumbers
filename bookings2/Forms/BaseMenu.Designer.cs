namespace bookings2.Forms
{
    partial class BaseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMenu));
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.bNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcCombsRefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeingdatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeing_databaseDataSet1 = new bookings2.Citysightseeing_databaseDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.collectedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpLowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHighDate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cboOrderBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bNumbersTableAdapter = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.BNumbersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeingdatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(211, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(131, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // dgvDiary
            // 
            this.dgvDiary.AllowUserToAddRows = false;
            this.dgvDiary.AllowUserToDeleteRows = false;
            this.dgvDiary.AllowUserToResizeColumns = false;
            this.dgvDiary.AllowUserToResizeRows = false;
            this.dgvDiary.AutoGenerateColumns = false;
            this.dgvDiary.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDiary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bNumberDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.pickupDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn,
            this.bookedDateDataGridViewTextBoxColumn,
            this.travelDateDataGridViewTextBoxColumn,
            this.mcCombsRefDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.tourIDDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvDiary.DataSource = this.bNumbersBindingSource;
            this.dgvDiary.Location = new System.Drawing.Point(12, 55);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.Size = new System.Drawing.Size(955, 342);
            this.dgvDiary.TabIndex = 5;
            this.dgvDiary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiary_CellEndEdit);
            this.dgvDiary.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiary_CellEndEdit);
            // 
            // bNumberDataGridViewTextBoxColumn
            // 
            this.bNumberDataGridViewTextBoxColumn.DataPropertyName = "BNumber";
            this.bNumberDataGridViewTextBoxColumn.HeaderText = "BNumber";
            this.bNumberDataGridViewTextBoxColumn.Name = "bNumberDataGridViewTextBoxColumn";
            this.bNumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "Pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "Pax";
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            this.paxDataGridViewTextBoxColumn.Width = 40;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // pickupDataGridViewTextBoxColumn
            // 
            this.pickupDataGridViewTextBoxColumn.DataPropertyName = "Pickup";
            this.pickupDataGridViewTextBoxColumn.HeaderText = "Pickup";
            this.pickupDataGridViewTextBoxColumn.Name = "pickupDataGridViewTextBoxColumn";
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // bookedDateDataGridViewTextBoxColumn
            // 
            this.bookedDateDataGridViewTextBoxColumn.DataPropertyName = "BookedDate";
            this.bookedDateDataGridViewTextBoxColumn.HeaderText = "BookedDate";
            this.bookedDateDataGridViewTextBoxColumn.Name = "bookedDateDataGridViewTextBoxColumn";
            this.bookedDateDataGridViewTextBoxColumn.Width = 73;
            // 
            // travelDateDataGridViewTextBoxColumn
            // 
            this.travelDateDataGridViewTextBoxColumn.DataPropertyName = "TravelDate";
            this.travelDateDataGridViewTextBoxColumn.HeaderText = "TravelDate";
            this.travelDateDataGridViewTextBoxColumn.Name = "travelDateDataGridViewTextBoxColumn";
            this.travelDateDataGridViewTextBoxColumn.Width = 73;
            // 
            // mcCombsRefDataGridViewTextBoxColumn
            // 
            this.mcCombsRefDataGridViewTextBoxColumn.DataPropertyName = "McCombsRef";
            this.mcCombsRefDataGridViewTextBoxColumn.HeaderText = "McCombsRef";
            this.mcCombsRefDataGridViewTextBoxColumn.Name = "mcCombsRefDataGridViewTextBoxColumn";
            this.mcCombsRefDataGridViewTextBoxColumn.Width = 80;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 60;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "TourID";
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            this.tourIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // bNumbersBindingSource
            // 
            this.bNumbersBindingSource.DataMember = "BNumbers";
            this.bNumbersBindingSource.DataSource = this.citysightseeingdatabaseDataSet1BindingSource;
            // 
            // citysightseeingdatabaseDataSet1BindingSource
            // 
            this.citysightseeingdatabaseDataSet1BindingSource.DataSource = this.citysightseeing_databaseDataSet1;
            this.citysightseeingdatabaseDataSet1BindingSource.Position = 0;
            // 
            // citysightseeing_databaseDataSet1
            // 
            this.citysightseeing_databaseDataSet1.DataSetName = "Citysightseeing_databaseDataSet1";
            this.citysightseeing_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(348, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.exportDataToExcelToolStripMenuItem,
            this.btnCredit,
            this.collectedDataToolStripMenuItem,
            this.trackerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip2.Size = new System.Drawing.Size(978, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.newEntryToolStripMenuItem.Text = "New entry";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // exportDataToExcelToolStripMenuItem
            // 
            this.exportDataToExcelToolStripMenuItem.Name = "exportDataToExcelToolStripMenuItem";
            this.exportDataToExcelToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.exportDataToExcelToolStripMenuItem.Text = "Export Data to excel";
            this.exportDataToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportDataToExcelToolStripMenuItem_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCredit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCredit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(110, 20);
            this.btnCredit.Text = "Credit Card sheet";
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // collectedDataToolStripMenuItem
            // 
            this.collectedDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelSheetToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.collectedDataToolStripMenuItem.Name = "collectedDataToolStripMenuItem";
            this.collectedDataToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.collectedDataToolStripMenuItem.Text = "Collected data";
            // 
            // hotelSheetToolStripMenuItem
            // 
            this.hotelSheetToolStripMenuItem.Name = "hotelSheetToolStripMenuItem";
            this.hotelSheetToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.hotelSheetToolStripMenuItem.Text = "Hotel Sheet";
            this.hotelSheetToolStripMenuItem.Click += new System.EventHandler(this.hotelSheetToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // trackerToolStripMenuItem
            // 
            this.trackerToolStripMenuItem.Name = "trackerToolStripMenuItem";
            this.trackerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.trackerToolStripMenuItem.Text = "Tracker";
            this.trackerToolStripMenuItem.Click += new System.EventHandler(this.trackerToolStripMenuItem_Click);
            // 
            // dtpLowDate
            // 
            this.dtpLowDate.Location = new System.Drawing.Point(435, 27);
            this.dtpLowDate.Name = "dtpLowDate";
            this.dtpLowDate.Size = new System.Drawing.Size(133, 20);
            this.dtpLowDate.TabIndex = 8;
            // 
            // dtpHighDate
            // 
            this.dtpHighDate.Location = new System.Drawing.Point(574, 27);
            this.dtpHighDate.Name = "dtpHighDate";
            this.dtpHighDate.Size = new System.Drawing.Size(137, 20);
            this.dtpHighDate.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(717, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "|";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(818, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "List all B-Numbers";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cboOrderBy
            // 
            this.cboOrderBy.FormattingEnabled = true;
            this.cboOrderBy.Location = new System.Drawing.Point(40, 28);
            this.cboOrderBy.Name = "cboOrderBy";
            this.cboOrderBy.Size = new System.Drawing.Size(157, 21);
            this.cboOrderBy.TabIndex = 16;
            this.cboOrderBy.Text = "Travel Date";
            this.cboOrderBy.SelectedIndexChanged += new System.EventHandler(this.cboOrderBy_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(211, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(131, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // bNumbersTableAdapter
            // 
            this.bNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 409);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboOrderBy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpHighDate);
            this.Controls.Add(this.dtpLowDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "BaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bnumbers List";
            this.Load += new System.EventHandler(this.BaseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeingdatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        public System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpLowDate;
        private System.Windows.Forms.DateTimePicker dtpHighDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem exportDataToExcelToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboOrderBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem btnCredit;
        private System.Windows.Forms.ToolStripMenuItem collectedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.BindingSource citysightseeingdatabaseDataSet1BindingSource;
        private Citysightseeing_databaseDataSet1 citysightseeing_databaseDataSet1;
        private System.Windows.Forms.BindingSource bNumbersBindingSource;
        private Citysightseeing_databaseDataSet1TableAdapters.BNumbersTableAdapter bNumbersTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem trackerToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pickupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcCombsRefDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}