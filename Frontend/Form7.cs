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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
           
         

        }

        private void buttonodd_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();

        }

        private void supplierbutton_Click(object sender, EventArgs e)
        {
            new Form9().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form10().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form11().Show();
        }
    }
}
