using System;
using System.Windows.Forms;

namespace Data
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AuthorizationForm authForm = new AuthorizationForm();
            Application.Run(authForm);
            if (authForm.isStart)
            {
                Application.Run(new MainForm(authForm.Authentication.Connection));
            }
        }
    }
}
