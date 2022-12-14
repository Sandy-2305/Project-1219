using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAll : Form
    {
        public FormAll()
        {
            InitializeComponent();
        }

        private void FormAll_Load(object sender, EventArgs e)
        {

            FormLogin myLogin = new FormLogin();
            myLogin.ShowDialog();

            lblTitle.Text = "首頁";
            lblLoginInfo.Text = $"ID：{GlobalVar.memberID}  姓名：{GlobalVar.strLoginName}";

            if (GlobalVar.strLoginName != "")
            {
                btnLogOut.Show();
            }
            if (GlobalVar.intPerms ==1)
            {
                btnCustomer.Hide();
                btnOrderDetail.Hide();
            }

        }

        private void btnFormPView_Click(object sender, EventArgs e)
        {
            btnFormPView.BackColor = Color.OldLace;
            btnFormPView.ForeColor= Color.Maroon;

            btnIndex.BackColor = Color.Maroon;
            btnIndex.ForeColor = Color.White;

            btnCustomer.BackColor = Color.Maroon;
            btnCustomer.ForeColor = Color.White;

            btnOrder.BackColor = Color.Maroon;
            btnOrder.ForeColor = Color.White;

            btnOrderDetail.BackColor = Color.Maroon;
            btnOrderDetail.ForeColor = Color.White;

            lblTitle.Text = "商品列表";
           
            FormProductsView FormProduct = new FormProductsView();
            FromShow(FormProduct);

        }

        internal void FromShow(Form ChildForm)
        {
            panel3.Controls.Clear();
            ChildForm.TopLevel = false; 
            ChildForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; 
            ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Controls.Add(ChildForm);
            ChildForm.Show();
           
        }
 
        private void btnIndex_Click(object sender, EventArgs e)
        {
            btnIndex.BackColor = Color.OldLace;
            btnIndex.ForeColor = Color.Maroon;

            btnFormPView.BackColor = Color.Maroon;
            btnFormPView.ForeColor = Color.White;

            btnCustomer.BackColor = Color.Maroon;
            btnCustomer.ForeColor = Color.White;

            btnOrder.BackColor = Color.Maroon;
            btnOrder.ForeColor = Color.White;

            btnOrderDetail.BackColor = Color.Maroon;
            btnOrderDetail.ForeColor = Color.White;

            lblTitle.Text = "首頁";

            Form1 FormView = new Form1();
            FromShow(FormView);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnIndex.BackColor = Color.Maroon;
            btnIndex.ForeColor = Color.White;

            btnFormPView.BackColor = Color.Maroon;
            btnFormPView.ForeColor = Color.White;

            btnCustomer.BackColor = Color.OldLace;
            btnCustomer.ForeColor = Color.Maroon;

            btnOrder.BackColor = Color.Maroon;
            btnOrder.ForeColor = Color.White;

            btnOrderDetail.BackColor = Color.Maroon;
            btnOrderDetail.ForeColor = Color.White;

            lblTitle.Text = "顧客資料";

            FormCustomers FormView = new FormCustomers();
            FromShow(FormView);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.OldLace;
            btnOrder.ForeColor = Color.Maroon;

            btnIndex.BackColor = Color.Maroon;
            btnIndex.ForeColor = Color.White;

            btnFormPView.BackColor = Color.Maroon;
            btnFormPView.ForeColor = Color.White;

            btnCustomer.BackColor = Color.Maroon;
            btnCustomer.ForeColor = Color.White;

            btnOrderDetail.BackColor = Color.Maroon;
            btnOrderDetail.ForeColor = Color.White;

            lblTitle.Text = "訂購餐點";

            FormOrder FormView = new FormOrder();
            FromShow(FormView);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.Maroon;
            btnOrder.ForeColor = Color.White;

            btnIndex.BackColor = Color.Maroon;
            btnIndex.ForeColor = Color.White;

            btnFormPView.BackColor = Color.Maroon;
            btnFormPView.ForeColor = Color.White;

            btnCustomer.BackColor = Color.Maroon;
            btnCustomer.ForeColor = Color.White;

            btnOrderDetail .BackColor= Color.OldLace;
            btnOrderDetail.ForeColor = Color.Maroon;

            lblTitle.Text = "訂單修改";

            FormOrderEdit FormView = new FormOrderEdit();
            FromShow(FormView);
        }
    }
}
