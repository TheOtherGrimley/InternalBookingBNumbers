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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bookings2.Forms.BaseMenu nextScreen = new bookings2.Forms.BaseMenu();

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (DataReq.LoginCheck(txtEmpNumber.Text, txtEmpPass.Text) == true)
            {
                this.Hide();

                BaseMenu.empNumber = int.Parse(txtEmpNumber.Text);

                BaseMenu menu = new BaseMenu();
                menu.ShowDialog();

                
                this.Close();
            }

            else
            {
                MessageBox.Show("Employee ID and/or pasword not recognised", "Error 101");
                txtEmpPass.Text = "";
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
