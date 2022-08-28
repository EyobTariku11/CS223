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
    public partial class Main : Form
    {
        String name;
        public Main(string username)
        {
            name = username;
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

           
            Form1 form1 = new Form1(name);
            form1.MdiParent = this;
            form1.Show();

        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            View v= new View();
            v.MdiParent=this;
            v.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            this.Close();

            Search s = new Search();
            s.MdiParent = this;
            s.Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
            addToolStripMenuItem.Enabled = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            delete d = new delete();
            d.Show();
            
        }
    }
}
