using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_project_Product
{
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }
        public String username = "admin";
        public String password = "admin";

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Empty field");
            }
           if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(textBox2, "Empty password field");

            }
            
            if (textBox1.Text == username && textBox2.Text == password)
            {
                errorProvider1.Clear();
                errorProvider2.Clear();
                Form1 form = new Form1(username);
                form.Show();

            }
            else
            {
                MessageBox.Show("Invlaid username or password");
            }



        } 
    private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
