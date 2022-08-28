using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_project_Product
{
   public class Product
    {
       
        public int number { get; set; }
        public double inventory { get; set; }
        public string object_name { get; set; }
        public string date { get; set; }
        public double count { get; set; }
        public double price { get; set; }
        public bool isavail { get; set; }   
        public char gender  { get; set; }  

        public static List<Product> p = new List<Product>();
        public void save()
        {
            MessageBox.Show(this.object_name + " has been added successfully!!");
            p.Add(this);
            Sql_conn sql_Conn = new Sql_conn();
            sql_Conn.insertpproduct(this);
        }
        public static List<Product> getproduct()

        {
            Sql_conn sql_Conn = new Sql_conn(); 
            List<Product> temp = new List<Product>();
            sql_Conn.selectallpproduct(temp);
            return temp;

        }

        public static List<Product> GetAllproduct(String name)
        {
            List<Product> p1 = new List<Product>();
            foreach (Product p in p)
                p1.Add(p);
            return p1;
        }
        
    }
}
