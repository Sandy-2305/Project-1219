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
            btnFormPView.BackColor = Color.SandyBrown;
            lblLoginInfo.Text = 
                $"ID：{GlobalVar.memberID}     " +
                $"姓名：{GlobalVar.strLoginName}";
        }

        private void btnFormPView_Click(object sender, EventArgs e)
        {
            btnFormPView.BackColor = Color.OldLace;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
