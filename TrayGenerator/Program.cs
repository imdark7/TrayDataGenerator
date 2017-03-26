using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    public static class Program
    {
        public static bool NeedToClose { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(NotificationIcon.Initialize());
        }
    }
}
