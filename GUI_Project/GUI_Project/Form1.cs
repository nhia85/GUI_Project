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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string POS_salon = "";
        public static string POS_name = "";
        public static string POS_address = "";
        public static string POS_state = "";
        public static string POS_zipcode = "";

        private void POSSubmit_Click(object sender, EventArgs e)
        {
            POS_salon = textBox6.Text;
            POS_name = textBox7.Text;
            POS_address = textBox8.Text;
            POS_state = textBox9.Text;
            POS_zipcode = textBox10.Text;

            POS sales = new POS();
            Hide();
            sales.Show();
        }

        public static string Desk_salon = "";
        public static string Desk_name = "";
        public static string Desk_address = "";
        public static string Desk_state = "";
        public static string Desk_zipcode = "";

        private void DesktopSubmit_Click(object sender, EventArgs e)
        {
            Desk_salon = textBox1.Text;
            Desk_name = textBox2.Text;
            Desk_address = textBox3.Text;
            Desk_state = textBox4.Text;
            Desk_zipcode = textBox5.Text;

            Desktop desk = new Desktop();
            Hide();
            desk.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
