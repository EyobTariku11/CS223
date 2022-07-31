using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_project_Product
{
    internal class Product
    {
       
        public int number { get; set; }
        public double inventory { get; set; }
        public string object_name { get; set; }
        public string date { get; set; }
        public double count { get; set; }
        public double price { get; set; }

        static List<Product> p = new List<Product>();
        public void save()
        {
            MessageBox.Show(this.object_name + " has been added successfully!!");
            p.Add(this);
        }
        public static List<Product> getallproduct()
        {
            return p ;
        }
    }
}
