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
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
        }

        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from payment", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView4.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string order_id = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string payment_type = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string payment_status = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string order_Date = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView4);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = order_id;
                row1.Cells[2].Value = payment_type;
                row1.Cells[3].Value = payment_status;
                row1.Cells[4].Value = order_Date;
                

                dataGridView4.Rows.Add(row1);

            }
            con.Close();
        }
        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateData();
        }
    }
}
