﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (DataHelper.KiemTraKetNoi())
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new ConfigForm());
            }
        }
    }
}
