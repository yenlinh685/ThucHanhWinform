using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tinhUocSo(int num)
        {
            for (int i = 1;i<num; i++)
            {
                if (num % i == 0)
                {
                    ltbUocso.Items.Add(i);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string num = txtInput.Text;
            bool isValid = true;
            if(!int.TryParse(num, out _))
            {
                isValid = false;
                MessageBox.Show("Vui lòng nhập số");
            }
            if(isValid)
            {
                cbbhistoty.Items.Add(num);
            }
            tinhUocSo(Convert.ToInt32(num));
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;    
            foreach(var item in ltbUocso.Items)
            {
                sum += Convert.ToInt32(item.ToString());
            }
            MessageBox.Show($"Tổng các ước số là: {sum.ToString()}");
        }

        private void btnQuanityEven_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(var item in ltbUocso.Items)
            {
                if(Convert.ToInt32(item.ToString()) % 2 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show($"Số lượng các ước số dương là: {count.ToString()}");
        }

        private void btnQuanityPrime_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in ltbUocso.Items)
            {
                int num = Convert.ToInt32(item.ToString());
                bool isPrime = true;
                for(int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    count++;
                }
            }
            MessageBox.Show($"Số lượng các ước số nguyên tố là: {count} ");
        }
    }
}
