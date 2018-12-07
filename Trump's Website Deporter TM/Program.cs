using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Trump_s_Website_Deporter_TM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
            {
                List<string> newURLs = new List<string>(MainForm.ProcessURLs(args));
                MainForm.WriteListToHosts(newURLs,true);
                //File.Delete(@"C:\Windows\PaExec.exe");
                Environment.Exit(0);
            }

        }
    }
}
