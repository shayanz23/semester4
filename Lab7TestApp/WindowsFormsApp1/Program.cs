using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 7 Tester App. 
/// Author: Shayan Zahedanaraki
/// Date: March 20, 2023; Revision: -
/// Source:
/// EXternal Libraries:
/// </summary>
namespace WindowsFormsApp1
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
            Application.Run(new Form1());
        }
    }
}
