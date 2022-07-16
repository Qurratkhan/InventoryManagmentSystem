using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
   

    public partial class AddProductItem : Form
    {
       

        public AddProductItem()
        {
            InitializeComponent();
        }

        private void btnAddPr_Click(object sender, EventArgs e)
        {
            Tbl_AddProduct tb = new Tbl_AddProduct();
            tb.P_barcode = txtBarcode.text;
            tb.P_name = txtPrName.text;
            tb.P_quantity = Convert.ToInt16(txtPrQty.text);
            tb.P_ManfDate = DateTime.Parse(txtManufacture.text);
            tb.P_ExpDate = DateTime.Parse(txtExpire.text);

            db.Tbl_AddProduct.Add(tb);
            int a = db.SaveChanges();
            if (a > 0)
            {
                string message = "Product Added Successfully";
                string title = "Add Product";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title,buttons,MessageBoxIcon.Information );

                if (result == DialogResult.OK)
                {
                    this.Close();
                    View_Product vw = new View_Product();
                    vw.MdiParent = this;
                    vw.Show();
                       
                }

            }
            

        }

        private void AddProductItem_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
