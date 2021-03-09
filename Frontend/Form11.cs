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

namespace ordering_system_app
{
    public partial class Form11 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form11()
        {
            InitializeComponent();
        }

        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView5.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string customer_id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string first_name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string last_name = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email_id = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string cus_password = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string phone_no = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string city = ds.Tables[0].Rows[i].ItemArray[6].ToString();


                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView5);
                row1.Cells[0].Value = customer_id;
                row1.Cells[1].Value = first_name;
                row1.Cells[2].Value = last_name;
                row1.Cells[3].Value = email_id;
                row1.Cells[4].Value = cus_password;
                row1.Cells[5].Value = phone_no;
                row1.Cells[6].Value = city;
                dataGridView5.Rows.Add(row1);
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {  
            populateData();      
    }
    }
}
