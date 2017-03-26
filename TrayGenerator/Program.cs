using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    public sealed class Program
    {
        
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
