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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            populateData();

            string sup_Id = SItextBox1.Text;
            string Fname = fntextBox2.Text;
            string Lname = lntextBox3.Text;
            string contact = ctextBox4.Text;
            string sup_Address = satextBox5.Text;
            string Salary = stextBox6.Text;

            con.Open();
            string myquery = "insert into supplier(supplier_Id,Fname,Lname,Contact,sup_Address,Salary) values(@id,@fname,@lname,@contact,@suplier,@salary)";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.Parameters.AddWithValue("@id", sup_Id);
            cmd.Parameters.AddWithValue("@fname", Fname);
            cmd.Parameters.AddWithValue("@lname", Lname);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@suplier", sup_Address);
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your data is saved");
            con.Close();
            populateData();
        }
        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from supplier", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView3.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string sup_Id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string Fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string Lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string sup_Address = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string Salary = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView3);
                row1.Cells[0].Value = sup_Id;
                row1.Cells[1].Value = Fname;
                row1.Cells[2].Value = Lname;
                row1.Cells[3].Value = contact;
                row1.Cells[4].Value = sup_Address;
                row1.Cells[5].Value = Salary;

                dataGridView3.Rows.Add(row1);

            }
            con.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            string sup_Id = SItextBox1.Text;
            string Fname = fntextBox2.Text;
            string Lname = lntextBox3.Text;
            string contact = ctextBox4.Text;
            string sup_Address = satextBox5.Text;
            string Salary = stextBox6.Text;

            con.Open();
            string myquery = "update supplier set Fname=@fname,Lname=@lname ,Contact=@contact,sup_Address=@address,Salary=@salary where supplier_Id=@id";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.Parameters.AddWithValue("@id", sup_Id);
            cmd.Parameters.AddWithValue("@fname", Fname);
            cmd.Parameters.AddWithValue("@lname", Lname);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@address", sup_Address);
            cmd.Parameters.AddWithValue("@salary", Salary);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your data is Updated");
            con.Close();
            populateData();
        }

        private void deletebutton3_Click(object sender, EventArgs e)
        {
            string sup_Id = SItextBox1.Text;
            string Fname = fntextBox2.Text;
            string Lname = lntextBox3.Text;
            string contact = ctextBox4.Text;
            string sup_Address = satextBox5.Text;
            string Salary = stextBox6.Text;

            con.Open();
            string myquery = "delete supplier where supplier_Id=@id";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.Parameters.AddWithValue("@id", sup_Id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your data is Deleted");
            con.Close();
            populateData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from supplier where supplier_Id like'" + textBox1.Text + "%'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView3.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string supplier_Id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string Fname = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string Lname = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string Contact = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string sup_Address = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                string Salary = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView3);
                row1.Cells[0].Value = supplier_Id;
                row1.Cells[1].Value = Fname;
                row1.Cells[2].Value = Lname;
                row1.Cells[3].Value = Contact;
                row1.Cells[4].Value = sup_Address;
                row1.Cells[5].Value = Salary;
                dataGridView3.Rows.Add(row1);
            }
            con.Close();
        }
    }
}
