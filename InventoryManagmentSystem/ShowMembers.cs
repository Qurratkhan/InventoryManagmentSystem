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
    public partial class ShowMembers : Sample
    {
        public ShowMembers()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowMembers ad = new ShowMembers();
            MainClass.showWindow(ad, this, MDI.ActiveForm);
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

        private void ShowMembers_Load(object sender, EventArgs e)
        {
            show_seller();
            show_warehouse();
            label2.Text = "Admin";
        }

        private void show_warehouse()
        {
            dataGridView1.GridColor = Color.Blue;
            dataGridView1.ForeColor = Color.Black;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete Data";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            dataGridView1.Font = new Font("Arial", 10);
            // MainClass.con.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tb_warehouse", MainClass.con);
            adapt.Fill(dt, "tb_warehouse");
            dataGridView1.DataSource = dt.Tables["tb_warehouse"].DefaultView;
        }

        private void show_seller()
        {
            dataGridView2.GridColor = Color.Blue;
            dataGridView2.ForeColor = Color.Black;


            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView2.Columns.Add(btn);
            btn.HeaderText = "Delete Data";
            btn.Text = "Delete";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            dataGridView2.Font = new Font("Arial", 10);
            //MainClass.con.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from tb_seller", MainClass.con);
            adapt.Fill(dt, "tb_seller");
            dataGridView2.DataSource = dt.Tables["tb_seller"].DefaultView ;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["btn"].Index)
            {
                MessageBox.Show("delete");
                int rowIndex = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(rowIndex);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["btn"].Index)
            {
                MessageBox.Show("delete");
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);


            }
        }
    }
}
