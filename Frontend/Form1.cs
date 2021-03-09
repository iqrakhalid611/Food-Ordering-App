using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordering_system_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            new Form3().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonaccount_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            
        }
          

        private void buttoncart_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonorders_Click(object sender, EventArgs e)
        {
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
          

        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();

        }

        private void ordersbutton_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }

        private void accountbutton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(accountbutton,accountbutton.Width,1);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }
    }
}
