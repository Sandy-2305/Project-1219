using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        string Product = "";
        string Ice= "";
        string Sweet = "";
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
            isTakeOut = true;
        }

        private void radioButtonForHere_CheckedChanged(object sender, EventArgs e)
        {
            isTakeOut = false;
        }

        private void cBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cBoxSweet.SelectedIndex = -1;
            cBoxIce.SelectedIndex = -1;
            listProductPrice.Clear();
            listProductName.Clear();
            listProductID.Clear();

            string Type = cBoxProductType.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(strMyPJDBConnectString);
            con.Open();
            string strSQL = "select * from Products where ProductType=@SelectType;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SelectType", Type);
            SqlDataReader reader = cmd.ExecuteReader();
            int count = 0;

            if (Type == "點心")
            {
                panel4.Hide();
                
            }
            if (Type == "飲品")
            {
                panel4.Show();
            }

            while (reader.Read())
            {
                listProductName.Add(reader["ProductName"].ToString());
                listProductPrice.Add((int)reader["ProductPrice"]);
                listProductID.Add((int)reader["ProductID"]);
                listBox1.Items.Add($"{reader["ProductName"].ToString()} {(int)reader["ProductPrice"]}");
                count += 1;
            }

            Console.WriteLine($"讀取{count}筆資料");
            reader.Close();
            con.Close();
           
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //伺服器名稱
            scsb.InitialCatalog = "MyPJDB"; //資料庫名稱
            scsb.IntegratedSecurity = true; //windows驗證
            strMyPJDBConnectString = scsb.ToString();

            lblCustomer.Text = $"訂購顧客姓名：{GlobalVar.strLoginName}";
            

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
        private void total()
        {
            Int32.TryParse(textBoxAmount.Text, out int Amount);
            if (Amount > 10)
            {
                MessageBox.Show("一筆訂單的購買數量不可以超過10！");
            }
            if (Amount > 0)
            {
                All = Price * Amount;
                
                if (isBag == true)
                {
                    All += 2;
                }
                lblPrice.Text = $"{All}";
            }
           

        }
     
        private void btnBuy_Click(object sender, EventArgs e)
        {
            total();
            if (Amount > 0)
            {
                if (cBoxProductType.SelectedIndex == 1) Sweet = "";
                if (cBoxProductType.SelectedIndex == 1) Ice = "";
                SqlConnection con = new SqlConnection(strMyPJDBConnectString);
                con.Open();
                string strSQL = "insert into OrderList values(@NewCustomerName,@NewProductName,@NewPrice,@NewAmount,@NewNeeds,@NewBuyBag,@NewToGo,@NewTotalPrice,@NewTime)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewProductName", Product);
                cmd.Parameters.AddWithValue("@NewPrice", Price);
                cmd.Parameters.AddWithValue("@NewTotalPrice", All);
                cmd.Parameters.AddWithValue("@NewAmount", Amount);
                cmd.Parameters.AddWithValue("@NewNeeds", Sweet+Ice);
                cmd.Parameters.AddWithValue("@NewCustomerName", GlobalVar.strLoginName); ;
                cmd.Parameters.AddWithValue("@NewToGo", isTakeOut);
                cmd.Parameters.AddWithValue("@NewBuyBag", isBag);
                cmd.Parameters.AddWithValue("@NewTime", DateTime.Now);

                
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"訂購成功, 共{rows}筆 !");
            }
            else
            {
                MessageBox.Show("購買數量至少為1");
            }
          

        }

        private void checkBoxBag_CheckedChanged(object sender, EventArgs e)
        {
            isBag = checkBoxBag.Checked;

            total();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex >= 0)
            {
                Product = listProductName[listBox1.SelectedIndex];
                Price = listProductPrice[listBox1.SelectedIndex];

                lblPrice.Text = $"{Price}";
                total();
            }
        }

        private void cBoxSweet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProductType.SelectedIndex == 0) Sweet = cBoxSweet.SelectedItem.ToString();
            
        }

        private void cBoxIce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProductType.SelectedIndex == 0) Ice = cBoxIce.SelectedItem.ToString();
           
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAmount.Text.Length > 0)
            {
                bool isNum = Int32.TryParse(textBoxAmount.Text, out Amount);
                if (isNum)
                {
                    total();
                }
                else
                {
                    MessageBox.Show("數量輸入錯誤");
                }
            }
        }
    }
}
