using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ReflectionTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //--Init here:
            danteBus.Test.InitController.Init();

            Application.Run(new Form1());
        }
    }
}
