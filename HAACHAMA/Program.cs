﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HAACHAMA
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
            var form = new Form1();
            Application.Run(form);
            

            //for (; ; ) {
                // form.Show();
                // form.BringToFront();
                // form.Activate();
            //}
        }
    }
}
