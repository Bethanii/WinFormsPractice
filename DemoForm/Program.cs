using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DemoCode;
namespace DemoForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Animal per = new Animal();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDemoForm());


            string path = @"C:\Users\hambetn\source\repos\DemoWinFormsMar24\DemoForm\TextFile1.txt";
            StreamWriter sw1 = File.AppendText(path);
            Console.WriteLine(per.Type + " " + per.Name);
        }
    }
}
