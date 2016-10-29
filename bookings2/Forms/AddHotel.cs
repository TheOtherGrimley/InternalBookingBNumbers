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
    public partial class AddHotel : Form
    {
        public AddHotel()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataReq.addHotel(txtName.Text, txtNum.Text, txtEmail.Text);
            this.Hide();
            this.Close();
        }
    }
}
