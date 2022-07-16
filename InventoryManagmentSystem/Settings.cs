using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (checkBoxInTSec.Checked)
            {
                if (txtServer.Text != "" && txtDatabase.Text != "")
                {
                    s = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";Integrated Security=true";
                    File.WriteAllText(path+"\\connect", s);
                }
                else
                {
                    MessageBox.Show("Please fill all fields to complete your Process");
                }

            }

            else {
                if (txtServer.Text != "" && txtDatabase.Text != "" && txtUserId.Text != "" && txtPassword.Text != "")
                {
                    s = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDatabase.Text + ";User ID="+txtUserId.Text+";Password="+txtPassword.Text+";";
                    File.WriteAllText(path+"\\connect", s);
                }
                else
                {
                    MessageBox.Show("Please fill all fields to complete your Process");
                }

            }

            DialogResult dr = MessageBox.Show("Your Setting has been saved successfully..","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Login lg = new Login();
                MainClass.showWindow(lg,this,MDI.ActiveForm);
            }


        }

        private void checkBoxInTSec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInTSec.Checked)
            {
                txtUserId.Enabled = false;
                txtPassword.Enabled = false;
                txtUserId.Text = "";
                txtPassword.Text = "";
            }

            else {
                txtUserId.Enabled = true;
                txtPassword.Enabled = true;
            }
        }
    }
}
