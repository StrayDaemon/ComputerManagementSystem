using ComputerManagementSYS_UI.FORMS;
using System;
using System.Windows.Forms;

namespace ComputerManagementSYS_UI
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

            // Show the loading form
            LoadingSplash loadingSplash = new LoadingSplash();
            loadingSplash.ShowDialog(); // Block until loading is complete

            // Then show the main form
            Application.Run(new LoginForm());
            //Application.Run(new DashboardForm());
        }
    }
}
