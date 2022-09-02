﻿using System;
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
    public partial class Search : Form
    {
        public Search()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox1.Text))
                errorProvider1.SetError(textBox1, "empty text box");

            dataGridView1.DataSource = null;
            List<Product> text = Product.getproduct(textBox1.Text);
            if (text.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = text;
            }
            else
            {
                MessageBox.Show(textBox1.Text+" doesn't exist!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Main m = new Main("");
            m.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
