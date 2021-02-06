using System;
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
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);
            if (!result)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new Form1();
            Application.Run(form);
        }
    }
}
