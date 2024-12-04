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

            Load();
        }

        private void Load()
        {
            List<RadioButton> radioButtons = new List<RadioButton>()
            {
                radiobtnVietnam,
                radioBtnItalian,
                radioBtnPhilipine,
                radioBtnUSA,
            };

            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.Click += (sender, e) =>
                {
                    flagPtb.Image = Image.FromFile(Application.StartupPath + "\\" + radioButton.Text + ".jpg");
                };
            }
        }
    }
}
