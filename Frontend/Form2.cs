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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            new Form1().Show();
            this.Hide();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
