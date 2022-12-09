using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public FormOrder()
        {
            InitializeComponent();
            lblCustomer.Text= $"顧客姓名：{GlobalVar.strLoginName}";
            cBoxIce.Items.Add("姓名");
            comboBox1.Items.Add("電話");
            comboBox1.Items.Add("地址");
            comboBox1.Items.Add("Email");
            comboBox1.SelectedIndex = 0;
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

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
