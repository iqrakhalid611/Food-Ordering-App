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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=IQRAKHALID\\IQRA;Initial Catalog=finalproject;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        
        private void buttoncnfrm_Click(object sender, EventArgs e)
        {
            string cus_name = textBox1.Text;
            string quantity = textBox2.Text;
            string Item_name= textBox3.Text;
            string Address1= textBox4.Text;
            

            con.Open();
            string myquery = "insert into cus_orders(cus_name,quantity,Item_name,Address1) values(@fname,@qname,@icnic,@address)";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.Parameters.AddWithValue("@fname", cus_name);
            cmd.Parameters.AddWithValue("@qname", quantity);
            cmd.Parameters.AddWithValue("@icnic", Item_name);
            cmd.Parameters.AddWithValue("@address", Address1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("your order placed");
            con.Close();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
