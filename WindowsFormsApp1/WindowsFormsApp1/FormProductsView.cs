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
    public partial class FormProductsView : Form
    {
        string strMyPJDBConnectionString = "";
        List<string> listProductName = new List<string>();
        List<int> listProductPrice = new List<int>();
        List<int> listProductID = new List<int>();
        public FormProductsView()
        {
            InitializeComponent();
        }

        private void FormProductsView_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPicMode_Click(object sender, EventArgs e)
        {

        }
    }
}
