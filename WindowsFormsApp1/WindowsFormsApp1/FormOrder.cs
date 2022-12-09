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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class FormOrder : Form
    {
        SqlConnectionStringBuilder scsb;
        string strMyPJDBConnectString = "";
 
        List<string> listSweet = new List<string>();
        List<string> listIce = new List<string>();
        List<string> listProductName = new List<string>();  
        List<int> listProductPrice = new List<int>();       
        List<int> listProductID = new List<int>();          

        int Amount = 0;
        int Price = 0;
        int All = 0;
        string Drink = "";
        string Sweet = "";
        string Ice= "";
        bool isTakeOut = false;
        bool isBag = false;
        
       
        public FormOrder()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonTakeOut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonForHere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Clear();
            listProductID.Clear();
            listProductName.Clear();
            listProductPrice.Clear();
            listView1.LargeImageList = null;
            listView1.SmallImageList = null;
            listView1.View = View.Details;
            listView1.Columns.Add("商品名稱", 100);
            listView1.Columns.Add("商品價格", 100);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            string Type = cBoxProductType.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from Products where ProductType=@SelectType;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SelectType", Type);
            SqlDataReader reader = cmd.ExecuteReader();


            int i = 0;

            while (reader.Read())
            {
                listProductName.Add(reader["ProductName"].ToString());
                listProductPrice.Add((int)reader["ProductPrice"]);
                listProductID.Add((int)reader["ProductID"]);
                i += 1;
            }
            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();

            for (int t = 0; t < listProductID.Count; t += 1)
            {
                ListViewItem item = new ListViewItem();
                listView1.Font = new Font("微軟正黑體", 12, FontStyle.Regular);

                item.SubItems.Add(listProductName[t]);
                item.SubItems.Add(listProductPrice[t].ToString());
                item.Tag = listProductID[t];

                listView1.Items.Add(item);
            }
        }
       
        private void FormOrder_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "MyPJDB"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyPJDBConnectString = scsb.ToString();

            listSweet.Add("正常");
            listSweet.Add("少糖");
            listSweet.Add("半糖");
            listSweet.Add("微糖");
            listSweet.Add("無糖");

            listIce.Add("正常");
            listIce.Add("少冰");
            listIce.Add("微冰");
            listIce.Add("去冰");

            cBoxProductType.Items.Add("飲品");
            cBoxProductType.Items.Add("點心");

            foreach (string item in listSweet)
            {
                cBoxSweet.Items.Add(item);
            }

            foreach (string item in listIce)
            {
                cBoxIce.Items.Add(item);
            }











        }
    }
}
