namespace bookings2.Forms
{
    partial class CreditSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditSheet));
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDiary = new System.Windows.Forms.DataGridView();
            this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeingdatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeing_databaseDataSet1 = new bookings2.Citysightseeing_databaseDataSet1();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.btnNewEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBnumbers = new System.Windows.Forms.ToolStripMenuItem();
            this.collectedDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboOrderBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.yardCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboList = new System.Windows.Forms.ComboBox();
            this.creditTableAdapter1 = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.CreditTableAdapter();
            this.yardCCTableAdapter = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.yardCCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeingdatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardCCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(423, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 20);
            this.button3.TabIndex = 30;
            this.button3.Text = "List all Credit cards";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(276, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDiary
            // 
            this.dgvDiary.AllowUserToAddRows = false;
            this.dgvDiary.AllowUserToDeleteRows = false;
            this.dgvDiary.AutoGenerateColumns = false;
            this.dgvDiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTakenDataGridViewTextBoxColumn,
            this.H_name,
            this.tourIDDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.empIDDataGridViewTextBoxColumn});
            this.dgvDiary.DataSource = this.creditBindingSource2;
            this.dgvDiary.Location = new System.Drawing.Point(12, 58);
            this.dgvDiary.Name = "dgvDiary";
            this.dgvDiary.RowHeadersVisible = false;
            this.dgvDiary.Size = new System.Drawing.Size(560, 342);
            this.dgvDiary.TabIndex = 20;
            // 
            // dateTakenDataGridViewTextBoxColumn
            // 
            this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "Date_Taken";
            this.dateTakenDataGridViewTextBoxColumn.HeaderText = "Date_Taken";
            this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
            this.dateTakenDataGridViewTextBoxColumn.Width = 73;
            // 
            // H_name
            // 
            this.H_name.DataPropertyName = "H_name";
            this.H_name.HeaderText = "H_name";
            this.H_name.Name = "H_name";
            this.H_name.Width = 150;
            // 
            // tourIDDataGridViewTextBoxColumn
            // 
            this.tourIDDataGridViewTextBoxColumn.DataPropertyName = "TourID";
            this.tourIDDataGridViewTextBoxColumn.HeaderText = "TourID";
            this.tourIDDataGridViewTextBoxColumn.Name = "tourIDDataGridViewTextBoxColumn";
            this.tourIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "Pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "Pax";
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            this.paxDataGridViewTextBoxColumn.Width = 50;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.Width = 60;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // creditBindingSource2
            // 
            this.creditBindingSource2.DataMember = "Credit";
            this.creditBindingSource2.DataSource = this.citysightseeingdatabaseDataSet1BindingSource;
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
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(139, 31);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(131, 20);
            this.dtpDate.TabIndex = 19;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewEntry,
            this.btnExcel,
            this.btnBnumbers,
            this.collectedDataToolStripMenuItem,
            this.trackerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(584, 24);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(73, 20);
            this.btnNewEntry.Text = "New entry";
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(122, 20);
            this.btnExcel.Text = "Export Data to excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBnumbers
            // 
            this.btnBnumbers.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBnumbers.Name = "btnBnumbers";
            this.btnBnumbers.Size = new System.Drawing.Size(75, 20);
            this.btnBnumbers.Text = "BNumbers";
            this.btnBnumbers.Click += new System.EventHandler(this.btnBnumbers_Click);
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
            // cboOrderBy
            // 
            this.cboOrderBy.FormattingEnabled = true;
            this.cboOrderBy.Location = new System.Drawing.Point(12, 31);
            this.cboOrderBy.Name = "cboOrderBy";
            this.cboOrderBy.Size = new System.Drawing.Size(121, 21);
            this.cboOrderBy.TabIndex = 31;
            this.cboOrderBy.Text = "Date";
            this.cboOrderBy.SelectedIndexChanged += new System.EventHandler(this.cboOrderBy_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 32;
            // 
            // yardCCBindingSource
            // 
            this.yardCCBindingSource.DataMember = "yardCC";
            this.yardCCBindingSource.DataSource = this.citysightseeingdatabaseDataSet1BindingSource;
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(388, 3);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(121, 21);
            this.cboList.TabIndex = 33;
            this.cboList.Text = "Office";
            this.cboList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // creditTableAdapter1
            // 
            this.creditTableAdapter1.ClearBeforeFill = true;
            // 
            // yardCCTableAdapter
            // 
            this.yardCCTableAdapter.ClearBeforeFill = true;
            // 
            // CreditSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 408);
            this.Controls.Add(this.cboList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboOrderBy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDiary);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit card sheet";
            this.Load += new System.EventHandler(this.CreditSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeingdatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yardCCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvDiary;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btnNewEntry;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripMenuItem btnBnumbers;
        private System.Windows.Forms.BindingSource citysightseeingdatabaseDataSet1BindingSource;
        private Citysightseeing_databaseDataSet1 citysightseeing_databaseDataSet1;
        private System.Windows.Forms.BindingSource creditBindingSource2;
        private Citysightseeing_databaseDataSet1TableAdapters.CreditTableAdapter creditTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboOrderBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem collectedDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackerToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource yardCCBindingSource;
        private Citysightseeing_databaseDataSet1TableAdapters.yardCCTableAdapter yardCCTableAdapter;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn H_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
    }
}