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
    public partial class Hotels : Form
    {
        AddEntry ParentFormBnumber;
        AddCredit ParentFormCredit;
        CreditSheet ParentFormCreditSheet;
        BaseMenu ParentFormBaseMenu;
        public Hotels()
        {
            InitializeComponent();
        }

        public Hotels(AddEntry owner)
        {
            InitializeComponent();
            ParentFormBnumber = owner;
        }

        public Hotels(AddCredit owner)
        {
            InitializeComponent();
            ParentFormCredit = owner;
        }

        public Hotels(CreditSheet owner)
        {
            InitializeComponent();
            ParentFormCreditSheet = owner;
        }

        public Hotels(BaseMenu owner)
        {
            InitializeComponent();
            ParentFormBaseMenu = owner;
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citysightseeing_databaseDataSet1.Hotels' table. You can move, or remove it, as needed.
            this.hotelsTableAdapter.Fill(this.citysightseeing_databaseDataSet1.Hotels);

            
            hotelIDDataGridViewTextBoxColumn.HeaderText = "BCS ID";
            hotelIDDataGridViewTextBoxColumn.Width = 50;
            hotelIDDataGridViewTextBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            hNameDataGridViewTextBoxColumn.HeaderText = "Hotel Name";
            hNameDataGridViewTextBoxColumn.Width = 172;

            hnumberDataGridViewTextBoxColumn.HeaderText = "Phone number";
            hnumberDataGridViewTextBoxColumn.Width = 80;


            hEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            hEmailDataGridViewTextBoxColumn.Width = 190;
        }
        
        public void orderBy(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            string orderBy = currentButton.Text;

            this.hotelsTableAdapter.OrderBy(this.citysightseeing_databaseDataSet1.Hotels, orderBy);

        }

        private void A_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

            if (ParentFormBnumber != null)
            {
                ParentFormBnumber.hotelSelection(Convert.ToInt32(selectedRow.Cells[0].Value));

                this.Hide();
                this.Close();
            }

            if (ParentFormCredit != null)
            {
                ParentFormCredit.hotelSelection(Convert.ToInt32(selectedRow.Cells[0].Value));

                this.Hide();
                this.Close();
            }

            if (ParentFormCreditSheet != null)
            {
                ParentFormCreditSheet.hotelSelection(Convert.ToInt32(selectedRow.Cells[0].Value));

                this.Hide();
                this.Close();
            }

            if(ParentFormBaseMenu != null)
            {
                ParentFormBaseMenu.hotelSelection(Convert.ToInt32(selectedRow.Cells[0].Value));

                this.Hide();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddHotel next = new AddHotel();
            next.ShowDialog();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.hotelsBindingSource.EndEdit();
            hotelsTableAdapter.Update(citysightseeing_databaseDataSet1.Hotels);
        }
    }
}
