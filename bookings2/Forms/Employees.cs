using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookings2.Forms
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        bool admin;

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citysightseeing_databaseDataSet1.Emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.citysightseeing_databaseDataSet1.Emp);

            int currentID = Forms.BaseMenu.empNumber;
            bool admin = DataReq.checkAdmin(currentID);

            if(admin == false)
            {
                Admin.Visible = false;
                passDataGridViewTextBoxColumn.Visible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }

            if (admin == true)
            {
                Admin.Visible = true;
                passDataGridViewTextBoxColumn.Visible = true;
                dataGridView1.ReadOnly = false;
                dataGridView1.AllowUserToAddRows = true;
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (DataReq.checkAdmin(Forms.BaseMenu.empNumber) == true)
                {
                    empTableAdapter.Update(citysightseeing_databaseDataSet1.Emp);
                }
            }

            catch(Exception ex) { MessageBox.Show("Error 601, nothing to update"); }
        }
    }
}
