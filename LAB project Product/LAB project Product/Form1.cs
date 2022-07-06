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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.number = int.Parse(txt_number.Text);
            p.date = dateTimePicker1.Text;
            p.inventory = double.Parse(txt_inventory.Text);
            p.object_name = txt_objectname.Text;
            p.count = double.Parse(txt_count.Text);
            p.price = double.Parse(txt_price.Text);
            p.save();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
    
}
