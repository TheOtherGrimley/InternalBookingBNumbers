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
    public partial class AddEntry : Form
    {
        BaseMenu _owner;
        List<string> tours = DataReq.tourArray();

        public AddEntry(BaseMenu owner)
        {
            _owner = owner;
            InitializeComponent();
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
                DataReq.AddEntry(txtPax.Text, txtName.Text, txtPickup.Text, txtHotel.Text, dtpDate.Value.Date, txtRate.Text, txtPayment.Text, cboType.Text, txtMcCombs.Text, txtNotes.Text);
                this.Hide();
                this.Close();
            }
            
            else { MessageBox.Show("Please check all values are correct", "error 301"); }
        }

        private void AddEntry_Load(object sender, EventArgs e)
        {
            lblRefNo.Text = DataReq.GetRefNumber().ToString();
            DataReq.fillComboBoxTours(cboType);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private bool validate()
        {
            bool valid = true;
            bool tourValid = false;
            Decimal textVa;
            int textV;

            foreach(string tour in tours)
            {
                if (cboType.Text == tour)
                {
                    tourValid = true;
                }
                valid = tourValid;
            }

            if(!int.TryParse(txtPax.Text, out textV)) {
                valid = false;
            }

            if(!int.TryParse(txtHotel.Text, out textV))
            {
                valid = false;
                MessageBox.Show("Please double click the text box to select a hotel from the hotel list.");
            }

            if(txtPickup.Text == "")
            {
                valid = false;
            }

            if (!Decimal.TryParse(txtRate.Text, out textVa))
            {
                valid = false;
            }

            if (cboType.Text == "Please Select")
            {
                valid = false;
            }

            if (txtMcCombs.Text == "")
            {
                valid = false;
            }

            return valid;
        }

        public void hotelSelection(int hotelID)
        {
            txtHotel.Text = hotelID.ToString();
        }

        private void AddEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            _owner.refreshDgv();
        }

        private void openHotels(object sender, EventArgs e)
        {
            Hotels next = new Hotels(this);
            next.ShowDialog();
        }
    }
}
