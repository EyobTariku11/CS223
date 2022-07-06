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
            product p = new product();
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
    public class product
    {
        public int number { get; set; }
        public double inventory { get; set; }
        public string object_name { get; set; }
        public string date { get; set; }
        public double count { get; set; }
        public double price { get; set; }

        public void save()
        {
            MessageBox.Show(this.object_name+" has been added successfully");
        }
    }
}
