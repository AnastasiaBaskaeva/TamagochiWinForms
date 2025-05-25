using System;
using System.Windows.Forms;

namespace kursach
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var menuForm = new MainMenu();
            menuForm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(menuForm);
        }
    }
}