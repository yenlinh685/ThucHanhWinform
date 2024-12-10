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

namespace Bai1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string password = txbPassword.Text;

            string query = $@"
                SELECT
                  * 
                FROM
                  nhanvien 
                WHERE
                  tendangnhap = '{userName}' 
                  AND matkhau = '{password}'
            ";


            SqlDataReader reader = DataHelper.ExcuteReader(query);

            if (reader.HasRows)
            {
                StaffManager staffManager = new StaffManager();
                this.Hide();
                staffManager.ShowDialog();
                this.Show();

            } else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
