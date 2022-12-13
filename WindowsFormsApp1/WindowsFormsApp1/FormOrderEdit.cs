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
        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
