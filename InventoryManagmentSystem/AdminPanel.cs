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
    public partial class AdminPanel : Sample
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegWarehouse rg = new RegWarehouse();
            MainClass.showWindow(rg, this, MDI.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegSeller rg = new RegSeller();
            MainClass.showWindow(rg, this, MDI.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowProduct sh = new ShowProduct();
            MainClass.showWindow(sh, this, MDI.ActiveForm);
        }

        private void User_Click(object sender, EventArgs e)
        {

        }
    }
}
