using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class FormProductDetail : Form
    {
        public int ID = 0;
        string strMyPJDBConnectionString = "";
        string image_dir = @"ProductsPicture\";
        string image_name = "";
        bool isPicUpdate = false;
        public FormProductDetail()
        {
            InitializeComponent();
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MyPJDB";
            scsb.IntegratedSecurity = true;
            strMyPJDBConnectionString = scsb.ToString();

            if (ID > 0)
            {
                groupBoxNewProduct.Visible = false;
                groupBoxAlterProduct.Visible = true;
                ProductInfo();
            }
            else
            {
                groupBoxNewProduct.Visible = true;
                groupBoxAlterProduct.Visible = false;
            }
        }

        void ProductInfo()
        {
            SqlConnection con = new SqlConnection(strMyPJDBConnectionString);
            con.Open();
            string strSQL = "select * from products where ProductID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", ID);
            SqlDataReader reader = cmd.ExecuteReader();

            int i = 0;
            while (reader.Read())
            {
                lblPID.Text = reader["ProductID"].ToString();
                txtProductName.Text = reader["ProductName"].ToString();
                txtProductPrice.Text = reader["ProductPrice"].ToString();
                txtProductDetail.Text = reader["ProductInfo"].ToString();
                txtProductType.Text = reader["ProductType"].ToString();
                image_name = reader["ProductImage"].ToString();
                pictureBoxProduct.Image = Image.FromFile(image_dir + image_name);
                i += 1;
            }
            reader.Close();
            con.Close();
            Console.WriteLine($"查詢 {i} 筆資料.");
        }

        private void btnSelectPic1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型 (*.jpg, *.jpeg, *.png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();

            if (R == DialogResult.OK)
            {
                pictureBoxProduct.Image = Image.FromFile(f.FileName);
                string fileExtension = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExtension;
                isPicUpdate = true;
                Console.WriteLine(image_name);
            }

        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if ((txtProductName.Text != "") && (txtProductPrice.Text != "") && (txtProductDetail.Text != "") && (pictureBoxProduct.Image != null)&&(txtProductType.Text!=""))
            {
                if (txtProductType.Text == "飲品" || txtProductType.Text == "點心")
                {
                    if (isPicUpdate == true)
                    {
                        pictureBoxProduct.Image.Save(image_dir + image_name);
                        isPicUpdate = false;
                    }

                    SqlConnection con = new SqlConnection(strMyPJDBConnectionString);
                    con.Open();
                    string strSQL = "update products set ProductName=@NewPname, ProductPrice=@NewPrice, ProductInfo=@NewPDesc, ProductImage=@NewPimage, ProductType=@NewPType where ProductID=@SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", ID);
                    cmd.Parameters.AddWithValue("@NewPname", txtProductName.Text);
                    int intPrice = 0;
                    Int32.TryParse(txtProductPrice.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewPDesc", txtProductDetail.Text);
                    cmd.Parameters.AddWithValue("@NewPType", txtProductType.Text);
                    cmd.Parameters.AddWithValue("@NewPimage", image_name);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");
                }
                else
                {
                    MessageBox.Show("飲料種類請填寫「飲品」或「點心」");
                }

            }
            else
            {
                MessageBox.Show("必須填寫所有欄位");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPID.Text = "";
            txtProductPrice.Clear();
            txtProductName.Clear();
            txtProductDetail.Clear();
            txtProductType.Clear();
            pictureBoxProduct.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtProductName.Text != "") && (txtProductPrice.Text != "") && (txtProductDetail.Text != "") && (pictureBoxProduct.Image != null) && (txtProductType.Text != ""))
            {
                if (txtProductType.Text == "飲品" || txtProductType.Text == "點心")
                {
                    if (isPicUpdate == true)
                    {
                        pictureBoxProduct.Image.Save(image_dir + image_name);
                        isPicUpdate = false;
                    }

                    SqlConnection con = new SqlConnection(strMyPJDBConnectionString);
                    con.Open();
                    string strSQL ="insert into products values(@NewPname, @NewPrice, @newPdesc, @newPimage,  @NewPType);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewPname", txtProductName.Text);
                    int intPrice = 0;
                    Int32.TryParse(txtProductPrice.Text, out intPrice);
                    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                    cmd.Parameters.AddWithValue("@NewPDesc", txtProductDetail.Text);
                    cmd.Parameters.AddWithValue("@NewPType", txtProductType.Text);
                    cmd.Parameters.AddWithValue("@NewPimage", image_name);
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"資料儲存成功, 影響{rows}筆資料");
                }
                else
                {
                    MessageBox.Show("飲料種類請填寫「飲品」或「點心」");
                }

            }
            else
            {
                MessageBox.Show("必須填寫所有欄位");
            }
        }

        private void cBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
