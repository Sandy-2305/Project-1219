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

            BuildOrderList();
        }
        void BuildOrderList()
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select OrderID as 訂單編號, 訂購人, 品項名稱, 單價, 購買數量, 客製化需求, 總金額, 訂購日期 from OrderList";
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
        private void checkBoxIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //    int intID = 0;

            //    SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            //    con.Open();
            //    string strSQL = "select * from Customers where ID = @ID ;";
            //    string Records = "select count(*) from Customers ; ";

            //    SqlDataAdapter DataAdapter = new SqlDataAdapter(Records, con);
            //    DataSet DS = new DataSet();
            //    DataAdapter.Fill(DS);
            //    intID = (int)DS.Tables[0].Rows[0][0];


            //    SqlCommand cmd = new SqlCommand(strSQL, con);
            //    cmd.Parameters.AddWithValue("@ID", intID);
            //    SqlDataReader reader = cmd.ExecuteReader();


            //    if (reader.Read() == true)
            //    {
            //        lblOrderID.Text = reader["ID"].ToString();
            //        lblOrderName.Text = reader["姓名"].ToString();
            //        .Text = reader["電話"].ToString();
            //        txtAddr.Text = reader["地址"].ToString();
            //        txtEmail.Text = reader["Email"].ToString();
            //        txtPoint.Text = reader["Point"].ToString();
            //        dtpBirth.Value = Convert.ToDateTime(reader["生日"]);
            //    }
            //    reader.Close();
            //    con.Close();
        }
    }
}
