﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BridgeDetectSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK) {
                login.Close();
                Application.Run(new MainWin());
            }
        }
    }
}
