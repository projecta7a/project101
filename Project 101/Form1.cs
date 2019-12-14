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

    public partial class Form1 : Form
    {
        public static string fname;
        public static string Sname;
        public static string idname;
        public static string emailname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void login()
        {
            idname = txtID.Text;
            fname = txtFirstn.Text;
            Sname = txtSecondn.Text;
            emailname = txtEmail.Text; 
            this.Hide();
            Welcome login = new Welcome();
            login.Show();
        }
        private void restform()
        {
            txtFirstn.Text = "";
            txtID.Text = "";
            txtPass.Text="";
            txtSecondn.Text = "";
            txtEmail.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                restform();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            restform();
        }
    }

}
    