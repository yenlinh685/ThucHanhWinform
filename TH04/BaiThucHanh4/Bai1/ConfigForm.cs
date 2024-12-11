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
    public partial class ConfigForm : Form
    {
        private bool isConfigSuccessfully = false;
        
        public ConfigForm()
        {
            InitializeComponent();

            string quyen;
            string SN;
            string DN;
            string PW;
            string UN;

            DataHelper.DocTep("config.txt", out quyen, out SN, out DN, out UN, out PW);
            if (quyen == "WD")
            {
                rdoWindow.Checked = true;
            }
            else
            {
                rdoWindow.Checked = false;
            }

            txttenmay.Text = SN;
            txtdata.Text = DN;
            txtUN.Text = UN;
            txtPW.Text = PW;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            string permission = "WD";

            List<RadioButton> radioBtns = new List<RadioButton>()
            {
                rdoWindow,
                rdoSA
            }; 

            foreach (RadioButton rdo in radioBtns)
            {
                if (rdo.Checked)
                {
                    permission = rdo.Tag.ToString(); 
                }
            }

            DataHelper.GhiTep("config.txt", permission, txttenmay.Text, txtdata.Text, txtUN.Text, txtPW.Text);

            if (DataHelper.KiemTraKetNoi())
            {
                MessageBox.Show("Kết nối thành công");
                isConfigSuccessfully = true;
            } else
            {
                MessageBox.Show("Kết nối thất bại");
                isConfigSuccessfully = false;
            }
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isConfigSuccessfully)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
