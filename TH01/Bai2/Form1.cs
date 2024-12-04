using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string Hoten = txtHoten.Text.Trim();
            if (rad1.Checked == true)
                txtKQ.Text = Hoten.ToLower();
            if (rad2.Checked == true)
                txtKQ.Text = Hoten.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoten.Clear();
            txtKQ.Clear();
            rad1.Checked = true;
            txtHoten.Focus();

        }
    }
}
