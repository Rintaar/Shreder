using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NonameThing_1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool logOut = false;
        public static SysInfo Info;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
