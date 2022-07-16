using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class LoginSeller : Sample
    {
        public static string p_name;

        public LoginSeller()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginSe_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { usrlbError.Visible = true; } else { usrlbError.Visible = false; }
            if (txtPassword.Text == "") { psLbError.Visible = true; } else { psLbError.Visible = false; }
           

            if (usrlbError.Visible || psLbError.Visible)
            {
                MessageBox.Show("Fields with * are mandatory", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                string query = "Select count(*) from tb_seller where sl_name='"+txtUsername.Text+"' and sl_password='"+txtPassword.Text + "'";
                MainClass.con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(query, MainClass.con);
               
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                try
                {
                    if (dt.Rows[0][0].ToString() == "1")
                    {

                        MessageBox.Show("You have been Logged-In successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        p_name = txtUsername.Text;
                        SellingProduct rg = new SellingProduct();
                        MainClass.showWindow(rg, this, MDI.ActiveForm);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Username or Password is incorrect...", "Stop", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
                MainClass.con.Close();
            }

        }
    }
}
