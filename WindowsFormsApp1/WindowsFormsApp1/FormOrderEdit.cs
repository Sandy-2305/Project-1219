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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class FormOrderEdit : Form
    {
        string strMyPJDBConnectString = "";
        List<int> SearchOrderIDs = new List<int>();


        public FormOrderEdit()
        {
            InitializeComponent();
        }

        private void FormOrderEdit_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyPJDB";
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectString = scsb.ToString();

            comboBox1.Items.Add("訂購人");
            comboBox1.Items.Add("品項名稱");
           
            comboBox1.SelectedIndex = 0;

            BuildOrderList();
        }

        void BuildOrderList()
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select OrderID as 訂單編號,* from OrderList";
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
            lblOrderID.Text = "";
            lblOrderName.Text = "";
            lblProductName.Text = "";
            lblAll.Text = "";
            checkBoxOut.Checked=false;
            checkBoxBag.Checked = false;
            
            txtCount.Clear();

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
                    string strSQL = "select * from OrderList where OrderID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelectedID);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        lblOrderID.Text = reader["OrderID"].ToString();
                        lblOrderName.Text = reader["訂購人"].ToString();
                        lblProductName.Text = reader["品項名稱"].ToString();
                        lblPrice.Text = reader["單價"].ToString();
                        txtCount.Text = reader["購買數量"].ToString();
                        txtDetail.Text = reader["客製化需求"].ToString();
                        checkBoxBag.Checked = Convert.ToBoolean(reader["購物袋"]);
                        checkBoxOut.Checked = Convert.ToBoolean (reader["外帶"]);
                        lblAll.Text = reader["總金額"].ToString();
                        string strDate = reader["訂購日期"].ToString();
                        lblDate.Text= strDate.Remove(strDate.Length - 11);

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            BuildOrderList();
        }

        private void FliterSearch_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            SearchOrderIDs.Clear();
            string FliterName = comboBox1.SelectedItem.ToString();

            if (txtKeyWord.Text != "")
            {
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from OrderList where " + FliterName + " like @SearchKeyWord and 訂購日期 <= @BirthEnd and 訂購日期 >= @BirthStart ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchKeyword", "%" + txtKeyWord.Text + "%");
                cmd.Parameters.AddWithValue("@BirthEnd", dtpEnd.Value);
                cmd.Parameters.AddWithValue("@BirthStart", dtpStart.Value);


                SqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    SearchOrderIDs.Add((int)reader["OrderID"]);
                    string strDate = reader["訂購日期"].ToString();


                    listResult.Items.Add($"{(int)reader["OrderID"]} {reader["訂購人"].ToString()}： {reader["品項名稱"].ToString()}{reader["購買數量"].ToString()}份   訂購時間：{strDate.Remove(strDate.Length - 11)}");
                    count += 1;
                    // 加入DataGridView
                }

                if (count == 0)
                {
                    MessageBox.Show("查無訂單");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入欄位查詢關鍵字");
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
          
            int intID = 0;
            int intCount= 0;
            if(Int32.TryParse(txtCount.Text, out intCount) == true)
            {
                Int32.TryParse(lblOrderID.Text, out intID);

                if ((intID > 0) && (txtCount.Text != ""))
                {
                    int idxrow = dataGridView1.CurrentRow.Index;
                    SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                    con.Open();
                    string strSQL = "update orderList set 客製化需求=@NewDetail, 購買數量=@NewCount, 購物袋=@NewBag, 外帶=@NewBag, 總金額=@NewAll where OrderID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intID);
                    cmd.Parameters.AddWithValue("@NewDetail", txtDetail.Text);
                    cmd.Parameters.AddWithValue("@NewCount", txtCount.Text);
                    cmd.Parameters.AddWithValue("@NewBag", checkBoxBag.Checked);
                    cmd.Parameters.AddWithValue("@NewOut", checkBoxBag.Checked);
                    cmd.Parameters.AddWithValue("@NewAll", lblAll.Text);


                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"({rows}個資料列受到影響)");
                    dataGridView1.CurrentCell = dataGridView1.Rows[idxrow].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("購買數量請輸入整數");
            }

           
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            int intCount = 0;
            int intPrice = 0;
            Int32.TryParse(lblPrice.Text, out intPrice);
            Int32.TryParse(txtCount.Text, out intCount);
         
            if (intCount < 10)
            {
                lblAll.Text = (intPrice * intCount).ToString();
            }
            else
            {
                MessageBox.Show("購買數量不可以超過10");
            }
         
            

        }

        private void listResult_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listResult.SelectedIndex >= 0)
            {
                int intSelectedID = SearchOrderIDs[listResult.SelectedIndex];

                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "select * from OrderList where OrderID = @searchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@searchID", intSelectedID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblOrderID.Text = reader["OrderID"].ToString();
                    lblOrderName.Text = reader["訂購人"].ToString();
                    lblProductName.Text = reader["品項名稱"].ToString();
                    lblPrice.Text = reader["單價"].ToString();
                    txtCount.Text = reader["購買數量"].ToString();
                    txtDetail.Text = reader["客製化需求"].ToString();
                    checkBoxBag.Checked = Convert.ToBoolean(reader["購物袋"]);
                    checkBoxOut.Checked = Convert.ToBoolean(reader["外帶"]);
                    lblAll.Text = reader["總金額"].ToString();
                    string strDate = reader["訂購日期"].ToString();
                    lblDate.Text = strDate.Remove(strDate.Length - 11);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int intID = 0;
            Int32.TryParse(lblOrderID.Text, out intID);

            if (intID > 0)
            {
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "delete from OrderList where OrderID = @DeleteID;";
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
            Int32.TryParse(lblOrderID.Text, out intID);

            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from OrderList where OrderID = @ID ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", intID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                lblOrderID.Text = reader["OrderID"].ToString();
                lblOrderName.Text = reader["訂購人"].ToString();
                lblProductName.Text = reader["品項名稱"].ToString();
                lblPrice.Text = reader["單價"].ToString();
                txtCount.Text = reader["購買數量"].ToString();
                txtDetail.Text = reader["客製化需求"].ToString();
                checkBoxBag.Checked = Convert.ToBoolean(reader["購物袋"]);
                checkBoxOut.Checked = Convert.ToBoolean(reader["外帶"]);
                lblAll.Text = reader["總金額"].ToString();
                string strDate = reader["訂購日期"].ToString();
                lblDate.Text = strDate.Remove(strDate.Length - 11);

            }
            reader.Close();
            con.Close();
        }
    }
}
