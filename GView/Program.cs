﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new G_View());
        }
    }
}