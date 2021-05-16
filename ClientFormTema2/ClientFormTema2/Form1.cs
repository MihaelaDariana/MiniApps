using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormTema2
{
    public partial class Form1 : Form
    {
        ClientFormTema2.ServiceReference1.ListaParticipantiConsursSoapClient service = new ClientFormTema2.ServiceReference1.ListaParticipantiConsursSoapClient();

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> lp = new List<string>();
            lp = service.GetParticipants();
            foreach (string a in lp)
            {
                listBox1.Items.Add(a);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string adress = textBox3.Text;
            string username = textBox4.Text;
            string facebook = textBox5.Text;
            service.InsertParticipants(id, name, adress, username, facebook);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            service.DeleteParticipants(id);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string adress = textBox3.Text;
            string username = textBox4.Text;
            string facebook = textBox5.Text;
            service.EditParticipants(id, name, adress, username, facebook);

        }

        //Id
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //NumePrenume
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //Adresa
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        //Username
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //Facebook
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
