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
    public partial class RegSeller : Sample
    {
        public RegSeller()
        {
            InitializeComponent();
        }

        private void btnRegSl_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { usrlbError.Visible = true; } else { usrlbError.Visible = false; }
            if (txtPassword.Text == "") { psLbError.Visible = true; } else { psLbError.Visible = false; }
            if (txtRePassword.Text == "") { RePsLbError.Visible = true; } else { RePsLbError.Visible = false; }
            if (txtContact.Text == "") { CtLbError.Visible = true; } else { CtLbError.Visible = false; }

            if (usrlbError.Visible || psLbError.Visible || RePsLbError.Visible || CtLbError.Visible)
            {
                MessageBox.Show("Fields with * are mandatory", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                string query = "Insert into tb_seller(sl_name,sl_password,sl_contact) values(@wr_name,@wr_password,@wr_contact)";

                SqlCommand cmd = new SqlCommand(query, MainClass.con);
                cmd.Parameters.Add("@wr_name", txtUsername.Text);
                cmd.Parameters.Add("@wr_password", txtPassword.Text);
                cmd.Parameters.Add("@wr_contact", txtContact.Text);

                MainClass.con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Seller Member has been registered successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MainClass.con.Close();
            }

        }
    }
}
