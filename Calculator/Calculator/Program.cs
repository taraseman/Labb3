using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
            //Application.Run(new FormCalc());

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 1)
            {
                Application.Run(new FormCalc());
            }
            else
            {
                Application.Run(new FormCalc(args));
            }
            Console.WriteLine("GetCommandLineArgs: {0}", string.Join(", ", args));
        }
    }
}
