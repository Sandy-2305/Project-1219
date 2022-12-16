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
    public partial class FormProductsView : Form
    {
        string strMyPJDBConnectionString = "";  
        List<string> listProductName = new List<string>();  // list產品名稱
        List<int> listProductPrice = new List<int>();       // list產品價格
        List<int> listProductID = new List<int>();          // list產品ID
        int PID = 0;


        public FormProductsView()
        {
            InitializeComponent();
        }


        private void SQL()
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectionString);
            con.Open();

            string strSQL = "select * from Products;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_dir = @"ProductsPicture\"; 
            string image_name = ""; 
            int i = 0;

            while (reader.Read())
            {
                listProductID.Add((int)reader["ProductID"]);
                listProductName.Add(reader["ProductName"].ToString());
                listProductPrice.Add((int)reader["ProductPrice"]);

                image_name = reader["ProductImage"].ToString();

                Image myProductImage = Image.FromFile(image_dir + image_name);
                imageListProduct.Images.Add(myProductImage);
                i += 1;
            }


            Console.WriteLine($"讀取{i}筆資料");
            reader.Close();
            con.Close();
        }

 
        private void FormProductsView_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";         // 本機
            scsb.InitialCatalog = "MyPJDB"; // 資料庫
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectionString = scsb.ToString();
            SQL();
            picturemode();
            if (GlobalVar.intPerms != 10)
            {
                btnNewProduct.Hide();
            }
        }

        private void btnPicMode_Click(object sender, EventArgs e)
        {
            picturemode();
        }

        private void listmode()
        {
            listViewProduct.Clear();
            listViewProduct.LargeImageList = null;
            listViewProduct.SmallImageList = null;
            listViewProduct.View = View.Details;
            listViewProduct.Columns.Add("商品ID", 100);
            listViewProduct.Columns.Add("商品名稱", 200);
            listViewProduct.Columns.Add("商品價格", 100);
            listViewProduct.FullRowSelect = true;
            listViewProduct.GridLines = true;

            for (int i = 0; i < listProductID.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                listViewProduct.Font = new Font("微軟正黑體", 12, FontStyle.Regular);
                item.Text = listProductID[i].ToString();
                item.SubItems.Add(listProductName[i]);
                item.SubItems.Add(listProductPrice[i].ToString());
                item.Tag = listProductID[i];

                listViewProduct.Items.Add(item);
            }
        }

        private void picturemode()
        {
            listViewProduct.Clear();
            listViewProduct.View = View.LargeIcon; 
            imageListProduct.ImageSize = new Size(120, 120);
            listViewProduct.LargeImageList = imageListProduct;
            listViewProduct.SmallImageList = imageListProduct; 

            for (int i = 0; i < imageListProduct.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                item.Text = listProductName[i] + " " + listProductPrice[i] + "元";
                item.Tag = listProductID[i];
                listViewProduct.Items.Add(item);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            listProductID.Clear();
            listProductName.Clear();
            listProductPrice.Clear();
            imageListProduct.Images.Clear();

            SQL();
            if (listViewProduct.View == View.Details)
            {
                listmode();
            }
            else
            {
                picturemode();
            }
            MessageBox.Show("重新載入成功");
        }

        private void listViewProduct_ItemActivate(object sender, EventArgs e)
        {
            if (GlobalVar.intPerms == 10)
            {
                FormProductDetail ProductDetail = new FormProductDetail();
                ProductDetail.ID = (int)listViewProduct.SelectedItems[0].Tag;
                ProductDetail.ShowDialog();
            }
           
        }
       
        private void btnListMode_Click(object sender, EventArgs e)
        {
            listmode();
        }
       
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            FormProductDetail myFormDetail = new FormProductDetail();
            myFormDetail.ShowDialog();
        }

    }
}
