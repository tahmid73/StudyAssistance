using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Study_Assistance
{
    public partial class login : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FCQLU6O\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        //SqlCommand com = new SqlCommand();
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            dashboard d1 = new dashboard();
            d1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)||textBox1.Text=="Username")
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter Your Username");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "Password")
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Enter Your Password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
