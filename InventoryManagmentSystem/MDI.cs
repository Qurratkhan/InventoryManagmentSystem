using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InventoryManagmentSystem
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(path + "\\connect"))
            {
                Login lg = new Login();
                MainClass.showWindow(lg, this);
            }

            else {
                Settings st = new Settings();
                MainClass.showWindow(st,this);
                
            }
           
        }

        private void backToHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            MainClass.showWindow(lg, this);
        }
    }
}
