﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordering_system_app
{
    public partial class Form6 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form6()
        {
           
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from cus_orders", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string cus_name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string quantity = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string Item_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string Address1 = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView1);
                row1.Cells[0].Value = cus_name;
                row1.Cells[1].Value = quantity;
                row1.Cells[2].Value = Item_name;
                row1.Cells[3].Value = Address1;
                dataGridView1.Rows.Add(row1);

            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
