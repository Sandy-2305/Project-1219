using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtPassword.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text != "" && txtPassword.Text !="")
            {

            }
            else 
            {
                MessageBox.Show("請輸入帳號密碼！");
            }
        }
    }

}