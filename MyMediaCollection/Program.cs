using System;
using System.Windows.Forms;

namespace MyMediaCollection
{
    static class Program
    {
        //ToDo Need to add in method tests.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
