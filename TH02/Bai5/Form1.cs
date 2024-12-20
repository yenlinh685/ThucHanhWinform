﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 65; i <= 90; i++) // Duyệt qua các chữ cái
            {
                string kt = ((char)i).ToString(); // chuyển từ số về ký tự và sang xâu
                PhoneBookTrv.Nodes.Add(kt, kt); // Thêm node vào Tree 
            }
        }

        private void AddNamebtn_Click(object sender, EventArgs e)
        {
            String key = FirstNametxb.Text.Trim()[0].ToString();
            PhoneBookTrv.Nodes[key].Nodes.Add(FirstNametxb.Text + " " + LastNametxb.Text);
        }
    }
}