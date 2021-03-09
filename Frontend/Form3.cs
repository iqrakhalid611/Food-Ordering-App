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
    public partial class Form3 : Form
    { SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Fname = textBox1.Text;
            string Lname = textBox2.Text;
            string CNIC = textBox3.Text;
            string Email = textBox4.Text;
            string Contact = textBox5.Text;
            string Address1 = textBox6.Text;
            string Passwordcnfrm = textBox7.Text;

            con.Open();
            string myquery = "insert into customer(customer_id,first_name,last_name,email_id,phone_no,city,cus_password) values(@id,@fname,@lname,@email,@contact,@address,@password)";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.Parameters.AddWithValue("@fname", Fname);
            cmd.Parameters.AddWithValue("@lname", Lname);
            cmd.Parameters.AddWithValue("@id", CNIC);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@contact", Contact);
            cmd.Parameters.AddWithValue("@address", Address1);
            cmd.Parameters.AddWithValue("@password", Passwordcnfrm);
            cmd.ExecuteNonQuery();
            MessageBox.Show("you are successfully signed In");
            con.Close();
            new Form2().Show();
            this.Hide();
        }
    }
}
