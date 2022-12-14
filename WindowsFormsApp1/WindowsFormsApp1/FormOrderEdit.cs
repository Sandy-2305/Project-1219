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
        bool isBag = false;
        bool isOut = false;



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
            dateTimePickerOrder.Value = DateTime.Now;

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
                        dateTimePickerOrder.Value = Convert.ToDateTime(reader["訂購日期"]);

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
    }
}
