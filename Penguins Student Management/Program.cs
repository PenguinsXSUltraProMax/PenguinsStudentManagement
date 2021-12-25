using System;
using System.Windows.Forms;
using Penguins_Student_Management.Views;

namespace Penguins_Student_Management
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
            Application.Run(new SplashView());
        }
    }
}
