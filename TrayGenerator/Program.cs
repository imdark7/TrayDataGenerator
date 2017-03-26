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


        //private static Form1 _form1;
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool IsFirstInstance;
            using (Mutex myMutex = new Mutex(true, "TrayGenerator", out IsFirstInstance))
            {
                if (IsFirstInstance)
                {
                    var notificationIcon = new NotificationIcon {notifyIcon = {Visible = true}};
                    Application.Run();
                    notificationIcon.notifyIcon.Dispose();
                    HotKeyRegister(Keys.X, KeyModifiers.Shift);
                }
            }
            //var notifyIcon = new NotifyIcon {Icon = Properties.Resources.MyIcon};
            //notifyIcon.Click += NotifyIcon_Click;
            //notifyIcon.Visible = true;
            //Application.Run(new Form1());
        }

        //private static void NotifyIcon_Click(object sender, EventArgs e)
        //{
        //    if (_form1 == null || _form1.IsDisposed)
        //        _form1 = new Form1();
        //    if (!_form1.Visible)
        //        _form1.Show();
        //}

        #region Event Handlers

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
            MessageBox.Show("The icon was double clicked");
        }
        #endregion

        private static void HotKeyRegister(Keys keys, KeyModifiers keyModifiers)
        {
            var hkey = new HotKey(keys, keyModifiers);
            hkey.Pressed += (o, e) => { MessageBox.Show(@"Hello World!"); e.Handled = true; };
            //hkey.Register(this);

        }
    }
}
