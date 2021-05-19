using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Study_Assistance
{
    public partial class dashboard : Form
    {
        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openSubForm(new Notes());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exchange_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openSubForm(new exchange());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openSubForm(new borrow());
        }

        private void buySell_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openSubForm(new buySell());
        }
        private Form active = null;
        private void openSubForm(Form sub)
        {
            if (active != null)
                active.Close();
            active = sub;
            sub.TopLevel = false;
            sub.FormBorderStyle = FormBorderStyle.None;
            sub.Dock = DockStyle.Fill;
            formPanel.Controls.Add(sub);
            formPanel.Tag = sub;
            sub.BringToFront();
            sub.Show();
        }
        private Button activeButton;
        private Panel leftborder;
        public dashboard()
        {
            InitializeComponent();
            leftborder = new Panel();
            leftborder.Size = new Size(5, 37);
            panelMenu.Controls.Add(leftborder);
        }
        private void ActiveButton(object btn)
        {
            DisableBtn();
            if (btn != null)
            {
                activeButton = (Button)btn;
                activeButton.BackColor = Color.FromArgb(50, 174, 184);
                leftborder.BackColor = Color.White;
                leftborder.Location = new Point(0,activeButton.Location.Y);
                leftborder.BringToFront();
            }
        }
        private void DisableBtn()
        {
            if(active!=null)
            {
                activeButton.BackColor = Color.FromArgb(41, 147, 154);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openSubForm(new Home());
        }
    }
}
