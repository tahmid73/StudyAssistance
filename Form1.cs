using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_Assistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            register r1 = new register();
            r1.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard d1 = new dashboard();
            d1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
