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
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
        }

        public static int empNumber;
        private string x;

        private void BaseMenu_Load(object sender, EventArgs e)
        {
            this.bNumbersTableAdapter.Fill(this.citysightseeing_databaseDataSet1.BNumbers);

            dgvDiary.AutoGenerateColumns = true;

            cboOrderBy.Items.Add("B-Number");
            cboOrderBy.Items.Add("Name");
            cboOrderBy.Items.Add("Booked Date");
            cboOrderBy.Items.Add("Travel Date");
            cboOrderBy.Items.Add("Employee ID");
            cboOrderBy.Items.Add("Hotel ID");

            cboOrderByParse();

            txtSearch.Visible = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            cboOrderByParse();
            
            switch (x)
            {
                case "bnumber":
                    bNumbersTableAdapter.SearchByBnumber(citysightseeing_databaseDataSet1.BNumbers, int.Parse(txtSearch.Text));
                    break;

                case "CustomerName":
                    bNumbersTableAdapter.SearchByName(citysightseeing_databaseDataSet1.BNumbers, txtSearch.Text);
                    break;

                case "bookedDate":
                    bNumbersTableAdapter.SearchByBookedDate(citysightseeing_databaseDataSet1.BNumbers, dtpDate.Value.Date);
                    break;

                case "TravelDate":
                    bNumbersTableAdapter.SearchByTravelDate(citysightseeing_databaseDataSet1.BNumbers, dtpDate.Value.Date);
                    break;

                case "EmpID":
                    bNumbersTableAdapter.SearchByEmpID(citysightseeing_databaseDataSet1.BNumbers, int.Parse(txtSearch.Text));
                    break;

                case "HotelID":
                    bNumbersTableAdapter.SearchByHotel(citysightseeing_databaseDataSet1.BNumbers, int.Parse(txtSearch.Text));
                    break;

                default:
                    MessageBox.Show("Error 202");
                    break;
            }
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntry nextScreen = new AddEntry(this);
            nextScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.bNumbersTableAdapter.FillBetween(this.citysightseeing_databaseDataSet1.BNumbers, dtpLowDate.Value.Date, dtpHighDate.Value.Date);
            }

            catch (Exception ex) { MessageBox.Show("" + ex);  }
        }

        private void copyAlltoClipboard()
        {
            dgvDiary.SelectAll();
            DataObject dataObj = dgvDiary.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void exportDataToExcelToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.bNumbersTableAdapter.Fill(this.citysightseeing_databaseDataSet1.BNumbers);
            }
            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void cboOrderByParse()
        {
            switch (cboOrderBy.Text)
            {
                case "B-Number":
                    txtSearch.Visible = true;
                    dtpDate.Visible = false;
                    x = "bnumber";
                    break;

                case "Name":
                    txtSearch.Visible = true;
                    dtpDate.Visible = false;
                    x = "CustomerName";
                    break;

                case "Booked Date":
                    txtSearch.Visible = false;
                    dtpDate.Visible = true;
                    x = "bookedDate";
                    break;

                case "Travel Date":
                    txtSearch.Visible = false;
                    dtpDate.Visible = true;
                    x = "TravelDate";
                    break;

                case "Employee ID":
                    txtSearch.Visible = true;
                    dtpDate.Visible = false;
                    x = "EmpID";
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

        private void cboOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboOrderByParse();
            txtSearch.Text = "";

            if (x == "HotelID")
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

        private void dgvDiary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bNumbersTableAdapter.Update(citysightseeing_databaseDataSet1.BNumbers);
            }

            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        public void refreshDgv()
        {
            try
            {
                this.bNumbersTableAdapter.Fill(this.citysightseeing_databaseDataSet1.BNumbers);
            }

            catch (Exception ex) { MessageBox.Show("" + ex); }
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditSheet newScreen = new CreditSheet(this);
            newScreen.ShowDialog();
        }

        private void listHotelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotels next = new Hotels();
            next.ShowDialog();
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.ShowDialog();
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

        private void collectedDataToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            collectedDataToolStripMenuItem.ShowDropDown();
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusTrack track = new BusTrack();
            track.ShowDialog();
        }

        public void hotelSelection(int hotelID)
        {
            txtSearch.Text = hotelID.ToString();
        }

        private void openHotels(object sender, EventArgs e)
        {
            Hotels next = new Hotels(this);
            next.ShowDialog();
        }
    }
}

