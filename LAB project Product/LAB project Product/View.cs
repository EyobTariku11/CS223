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
    public partial class View : Form
    {

        public View()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {     
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.getallproduct();
        }
    }
}
