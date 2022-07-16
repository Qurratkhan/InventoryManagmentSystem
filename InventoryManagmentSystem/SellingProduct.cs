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
    public partial class SellingProduct : Sample
    {
        public SellingProduct()
        {
            InitializeComponent();
        }

        string pName;

        private void SellingProduct_Load(object sender, EventArgs e)
        {
            label2.Text = LoginSeller.p_name.ToUpper();
            txtPerson.Text = LoginSeller.p_name;
            pName = txtPerson.Text;
        }

        private void fetchDetail_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text != "")
            {

                string query = "Select P_barcode,P_name,P_quantity,P_ManfDate,P_ExpDate,P_description,P_EntryDate,P_LastEntry from Tbl_AddProduct where P_barcode='" + txtBarcode.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, MainClass.con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);

                try
                {
                    if (dt.Rows.Count == 1)
                    {

                        txtQty.Text = dt.Rows[0][2].ToString();
                        txtPrdName.Text = dt.Rows[0][1].ToString();
                        txtDesc.Text = dt.Rows[0][5].ToString();
                    }

                    else
                    {
                        MessageBox.Show("No Record found in Our Inventory System...\n Kindly Enter all details to add the Product First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Record found in Our Inventory System...\n Kindly Enter all details to add the Product First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnAddPrdct_Click(object sender, EventArgs e)
        {

            if (txtBarcode.Text == "") { lb_barcodeError.Visible = true; } else { lb_barcodeError.Visible = false; }
            if (txtPrdName.Text == "") { lb_PrNameError.Visible = true; } else { lb_PrNameError.Visible = false; }
            if (txtQty.Text == "") { lb_PrQtyError.Visible = true; } else { lb_PrQtyError.Visible = false; }

            if (lb_barcodeError.Visible || lb_PrNameError.Visible || lb_PrQtyError.Visible)
            {
                MessageBox.Show("Fields with * are mandatory", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
                string barcode = txtBarcode.Text;
                string pro_name = txtPrdName.Text;
                int pro_qty = Convert.ToInt16(txtQty.Text);
                string pro_des = txtDesc.Text;
                string person = txtPerson.Text;

                string query = "select P_quantity from Tbl_AddProduct where P_barcode ='" + barcode + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, MainClass.con);

                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                try {

                    int main_qty = Convert.ToInt16(dt.Rows[0][0].ToString());

                    if (Convert.ToInt16(dt.Rows[0][0].ToString()) < pro_qty)
                    {
                        MessageBox.Show(pro_qty + " boxes are not available in our inventory, \n Kindly check again and Retry..", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    else
                    {
                        string query1 = "Insert into sell_product(s_pro_barcode,s_pro_name,s_pro_qty,s_date,s_description,s_person) values(@bCode,@pName,@pQty,@sDate,@sDes,@sPerson)";
                        SqlCommand cmd = new SqlCommand(query1, MainClass.con);

                        cmd.Parameters.Add("@bCode", txtBarcode.Text);
                        cmd.Parameters.Add("@pName", txtPrdName.Text);
                        cmd.Parameters.Add("@pQty", Convert.ToInt16(txtQty.Text));
                        cmd.Parameters.Add("@sDes", txtDesc.Text);
                        cmd.Parameters.Add("@sDate", DateTime.Now.Date);
                        cmd.Parameters.Add("@sPerson", txtPerson.Text);


                        MainClass.con.Open();
                      
                         //MessageBox.Show("Record1 has been Updated successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string update_data = "Update Tbl_AddProduct set P_quantity=@pQty where P_barcode=@bCode";

                            SqlCommand cmd1 = new SqlCommand(update_data, MainClass.con);

                            int new_qty = main_qty - Convert.ToInt16(txtQty.Text);

                            cmd1.Parameters.Add("@bCode", txtBarcode.Text);
                            cmd1.Parameters.Add("@pQty", new_qty);

                        cmd.ExecuteNonQuery();
                        int b = cmd1.ExecuteNonQuery();

                            if (b > 0)
                            {
                                MessageBox.Show("Record has been Updated successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                refresh();
                            }

                           
                        
                        MainClass.con.Close();

                    }


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error "+ex);

                }

            }

        }

        public void refresh()
        {
            txtQty.Text = "";
            txtPrdName.Text = "";
            txtDesc.Text = "";
        }

    
    }
}
