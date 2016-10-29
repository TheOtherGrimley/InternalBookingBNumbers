namespace bookings2.Forms
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeing_databaseDataSet1 = new bookings2.Citysightseeing_databaseDataSet1();
            this.empTableAdapter = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.EmpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.eEmailDataGridViewTextBoxColumn,
            this.enumberDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.Admin});
            this.dataGridView1.DataSource = this.empBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(563, 465);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "BCS ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.empIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "EName";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            // 
            // eEmailDataGridViewTextBoxColumn
            // 
            this.eEmailDataGridViewTextBoxColumn.DataPropertyName = "E_Email";
            this.eEmailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eEmailDataGridViewTextBoxColumn.Name = "eEmailDataGridViewTextBoxColumn";
            // 
            // enumberDataGridViewTextBoxColumn
            // 
            this.enumberDataGridViewTextBoxColumn.DataPropertyName = "E_number";
            this.enumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.enumberDataGridViewTextBoxColumn.Name = "enumberDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Access Password";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Admin";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "Emp";
            this.empBindingSource.DataSource = this.citysightseeing_databaseDataSet1;
            // 
            // citysightseeing_databaseDataSet1
            // 
            this.citysightseeing_databaseDataSet1.DataSetName = "Citysightseeing_databaseDataSet1";
            this.citysightseeing_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 489);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employees";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Citysightseeing_databaseDataSet1 citysightseeing_databaseDataSet1;
        private System.Windows.Forms.BindingSource empBindingSource;
        private Citysightseeing_databaseDataSet1TableAdapters.EmpTableAdapter empTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
    }
}