using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_project_Product
{
    public partial class Form1 : Form
    {
        public Form1(String name)
        {
            InitializeComponent();
            label7.Text=name;
        }
        Product p = new Product();
        private void btn_add_Click(object sender, EventArgs e)
        {
            
            
         
          if (Female.Checked)
            {
                p.gender = "Female";
            }
            else if(Male.Checked) 
            {
                p.gender = "Male";
            }
            else
            {
                p.gender = "Other";
            }
            if (chk_avail.Checked)
            {
                MessageBox.Show("Item is available");
                p.isavail = chk_avail.Checked;
            }
            else
            {
                MessageBox.Show("Item is not available");
            }
          
            Boolean x = false;

            try
            {
              
                p.number = int.Parse(txt_number.Text);
                errorprovider1.Clear();

            }
            catch(Exception e1)
            {
                x = true;
                errorprovider1.SetError(txt_number, "Number required");
             }
            //
           
            try
            {
                errorProvider2.Clear();
                p.inventory = double.Parse(txt_inventory.Text);
                
            }
            catch (Exception e2)
            {
               
                x=true;
                errorProvider2.SetError(txt_inventory, "Inventory required");
            }
            //
           
            Regex regex1 = new Regex(@"^[0-9]+$");
            if (regex1.IsMatch(txt_count.Text))
            {
                p.count = double.Parse(txt_count.Text);

            }
            else
            {
                errorprovider1.SetError(txt_count, "Invalid count number");
                x = true;
            }
            if (regex1.IsMatch(txt_price.Text))
            {
                p.price = double.Parse (txt_price.Text);


            }
            else
            {
                errorprovider1.SetError(txt_price,"Invalid price number");
                x = true;
            }


            p.object_name = txt_objectname.Text;
            if (string.IsNullOrEmpty(txt_objectname.Text))
            {
                errorprovider1.SetError(txt_objectname, "Object name is required");

            }
            else
            {
                errorprovider1.Clear();

                p.date = dateTimePicker1.Text;
                p.save();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_number.Clear();
            txt_count.Clear();
            txt_inventory.Clear();
            txt_objectname.Clear();
            txt_price.Clear();
        }

       
    }
    
}
