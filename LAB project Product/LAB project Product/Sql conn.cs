using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace LAB_project_Product
{
    internal class Sql_conn

    {
        static SqlConnection con;

        public static void connection()
        {
            string cs = @"server =DESKTOP-0SC7RBT\SQLEXPRESS ;database=product;integrated security= true";
             con = new SqlConnection(cs);

            try
            {
                con.Open();
                MessageBox.Show("Connected succefully");
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void insertpproduct(Product p)
        {
            string insertquery = "insert into product values('" + p.object_name + "', '" + p.gender + "', '" + p.number + "', '" + p.date + "', '" + p.inventory + "', '" + p.price + "', '" + p.count + "')";
            try
            {
                connection();
               
                SqlCommand cmd = new SqlCommand(insertquery, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"Product {p.object_name} has been Added Successfully");
                //con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public  static void deleteStudent(int number)
        {
            string cs = @"server =DESKTOP-0SC7RBT\SQLEXPRESS ;database=product;integrated security= true";

            string query = "delete from product where number =" + number;


            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("delete Successfully");
                else
                {
                    MessageBox.Show("Item doesnt exist!");

                }
            }

        }
            

              public  void selectallpproduct(List<Product> temp)
              {

            try
            {
                connection();
                SqlCommand cmd = new SqlCommand("select * from product", con);
                SqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    Product p = new Product();
                    p.object_name = res["objectname"].ToString();
                    char[] g = res[1].ToString().ToCharArray();
                    p.gender = g[0];
                    p.number = int.Parse(res[2].ToString());
                    p.date = res[3].ToString();
                    p.inventory = double.Parse(res[4].ToString());
                    p.price = double.Parse(res[5].ToString());
                    p.count = double.Parse(res[6].ToString());
                    temp.Add(p);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

              }
    }
}
