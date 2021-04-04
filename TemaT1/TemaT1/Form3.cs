using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace TemaT1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mihae\OneDrive\Desktop\II\Laborator\Lab3\TemaT1\TemaT1\Database1.mdf;Integrated Security=True");
            cn.Open();
            Database1Entities context = new Database1Entities();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                SqlDataAdapter ad = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                cmd.Parameters.AddWithValue("username", textBox1.Text);
                cmd.Parameters.AddWithValue("password", textBox2.Text);
                cmd.ExecuteNonQuery();
               
                MessageBox.Show(" Account created succesfully! ");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
