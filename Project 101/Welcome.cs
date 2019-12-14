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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            lblID.Text = Form1.idname;
            lblEmail.Text = Form1.emailname;
            lblFn.Text = Form1.fname;
            lblSn.Text = Form1.Sname;
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            menu f = new menu();
            f.Show();
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
