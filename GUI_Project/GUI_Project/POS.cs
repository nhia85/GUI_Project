using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            label3.Text = Form1.POS_salon;
            label4.Text = Form1.POS_name;
            label5.Text = Form1.POS_address;
            label6.Text = Form1.POS_state;
            label7.Text = Form1.POS_state;
        }
    }
}
