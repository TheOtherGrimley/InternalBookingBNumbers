using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace bookings2.Forms
{
    public partial class CreditSheet : Form
    {
        BaseMenu _owner;
        private string x;
        

        public CreditSheet(BaseMenu owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void btnBnumbers_Click(object sender, EventArgs e)
        {
            Hide();
            BaseMenu menu = new BaseMenu();
            menu.ShowDialog();
            menu = null;
            Show();

            this.Close();
        }

        private void CreditSheet_Load(object sender, EventArgs e)
        {
            cboOrderBy.Items.Add("Date");
            cboOrderBy.Items.Add("ID");
            cboOrderBy.Items.Add("Hotel ID");

            cboList.Items.Add("Office");
            cboList.Items.Add("Yard");

            cboListParse();
            cboOrderByParse();

            txtSearch.Visible = false;
            cboList.Visible = false;

            if (Forms.BaseMenu.empNumber == 18 || Forms.BaseMenu.empNumber == 4 || Forms.BaseMenu.empNumber == 8 || Forms.BaseMenu.empNumber == 2 || Forms.BaseMenu.empNumber == 1)
            {
                cboList.Visible = true;
            }
        }

        private void copyAlltoClipboard()
        {
            dgvDiary.SelectAll();
            DataObject dataObj = dgvDiary.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            xlWorkSheet.Columns.AutoFit();
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            AddCredit next = new AddCredit(this);
            next.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.creditTableAdapter1.Fill(this.citysightseeing_databaseDataSet1.Credit);
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboOrderByParse();
            if(txtSearch.Text != "" || dtpDate.Value.ToString() != "") {
                if (cboList.Text == "Office" || cboList.Text == "")
                {
                    switch (x)
                    {
                        case "CCID":
                            creditTableAdapter1.SearchByCCID(citysightseeing_databaseDataSet1.Credit, int.Parse(txtSearch.Text));
                            break;

                        case "Date_Taken":
                            creditTableAdapter1.SearchByDate(citysightseeing_databaseDataSet1.Credit, dtpDate.Value.Date);
                            break;

                        case "HotelID":
                            creditTableAdapter1.SearchByHotel(citysightseeing_databaseDataSet1.Credit, int.Parse(txtSearch.Text));
                            break;

                        default:
                            MessageBox.Show("Error 202");
                            break;
                    }
                }

                if(cboList.Text == "Yard")
                {
                    switch (x)
                    {
                        case "CCID":
                            yardCCTableAdapter.SearchByCCID(citysightseeing_databaseDataSet1.yardCC, int.Parse(txtSearch.Text));
                            break;

                        case "Date_Taken":
                            yardCCTableAdapter.SearchByDate(citysightseeing_databaseDataSet1.yardCC, dtpDate.Value.Date);
                            break;

                        case "HotelID":
                            yardCCTableAdapter.SearchByHotel(citysightseeing_databaseDataSet1.yardCC, int.Parse(txtSearch.Text));
                            break;

                        default:
                            MessageBox.Show("Error 202");
                            break;
                    }
                }
            }
        }

        private void cboOrderByParse()
        {
            switch (cboOrderBy.Text)
            {
                case "ID":
                    txtSearch.Visible = true;
                    dtpDate.Visible = false;
                    x = "CCID";
                    break;

                case "Date":
                    txtSearch.Visible = false;
                    dtpDate.Visible = true;
                    x = "Date_Taken";
                    break;

                case "Hotel ID":
                    txtSearch.Visible = true;
                    dtpDate.Visible = false;
                    x = "HotelID";
                    break;

                default:
                    MessageBox.Show("Error 201");
                    break;
            }
        }

        private void cboListParse()
        {
            switch (cboList.Text)
            {
                case "Office":
                    dgvDiary.DataSource = creditBindingSource2;
                    this.creditTableAdapter1.Fill(this.citysightseeing_databaseDataSet1.Credit);
                    break;

                case "Yard":
                    dgvDiary.DataSource = yardCCBindingSource;
                    this.yardCCTableAdapter.Fill(citysightseeing_databaseDataSet1.yardCC);
                    break;

                default:
                    MessageBox.Show("Error 201");
                    break;
            }
        }

        public void refreshDgv()
        {
            try
            {
                if (cboList.Text == "Office")
                {
                    this.creditTableAdapter1.Fill(this.citysightseeing_databaseDataSet1.Credit);
                }

                if (cboList.Text == "Yard")
                {
                    this.yardCCTableAdapter.Fill(this.citysightseeing_databaseDataSet1.yardCC);
                }
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void cboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOrderByParse();
            txtSearch.Text = "";

            if(x == "HotelID")
            {
                txtSearch.ReadOnly = true;
                txtSearch.DoubleClick += new System.EventHandler(this.openHotels);
            }

            else
            {
                txtSearch.ReadOnly = false;
                txtSearch.DoubleClick -= new System.EventHandler(this.openHotels);
            }
        }

        private void hotelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotels next = new Hotels();
            next.ShowDialog();
        }

        private void hotelSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotels next = new Hotels();
            next.ShowDialog();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.ShowDialog();
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusTrack track = new BusTrack();
            track.ShowDialog();
        }

        private void cboList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboListParse();
        }

        private void openHotels(object sender, EventArgs e)
        {
            Hotels next = new Hotels(this);
            next.ShowDialog();
        }

        public void hotelSelection(int hotelID)
        {
            txtSearch.Text = hotelID.ToString();
        }
    }
}
