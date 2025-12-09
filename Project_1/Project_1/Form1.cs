using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = password.Text;
            string login_1 = "admin-1";
            string login_2 = "admin-2";
            string login_3 = "admin-3";
            string password_1 = "1";
            string password_2 = "2";
            string password_3 = "3";
            if ((log == login_1 && pas == password_1) | (log == login_2 && pas == password_2)| (log == login_3 && pas == password_3))
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Не правильно введен логин или пароль!", "Внимание!");
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
