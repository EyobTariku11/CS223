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
    public partial class View : Form
    {

        public View()
        {
            InitializeComponent();
        }
        
        private void View_Load(object sender, EventArgs e)
        {
            if (Product.p.Count < 1)
                MessageBox.Show("Products do not exist.");

            flowLayoutPanel1.Controls.Clear();
            foreach(var item in Product.GetAllproduct())
            {
                Product_card p = new Product_card();
                p.product = item.number.ToString();
                p.product1 = item.object_name;
                p.product2 = item.inventory.ToString();
                p.product3 = item.count.ToString();
                p.product4 = item.price.ToString();
                p.Click += card_click;
                //p.Click += (object s, EventArgs e1) =>
                //{

                //};
                flowLayoutPanel1.Controls.Add(p);
            }

        
        }
        private void card_click(object sender, EventArgs e)
        {
            MessageBox.Show("card clicked");

        }














    }

                   
}
