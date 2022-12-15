using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAdd : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyPJDBConnectString = "";


        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
            txtName.Clear();
            txtPwd.Clear();
            txtAddr.Clear();
            txtEmail.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if ((txtName.Text != "") && (txtPhone.Text != "") && (txtPwd.Text != "") && (txtAddr.Text != "") && (txtEmail.Text != ""))
            {
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from Customers;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                SqlDataReader reader = cmd.ExecuteReader();
                string strName = "";
                string strEmail = "";
                string strPhone = "";
                bool ok = true;
                while (reader.Read() == true)
                {
                    strName = reader["姓名"].ToString();
                    strPhone = reader["電話"].ToString();
                    strEmail = reader["Email"].ToString();
                    
                    if (strName == txtName.Text)
                    {
                        MessageBox.Show("此名字已被使用");
                        ok = false;
                    }
                    if (strEmail == txtEmail.Text)
                    {
                        MessageBox.Show("此Email已被使用");
                        ok = false;
                    }
                    if (strPhone == txtPhone.Text)
                    {
                        MessageBox.Show("此號碼已被使用");
                        ok = false;
                    }

                   
                }
                reader.Close();
                con.Close();
                if (ok==true)
                {

                    con.Open();
                    string strSQL2 = "insert into Customers values (@NewName,@NewPhone,@NewAddress,@NewEmail,@NewBirth,@NewPoints,@NewPwd,@NewPerms);";
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@NewName", txtName.Text);
                    cmd2.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                    cmd2.Parameters.AddWithValue("@NewAddress", txtAddr.Text);
                    cmd2.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                    cmd2.Parameters.AddWithValue("@NewBirth", dateTimePicker1.Value);
                    cmd2.Parameters.AddWithValue("@NewPoints", 0);
                    cmd2.Parameters.AddWithValue("@NewPwd", txtPwd.Text);
                    cmd2.Parameters.AddWithValue("@NewPerms", 1);

                    int rows = cmd2.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine($"({rows}個資料列受到影響)");
                    MessageBox.Show("註冊成功");
                }
                
                con.Close();

                
            }
            else
            {
                MessageBox.Show("請輸入完整資料");
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyPJDB"; 
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectString = scsb.ToString();
            
        }
    }
}
