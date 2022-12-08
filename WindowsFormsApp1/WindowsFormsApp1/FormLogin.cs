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
        bool isLoginsuc = false; // 驗證是否成功
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
                
                string strAcct = txtAccount.Text;
                string strPwd = txtPassword.Text;
                
                 
                if (strAcct == "1" && strPwd == "1")
                {
                    isLoginsuc= true;
                }


                if (isLoginsuc==true)
                {
                    // 登入成功
                    MessageBox.Show("登入成功！");
                    GlobalVar.memberID = 1;
                    GlobalVar.strLoginName = "店長";
                    GlobalVar.intPerms = 1;
                    Close();

                }
                else
                {
                    // 登入失敗，清除欄位。
                    MessageBox.Show("登入失敗，請輸入正確的帳號密碼！");
                    txtAccount.Text = "";
                    txtPassword.Text = "";
                }

            }
            else 
            {
                MessageBox.Show("請輸入帳號密碼！");
            }

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoginsuc == false) 
            { e.Cancel = true; }  // 如果驗證失敗，FormLogin不關閉。
            else
            { e.Cancel = false; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}