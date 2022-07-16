using System;
using System.Collections;
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
    public partial class ShowProduct : Sample

    {
        public ShowProduct()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddProduct ad = new AddProduct();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowProduct ad = new ShowProduct();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowMembers ad = new ShowMembers();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            DisplayData();
            label2.Text = "Admin";
        }



        private static ArrayList ListID = new ArrayList();
        private static ArrayList ListFirstname = new ArrayList();
        private static ArrayList ListLastname = new ArrayList();
        private static ArrayList ListTelephone = new ArrayList();
        private static ArrayList ListAddress = new ArrayList();


        private void DisplayData()
        {
            //dataGridView1.ColumnCount = 9;
            //dataGridView1.Columns[0].Name = "Product BarCode";
            //dataGridView1.Columns[1].Name = "Product Name";
            //dataGridView1.Columns[2].Name = "Product Quantity";
            //dataGridView1.Columns[3].Name = "Product Manufacturing Date";
            //dataGridView1.Columns[4].Name = "Product Expire Date";
            //dataGridView1.Columns[5].Name = "Product Description";
            //dataGridView1.Columns[6].Name = "Product Entry Date";
            //dataGridView1.Columns[7].Name = "Product Last Entry";
            //dataGridView1.Columns[8].Name = "Product Response";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete Data";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true; //dont forget this line

            dataGridView1.GridColor = Color.Blue;
            dataGridView1.ForeColor = Color.Black;

            dataGridView1.Font = new Font("Arial",10);
            
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Tbl_AddProduct", MainClass.con);
         

            //string query = "select count(P_Id) as id,P_barcode,P_name,P_quantity,P_ManfDate,P_ExpDate,P_description,P_EntryDate,P_LastEntry from Tbl_AddProduct";

            MainClass.con.Open();
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            MainClass.con.Close();
        }

    }
}
