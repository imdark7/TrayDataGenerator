using System;
using System.Threading;
using System.Windows.Forms;

namespace TrayGenerator
{
    public sealed class NotificationIcon
    {
        private NotifyIcon notifyIcon;
        private ContextMenu notificationMenu;

        #region Initialize icon and menu

        public NotificationIcon()
        {
            notifyIcon = new NotifyIcon();
            notificationMenu = new ContextMenu(InitializeMenu());

            notifyIcon.DoubleClick += IconDoubleClick;
            notifyIcon.Icon = Properties.Resources.MyIcon;
            notifyIcon.ContextMenu = notificationMenu;
        }

        private MenuItem[] InitializeMenu()
        {
            var menu = new[] {
                new MenuItem("Сгенерировать новый ИНН для ИП", MenuGenerateInnIp), 
                new MenuItem("About", menuAboutClick),
                new MenuItem("Exit", menuExitClick)
            };
            return menu;
        }

        #endregion


        private static Form _form1;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var notificationIcon = new NotificationIcon {notifyIcon = {Visible = true}};
            using (var form = new Form(notificationIcon.notifyIcon))
            {
                form.Shown += form_Shown;
                Application.Run(form);
            }
            notificationIcon.notifyIcon.Dispose();
        }

        #region Event Handlers

        private static void form_Shown(object sender, EventArgs e)
        {
            (sender as Form)?.Hide();
        }

        private static void MenuGenerateInnIp(object sender, EventArgs e)
        {
            Clipboard.SetText(DataGenerator.InnIp);
        }

        private void menuAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("About This Application");
        }

        private void menuExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconDoubleClick(object sender, EventArgs e)
        {
            if (_form1 == null || _form1.IsDisposed)
                _form1 = new Form(notifyIcon);
            if (!_form1.Visible)
                _form1.Show();
        }
        #endregion
    }
}
