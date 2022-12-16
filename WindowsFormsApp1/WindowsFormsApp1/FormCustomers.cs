using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCustomers : Form
    {
        string strMyPJDBConnectString = "";
        List<int> SearchIDs = new List<int>();



        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyPJDB";
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectString = scsb.ToString();

            comboBox1.Items.Add("姓名");
            comboBox1.Items.Add("電話");
            comboBox1.Items.Add("地址");
            comboBox1.Items.Add("Email");
            comboBox1.SelectedIndex = 0;

            BuildCustomerList();

        }

        private void FliterSearch_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            SearchIDs.Clear();
            string FliterName = comboBox1.SelectedItem.ToString();

            if (txtKeyWord.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from Customers where " + FliterName + " like @SearchKeyWord and 生日 <= @BirthEnd and 生日 >= @BirthStart ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txtKeyWord.Text + "%");
                cmd.Parameters.AddWithValue("@BirthEnd", dtpBirthEnd.Value);
                cmd.Parameters.AddWithValue("@BirthStart", dtpBirthStart.Value);
                
               
                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchIDs.Add((int)reader["ID"]);
                    listResult.Items.Add($"{(int)reader["ID"]} {reader["姓名"].ToString()} {reader["電話"].ToString()}");
                    count += 1;
                    // 加入DataGridView
                }

                if (count == 0)
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入欄位查詢關鍵字");
            }
        }

        void BuildCustomerList()
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from Customers";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }

        void Clean()
        {
            lblID.Text = "";
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddr.Clear();
            txtPoint.Clear();
            dtpBirth.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                int intSelectedID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelectedID);

                if (isID == true)
                {
                    SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                    con.Open();
                    string strSQL = "select * from Customers where ID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblID.Text = reader["ID"].ToString();
                        txtName.Text = reader["姓名"].ToString();
                        txtPhone.Text = reader["電話"].ToString();
                        txtAddr.Text = reader["地址"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPoint.Text = reader["Point"].ToString();
                        dtpBirth.Value = Convert.ToDateTime(reader["生日"]);
                        txtPwd.Text = reader["Password"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        Clean();
                    }
                    reader.Close();
                    con.Close();
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from Customers";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int count = 0;

            while (reader.Read() == true)
            {
                int id = (int)reader["ID"];
                string 姓名 = reader["姓名"].ToString();
                string 電話 = reader["電話"].ToString();
                string email = reader["Email"].ToString();

                strMsg += $"{id} {姓名} {電話} {email} \n";
                count += 1;
            }

            strMsg += "資料筆數：共" + count + "筆";
            reader.Close();
            con.Close();
            MessageBox.Show(strMsg);
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txtName.Text != "") && (txtPhone.Text != ""))
            {
                int idxrow = dataGridView1.CurrentRow.Index;
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "update Customers set 姓名=@NewName, 電話=@NewPhone, 地址=@NewAddress, Email=@NewEmail, 生日=@NewBirth, Point=@NewPoints, Password=@NewPwd where ID = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txtAddr.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtpBirth.Value);

                int intPoints = 0;
                Int32.TryParse(txtPoint.Text, out intPoints);
                cmd.Parameters.AddWithValue("@NewPoints", intPoints);
                cmd.Parameters.AddWithValue("@SearchID", intID);
                cmd.Parameters.AddWithValue("@NewPwd", txtPwd.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"({rows}個資料列受到影響)");
                dataGridView1.CurrentCell = dataGridView1.Rows[idxrow].Cells[0];
            }

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BuildCustomerList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "delete from Customers where ID = @DeleteID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteID", intID);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                Clean();
                MessageBox.Show($"({rows}個資料列受到影響)");
            }
        }

        private void btnDataRecovery_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from Customers where ID = @ID ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", intID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                lblID.Text = reader["ID"].ToString();
                txtName.Text = reader["姓名"].ToString();
                txtPhone.Text = reader["電話"].ToString();
                txtAddr.Text = reader["地址"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtPoint.Text = reader["Point"].ToString();
                dtpBirth.Value = Convert.ToDateTime(reader["生日"]);
            }
            reader.Close();
            con.Close();
        }
    
        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listResult.SelectedIndex >= 0)
            {
                int intSelectedID = SearchIDs[listResult.SelectedIndex];

                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from dbo.Customers where id = @searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intSelectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["ID"].ToString();
                    txtName.Text = reader["姓名"].ToString();
                    txtPhone.Text = reader["電話"].ToString();
                    txtAddr.Text = reader["地址"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPoint.Text = reader["Point"].ToString();
                    dtpBirth.Value = Convert.ToDateTime(reader["生日"]);
                    
                }
                else
                {
                    MessageBox.Show("查無此人");
                }
                reader.Close();
                con.Close();
                
            }
           
        }

    }
}
