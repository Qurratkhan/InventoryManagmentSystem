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
    public partial class AddProduct : Sample
    {
        string barcode;

        public AddProduct()
        {
            InitializeComponent();
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddPrdct_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "") { lb_barcodeError.Visible = true; } else { lb_barcodeError.Visible = false; }
            if (txtPrdName.Text == "") { lb_PrNameError.Visible = true; } else { lb_PrNameError.Visible = false; }
            if (txtQty.Text == "") { lb_PrQtyError.Visible = true; } else { lb_PrQtyError.Visible = false; }
            if (txtManf.Text == "") { lb_PrManError.Visible = true; } else { lb_PrManError.Visible = false; }
            if (txtExpire.Text == "") { lb_PrExpError.Visible = true; } else { lb_PrExpError.Visible = false; }

            if (lb_barcodeError.Visible || lb_PrNameError.Visible || lb_PrQtyError.Visible || lb_PrManError.Visible || lb_PrExpError.Visible)
            {
                MessageBox.Show("Fields with * are mandatory", "Stop", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {
              barcode = txtBarcode.Text;

                string check = "Select P_barcode,P_EntryDate,P_quantity from Tbl_AddProduct where P_barcode = '"+barcode+"'";
                SqlDataAdapter sda = new SqlDataAdapter(check,MainClass.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //try { 
              
                if(dt.Rows.Count == 1)
                    {
                        // MessageBox.Show("Data matched, need to update");
                        string last = dt.Rows[0][1].ToString();
                        string qty = dt.Rows[0][2].ToString();

                        int new_qty = Convert.ToInt16(qty) + Convert.ToInt16(txtQty.Text);

                        DateTime DateMan = txtManf.Value.Date;
                        DateTime DateExp = txtExpire.Value.Date;
                        DateTime lastDate = DateTime.Parse(last);

                        string update_data = "Update Tbl_AddProduct set P_barcode=@bCode,P_name=@pName,P_quantity=@pQty,P_ManfDate=@pMan,P_ExpDate=@pExp,P_description=@pDes,P_EntryDate=@pEntry,P_LastEntry=@pLast where P_barcode=@bCode";
                       
                        SqlCommand cmd = new SqlCommand(update_data,MainClass.con);

                        cmd.Parameters.Add("@bCode", txtBarcode.Text);
                        cmd.Parameters.Add("@pName", txtPrdName.Text);
                        cmd.Parameters.Add("@pQty", new_qty);
                        cmd.Parameters.Add("@pMan", DateMan);
                        cmd.Parameters.Add("@pExp", DateExp);
                        cmd.Parameters.Add("@pDes", txtDesc.Text);
                        cmd.Parameters.Add("@pEntry", DateTime.Now.Date);
                        cmd.Parameters.Add("@pLast", last);

                        MainClass.con.Open();
                        int a = cmd.ExecuteNonQuery();

                        if(a>0)
                        {
                            MessageBox.Show("Data has been Updated successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        MainClass.con.Close();
                    }

                    else
                    {
                        //MessageBox.Show("Can not match data, need to add");
                        string query = "Insert into Tbl_AddProduct(P_barcode,P_name,P_quantity,P_ManfDate,P_ExpDate,P_description,P_EntryDate) values(@bCode,@pName,@pQty,@pMan,@pExp,@pDes,@pEntry)";

                        SqlCommand cmd = new SqlCommand(query, MainClass.con);

                        DateTime DateMan = txtManf.Value.Date;
                        DateTime DateExp = txtExpire.Value.Date;

                        cmd.Parameters.Add("@bCode", txtBarcode.Text);
                        cmd.Parameters.Add("@pName", txtPrdName.Text);
                        cmd.Parameters.Add("@pQty", txtQty.Text);
                        cmd.Parameters.Add("@pMan", DateMan);
                        cmd.Parameters.Add("@pExp", DateExp);
                        cmd.Parameters.Add("@pDes", txtDesc.Text);
                        cmd.Parameters.Add("@pEntry", DateTime.Now.Date);
                        

                        MainClass.con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Data has been Inserted successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
                        }
                        MainClass.con.Close();

                    }


                //}

                //catch(Exception ex)
                //{
                //    MessageBox.Show(""+ex);
                    
                //}
            }



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
                        txtManf.Text = dt.Rows[0][3].ToString();
                        txtExpire.Text = dt.Rows[0][4].ToString();
                        txtLastEntry.Text = dt.Rows[0][6].ToString();


                    }

                    else
                    {
                        MessageBox.Show("No Record found in Our Inventory System...\n Kindly Enter all details to add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Record found in Our Inventory System...\n Kindly Enter all details to add", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                }
        }

        public void refresh()
        {
            txtQty.Text = "";
            txtPrdName.Text = "";
            txtDesc.Text = "";
            txtManf.Text = "";
            txtExpire.Text = "";
            txtLastEntry.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowProduct ad = new ShowProduct();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddProduct ad = new AddProduct();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowMembers ad = new ShowMembers();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            if(LoginWarehouse.p_name!=null)
            {
                label3.Hide();
                label8.Hide();
                label14.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();

                label2.Text = LoginWarehouse.p_name.ToUpper();
            }

            else
            {
                label2.Text = "Admin";
            }
        }
    }
}
