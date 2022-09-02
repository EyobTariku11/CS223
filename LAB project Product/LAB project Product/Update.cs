using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LAB_project_Product
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update_model u= new Update_model();
          

            Boolean x = false;

            try
            {

                u.number = int.Parse(txt_number.Text);
                errorProvider1.Clear();

            }
            catch (Exception e1)
            {
                x = true;
                errorProvider1.SetError(txt_number, "Number required");
            }
            //

            try
            {
                errorProvider2.Clear();
                u.inventory = double.Parse(txt_inventory.Text);

            }
            catch (Exception e2)
            {

                x = true;
                errorProvider2.SetError(txt_inventory, "Inventory required");
            }
            //

            Regex regex1 = new Regex(@"^[0-9]+$");
            if (regex1.IsMatch(txt_count.Text))
            {
                errorProvider3.Clear();
                u.count = double.Parse(txt_count.Text);

            }
            else
            {
                errorProvider3.SetError(txt_count, "Invalid count number");
                x = true;
            }
            if (regex1.IsMatch(txt_price.Text))
            {
                errorProvider4.Clear();
                u.price = double.Parse(txt_price.Text);
                


            }
            else
            {
                errorProvider4.SetError(txt_price, "Invalid price number");
                x = true;
            }



            if (string.IsNullOrEmpty(txt_name.Text))
            {
                errorProvider5.SetError(txt_name, "Object name is required");

            }
            else
            {
                errorProvider5.Clear();
                u.object_name = txt_name.Text;



            }

            Sql_conn.update((txt_name.Text));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_count.Clear();
            txt_price.Clear();
            txt_name.Clear();
            txt_inventory.Clear();
            txt_number.Clear();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main("");
            m.Show();
        }
    }
}
