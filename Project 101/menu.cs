using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_101
{
    public partial class menu : Form
    {
        public static double check;
        list<double> add1 = new list<double>();
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtadd1.Text);
            x++;
            txtadd1.Text = x.ToString();
            
            if (x != 0)
            {
                
                check = check + (x * 20);
                

            }
            
        }

        private void lbldisplaychk_Click(object sender, EventArgs e)
        {
            lbldisplaychk.Text = check.ToString();
        }
    }
}
