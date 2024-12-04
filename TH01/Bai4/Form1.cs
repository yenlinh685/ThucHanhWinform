using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        private bool Validate(string first, string last)
        {
            if (!double.TryParse(first, out _) || !double.TryParse(last, out _))
            {
                MessageBox.Show("Vui lòng nhập số");
                return false;
            }
            return true;
        }

        private void Load()
        {
            List<RadioButton> radiolist = new List<RadioButton>()
           {
               radiobtnCong,
               radiobtnTru,
               radiobtnNhan,
               radiobtnChia,
           };
            foreach (RadioButton radio in radiolist)
            {
                radio.CheckedChanged += (sender, e) =>
                {
                    if (radio.Checked)
                    {
                        string firstNum = txtSo1.Text;
                        string lastNum = txtSo2.Text;
                        bool isValid = Validate(firstNum, lastNum);
                        if (isValid)
                        {
                            double num1 = double.Parse(firstNum);
                            double num2 = double.Parse(lastNum);
                            switch (radio.Name)
                            {
                                case "radiobtnCong": txtResult.Text = (num1 + num2).ToString(); break;
                                case "radiobtnTru": txtResult.Text = (num1 - num2).ToString(); break;
                                case "radiobtnNhan": txtResult.Text = (num1 * num2).ToString(); break;
                                case "radiobtnChia":
                                    if (num2 != 0)
                                        txtResult.Text = (num1 / num2).ToString();
                                    else
                                        MessageBox.Show("Không thể chia cho 0");
                                    break;
                                    
                            }
                        }
                    }
                };
            }
        }
    
    }
}
