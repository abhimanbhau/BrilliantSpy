using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrilliantSpy
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
            LoginForm form = new LoginForm();
            Application.Run(form);
            if (form.getLoginStatus())
            {
                Application.Run(new MainWindowForm());
            }

        }
    }
}
