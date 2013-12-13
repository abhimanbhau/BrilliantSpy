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
            if (Properties.Settings.Default.isFirstRun)
            {
                Properties.Settings.Default.isFirstRun = false;
                Properties.Settings.Default.Save();
                FirstRunForm firstRunForm = new FirstRunForm();
                Application.Run(firstRunForm);
            }
            else
            {
                SplashScreenForm form = new SplashScreenForm();
                Application.Run(form);
                if (form.isLogin)
                {
                    LoginForm loginForm = new LoginForm();
                    Application.Run(loginForm);
                    if (loginForm.getLoginStatus())
                    {
                        Application.Run(new MainWindowForm());
                    }
                }
            }
        }
    }
}
