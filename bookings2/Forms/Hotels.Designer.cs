namespace bookings2.Forms
{
    partial class Hotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotels));
            this.hotelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citysightseeing_databaseDataSet1 = new bookings2.Citysightseeing_databaseDataSet1();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.EmpTableAdapter();
            this.hotelsTableAdapter = new bookings2.Citysightseeing_databaseDataSet1TableAdapters.HotelsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelsBindingSource
            // 
            this.hotelsBindingSource.DataMember = "Hotels";
            this.hotelsBindingSource.DataSource = this.citysightseeing_databaseDataSet1;
            // 
            // citysightseeing_databaseDataSet1
            // 
            this.citysightseeing_databaseDataSet1.DataSetName = "Citysightseeing_databaseDataSet1";
            this.citysightseeing_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Location = new System.Drawing.Point(13, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(453, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // A
            // 
            this.A.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.A.Location = new System.Drawing.Point(13, 33);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(18, 24);
            this.A.TabIndex = 3;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.orderBy);
            // 
            // B
            // 
            this.B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B.Location = new System.Drawing.Point(33, 33);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(18, 24);
            this.B.TabIndex = 4;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.orderBy);
            // 
            // C
            // 
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.C.Location = new System.Drawing.Point(53, 33);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(18, 24);
            this.C.TabIndex = 5;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.orderBy);
            // 
            // D
            // 
            this.D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.D.Location = new System.Drawing.Point(73, 33);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(18, 24);
            this.D.TabIndex = 6;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.orderBy);
            // 
            // E
            // 
            this.E.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.E.Location = new System.Drawing.Point(93, 33);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(18, 24);
            this.E.TabIndex = 7;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.orderBy);
            // 
            // F
            // 
            this.F.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.F.Location = new System.Drawing.Point(113, 33);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(18, 24);
            this.F.TabIndex = 8;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.orderBy);
            // 
            // G
            // 
            this.G.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.G.Location = new System.Drawing.Point(133, 33);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(18, 24);
            this.G.TabIndex = 9;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.orderBy);
            // 
            // H
            // 
            this.H.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.H.Location = new System.Drawing.Point(153, 33);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(18, 24);
            this.H.TabIndex = 10;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.orderBy);
            // 
            // I
            // 
            this.I.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.I.Location = new System.Drawing.Point(172, 33);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(18, 24);
            this.I.TabIndex = 11;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.orderBy);
            // 
            // J
            // 
            this.J.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.J.Location = new System.Drawing.Point(192, 33);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(18, 24);
            this.J.TabIndex = 12;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            this.J.Click += new System.EventHandler(this.orderBy);
            // 
            // K
            // 
            this.K.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.K.Location = new System.Drawing.Point(212, 33);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(18, 24);
            this.K.TabIndex = 13;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.orderBy);
            // 
            // L
            // 
            this.L.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L.Location = new System.Drawing.Point(232, 33);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(18, 24);
            this.L.TabIndex = 14;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.orderBy);
            // 
            // M
            // 
            this.M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.M.Location = new System.Drawing.Point(252, 33);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(18, 24);
            this.M.TabIndex = 15;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.orderBy);
            // 
            // N
            // 
            this.N.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.N.Location = new System.Drawing.Point(272, 33);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(18, 24);
            this.N.TabIndex = 16;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.orderBy);
            // 
            // O
            // 
            this.O.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.O.Location = new System.Drawing.Point(292, 33);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(18, 24);
            this.O.TabIndex = 17;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.orderBy);
            // 
            // P
            // 
            this.P.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.P.Location = new System.Drawing.Point(312, 33);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(18, 24);
            this.P.TabIndex = 18;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.orderBy);
            // 
            // Q
            // 
            this.Q.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Q.Location = new System.Drawing.Point(331, 33);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(18, 24);
            this.Q.TabIndex = 19;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.Click += new System.EventHandler(this.orderBy);
            // 
            // R
            // 
            this.R.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.R.Location = new System.Drawing.Point(351, 33);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(18, 24);
            this.R.TabIndex = 20;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.orderBy);
            // 
            // S
            // 
            this.S.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S.Location = new System.Drawing.Point(371, 33);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(18, 24);
            this.S.TabIndex = 21;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.orderBy);
            // 
            // T
            // 
            this.T.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.T.Location = new System.Drawing.Point(391, 33);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(18, 24);
            this.T.TabIndex = 22;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.orderBy);
            // 
            // U
            // 
            this.U.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.U.Location = new System.Drawing.Point(410, 33);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(18, 24);
            this.U.TabIndex = 23;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.orderBy);
            // 
            // V
            // 
            this.V.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.V.Location = new System.Drawing.Point(430, 33);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(18, 24);
            this.V.TabIndex = 24;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.orderBy);
            // 
            // W
            // 
            this.W.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.W.Location = new System.Drawing.Point(450, 33);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(18, 24);
            this.W.TabIndex = 25;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.orderBy);
            // 
            // X
            // 
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Location = new System.Drawing.Point(470, 33);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(18, 24);
            this.X.TabIndex = 26;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.orderBy);
            // 
            // Y
            // 
            this.Y.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Y.Location = new System.Drawing.Point(490, 33);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(18, 24);
            this.Y.TabIndex = 27;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.orderBy);
            // 
            // Z
            // 
            this.Z.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Z.Location = new System.Drawing.Point(510, 33);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(18, 24);
            this.Z.TabIndex = 28;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.orderBy);
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "Emp";
            this.empBindingSource.DataSource = this.citysightseeing_databaseDataSet1;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // hotelsTableAdapter
            // 
            this.hotelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelIDDataGridViewTextBoxColumn,
            this.hNameDataGridViewTextBoxColumn,
            this.hnumberDataGridViewTextBoxColumn,
            this.hEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 422);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            // 
            // hNameDataGridViewTextBoxColumn
            // 
            this.hNameDataGridViewTextBoxColumn.DataPropertyName = "H_Name";
            this.hNameDataGridViewTextBoxColumn.HeaderText = "H_Name";
            this.hNameDataGridViewTextBoxColumn.Name = "hNameDataGridViewTextBoxColumn";
            // 
            // hnumberDataGridViewTextBoxColumn
            // 
            this.hnumberDataGridViewTextBoxColumn.DataPropertyName = "H_number";
            this.hnumberDataGridViewTextBoxColumn.HeaderText = "H_number";
            this.hnumberDataGridViewTextBoxColumn.Name = "hnumberDataGridViewTextBoxColumn";
            // 
            // hEmailDataGridViewTextBoxColumn
            // 
            this.hEmailDataGridViewTextBoxColumn.DataPropertyName = "H_Email";
            this.hEmailDataGridViewTextBoxColumn.HeaderText = "H_Email";
            this.hEmailDataGridViewTextBoxColumn.Name = "hEmailDataGridViewTextBoxColumn";
            // 
            // hotelsBindingSource1
            // 
            this.hotelsBindingSource1.DataMember = "Hotels";
            this.hotelsBindingSource1.DataSource = this.citysightseeing_databaseDataSet1;
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.W);
            this.Controls.Add(this.V);
            this.Controls.Add(this.U);
            this.Controls.Add(this.T);
            this.Controls.Add(this.S);
            this.Controls.Add(this.R);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.P);
            this.Controls.Add(this.O);
            this.Controls.Add(this.N);
            this.Controls.Add(this.M);
            this.Controls.Add(this.L);
            this.Controls.Add(this.K);
            this.Controls.Add(this.J);
            this.Controls.Add(this.I);
            this.Controls.Add(this.H);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel/Partners list";
            this.Load += new System.EventHandler(this.Hotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citysightseeing_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button H;
        private System.Windows.Forms.Button I;
        private System.Windows.Forms.Button J;
        private System.Windows.Forms.Button K;
        private System.Windows.Forms.Button L;
        private System.Windows.Forms.Button M;
        private System.Windows.Forms.Button N;
        private System.Windows.Forms.Button O;
        private System.Windows.Forms.Button P;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button R;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button T;
        private System.Windows.Forms.Button U;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button Y;
        private System.Windows.Forms.Button Z;
        private Citysightseeing_databaseDataSet1 citysightseeing_databaseDataSet1;
        private System.Windows.Forms.BindingSource empBindingSource;
        private Citysightseeing_databaseDataSet1TableAdapters.EmpTableAdapter empTableAdapter;
        private System.Windows.Forms.BindingSource hotelsBindingSource;
        private Citysightseeing_databaseDataSet1TableAdapters.HotelsTableAdapter hotelsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hotelsBindingSource1;
    }
}