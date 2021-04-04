using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaT1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void bLgn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Database1Entities context = new Database1Entities();
            if (textBox1.Text!=string.Empty || textBox2.Text != string.Empty)
            {
                var user = context.LoginTables.Where(a => a.username.Equals(textBox1.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(textBox2.Text))
                    {
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password not correct!:(");
                    }
                }
                else
                {
                    MessageBox.Show("Username not correct!:(");
                }
            }
            else
            {
                MessageBox.Show("Please add Username and Password...");
            }
        }

        private void bCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
