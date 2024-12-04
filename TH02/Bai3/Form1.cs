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

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = txtLastname.Text;
            string firstName = txtFirstname.Text;
            string phone = txtPhone.Text;
            if (lastName == "" || firstName == "" || phone == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                return;
            }
            ListViewItem item = new ListViewItem(lastName);

            item.SubItems.Add(firstName);
            item.SubItems.Add(phone);
            item.ImageIndex = 0;

            listView1.Items.Add(item);
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.GridLines = true ;
        }

        private void nongridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.GridLines = false;

        }
    }
}
