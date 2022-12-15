using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        bool isLoginsuc = false; // 驗證是否成功
        string strMyPJDBConnectString = "";
        List<int> SearchIDs = new List<int>();


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
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyPJDB";
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectString = scsb.ToString();

            if (txtAccount.Text != "" && txtPassword.Text !="") 
            {
                
                string strAcct = txtAccount.Text;
                string strPwd = txtPassword.Text;
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from Customers where 電話 = @LoginPhone;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@LoginPhone", strAcct);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    string ID = reader["ID"].ToString();
                    string Acct = reader["電話"].ToString();
                    string Password = reader["Password"].ToString();
                    GlobalVar.strLoginName = reader["姓名"].ToString();
                    string Perms = reader["權限"].ToString();
                    Int32.TryParse(ID, out GlobalVar.memberID);
                    Int32.TryParse(Perms, out GlobalVar.intPerms);
                    if (strAcct == Acct && strPwd == Password)
                    {
                        isLoginsuc = true;

                    }
                }
                reader.Close();
                con.Close();

                if (isLoginsuc==true)
                {
                    // 登入成功
                    MessageBox.Show("登入成功！");
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

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoginsuc == false) 
            { e.Cancel = true; }  // 如果驗證失敗，FormLogin不關閉。
            else
            { e.Cancel = false; }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd myForm = new FormAdd();
            myForm.ShowDialog();
        }
    }

}