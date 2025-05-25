using System;
using System.Windows.Forms;

namespace kursach
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Настройка визуальных стилей
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var menuForm = new MainMenu();
            menuForm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(menuForm);
        }
    }
}