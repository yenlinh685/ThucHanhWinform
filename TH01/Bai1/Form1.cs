using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            this.txtUser.Clear(); this.txtPass.Clear(); this.txtUser.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += txtUser.Text;
            thongbao += "\n\rMật khẩu là: ";
            thongbao += txtPass.Text;
            if (cknho.Checked == true)
            { thongbao += "\n\rBạn có ghi nhớ."; }
            MessageBox.Show(thongbao, "Thông báo");
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
