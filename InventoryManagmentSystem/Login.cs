using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Login : Sample
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            string username = "admin";
            string password = "admin123";

            string txtname = txtUsename.Text;
            string txtpass = txtPassword.Text;

            if (txtname.Length == 0 || txtpass.Length ==0)
            {
                MessageBox.Show("Kindly Fill Both Fields for furthur proceed..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (username.Equals(txtname) && password.Equals(txtpass))
                {
                    AdminPanel lg = new AdminPanel();
                    MainClass.showWindow(lg, this, MDI.ActiveForm);
                }

                else
                {
                    MessageBox.Show("Username or Password is Incorrect..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

            }

        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            LoginWarehouse lg = new LoginWarehouse();
            MainClass.showWindow(lg, this ,MDI.ActiveForm);
        }

        private void btnSeller_Click(object sender, EventArgs e)
        { 
            LoginSeller lg = new LoginSeller();
            MainClass.showWindow(lg, this,MDI.ActiveForm);
        }
    }
}
