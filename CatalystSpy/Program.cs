using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatalystSpy
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
            LoginPageForm form = new LoginPageForm();
            Application.Run(form);
            if (form.getLoginStatus())
            {
                Application.Run(new MainWindowForm());
            }

        }
    }
}
