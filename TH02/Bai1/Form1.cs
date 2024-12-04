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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int i = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            lblDongHo.Text = i.ToString();
            if (i <= 0)
                lblDongHo.Text = "Hết giờ!";
        }
    }
}
