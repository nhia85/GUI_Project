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
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 main = new Form1();
            main.Show();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            number.Text = Form1.Desk_salon;
            name.Text = Form1.Desk_name;
            address.Text = Form1.Desk_address;
            state.Text = Form1.Desk_state;
            zipcode.Text = Form1.Desk_state;
        }
    }
}
