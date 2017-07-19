using System;
using System.Collections;
using System.Windows.Forms;

namespace TrayGenerator
{
    public static class NotificationIcon
    {
        private static NotifyIcon _notifyIcon;
        private static ContextMenu NotificationMenu => new ContextMenu(InitializeMenu());
        public static bool ShowNotificationStrategy;
        private static MainForm _mainForm;
        private static SettingsForm _mainSettingsForm;
        public static ArrayList DataArrayList = new ArrayList(18);

        public static SettingsForm Initialize()
        {
            _notifyIcon = new NotifyIcon
            {
                Visible = true,
                ContextMenu = NotificationMenu,
                Icon = Properties.Resources.MyIcon
            };
            _notifyIcon.DoubleClick += IconDoubleClick;
            _mainSettingsForm = new SettingsForm();
            return _mainSettingsForm;
        }

        private static MenuItem[] InitializeMenu()
        {
            if (ShowNotificationStrategy)
            {
                return new[]
                {
                    new MenuItem("Настроить хоткеи", SetHotkeys),
                    new MenuItem("Выключить уведомления", NotificationStrategySwitch),
                    new MenuItem("О программе", MenuAboutClick),
                    new MenuItem("Выйти", MenuExitClick)
                };
            }
            return new[]
            {
                new MenuItem("Настроить хоткеи", SetHotkeys),
                new MenuItem("Включить уведомления", NotificationStrategySwitch),
                new MenuItem("О программе", MenuAboutClick),
                new MenuItem("Выйти", MenuExitClick)
            };
        }

        private static void SetHotkeys(object sender, EventArgs e)
        {
            if (_mainSettingsForm == null || _mainSettingsForm.IsDisposed) { _mainSettingsForm = new SettingsForm(); }
            _mainSettingsForm.Show();
        }

        private static void NotificationStrategySwitch(object sender, EventArgs e)
        {
            ShowNotificationStrategy = !ShowNotificationStrategy;
            _notifyIcon.ContextMenu = new ContextMenu(InitializeMenu());
        }

        private static void MenuAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show(@"Это замечательное приложение умеет генерировать ИНН для ИП и ЮЛ по настраиваемой комбинации клавиш");
        }

        private static void MenuExitClick(object sender, EventArgs e)
        {
            Program.NeedToClose = true;
            Application.Exit();
        }

        private static void IconDoubleClick(object sender, EventArgs e)
        {
            if (_mainForm == null || _mainForm.IsDisposed) { _mainForm = new MainForm(); }
            _mainForm.Show();
        }

        public static void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            _notifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
        }

        public static void AddElementToDataArrayList(string text)
        {
            while (DataArrayList.Count > 13) { DataArrayList.RemoveAt(13); }
            DataArrayList.Insert(0, text);
            if (_mainForm != null && !_mainForm.IsDisposed) { _mainForm.RefreshListBox(); }
        }
    }
}