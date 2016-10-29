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
    public partial class AddCredit : Form
    {
        CreditSheet _owner;

        List<string> tours = DataReq.tourArray();
        public AddCredit(CreditSheet owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void AddCredit_Load(object sender, EventArgs e)
        {
            DataReq.fillComboBoxTours(cboTours);

            cboCCType.Items.Add("Office");
            cboCCType.Items.Add("Yard");

            if(Forms.BaseMenu.empNumber == 18 || Forms.BaseMenu.empNumber == 7 || Forms.BaseMenu.empNumber == 8 || Forms.BaseMenu.empNumber == 2)
            {
                cboCCType.Visible = true;
                lblLocation.Visible = true;
            }
        }

        public void hotelSelection(int hotelID)
        {
            txtHotel.Text = hotelID.ToString();
        }

        private void SelectHotel(object sender, EventArgs e)
        {
            Hotels next = new Hotels(this);
            next.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRate.Text.Contains("£"))
            {
                int index = txtRate.Text.IndexOf("£");
                txtRate.Text = txtRate.Text.Remove(index, 1);
            }

            if (validate() == true)
            {
                DataReq.addCredit(cboCCType.Text, cboTours.Text, dtpBookedDate.Value, txtHotel.Text, txtPax.Text, txtRate.Text);

                this.Hide();
                this.Close();
            }
            else { MessageBox.Show("Please check all values are correct", "Error 301"); }
        }

        private void AddCredit_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.refreshDgv();
        }

        private bool validate()
        {
            bool tourValid = false;
            bool bookedValid = false;
            bool paxValid = false;
            bool rateValid = false;
            int x;
            decimal y;

            foreach(string tour in tours)
            {
                if (cboTours.Text == tour)
                {
                    tourValid = true;
                }
            }

            if(int.TryParse(txtHotel.Text, out x) == true)
            {
                bookedValid = true;
            }

            if (int.TryParse(txtPax.Text, out x) == true)
            {
                paxValid = true;
            }

            if (decimal.TryParse(txtRate.Text, out y) == true)
            {
                rateValid = true;
            }

            if( tourValid == true &&  bookedValid == true &&  paxValid == true &&  rateValid == true)
            {
                return true;
            }
            else { return false;  }

        }
    }
}
