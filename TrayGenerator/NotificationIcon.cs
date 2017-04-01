using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    public static class NotificationIcon
    {
        private static NotifyIcon _notifyIcon;
        private static ContextMenu NotificationMenu => new ContextMenu(InitializeMenu());
        public static bool ShowNotificationStrategy;
        private static Form _mainForm;
        
        public static Form Initialize()
        {
            _notifyIcon = new NotifyIcon
            {
                Visible = true,
                ContextMenu = NotificationMenu,
                Icon = Properties.Resources.MyIcon
            };
            _notifyIcon.DoubleClick += IconDoubleClick;
            _mainForm = new Form();
            return _mainForm;
        }

        private static MenuItem[] InitializeMenu()
        {
            if (ShowNotificationStrategy)
            {
                return new[]
                {
                    new MenuItem("��������� �����������", NotificationStrategySwitch),
                    new MenuItem("� ���������", MenuAboutClick),
                    new MenuItem("�����", MenuExitClick)
                };
            }
            return new[]
            {
                new MenuItem("�������� �����������", NotificationStrategySwitch),
                new MenuItem("� ���������", MenuAboutClick),
                new MenuItem("�����", MenuExitClick)
            };
        }

        private static void NotificationStrategySwitch(object sender, EventArgs e)
        {
            ShowNotificationStrategy = !ShowNotificationStrategy;
            _notifyIcon.ContextMenu = new ContextMenu(InitializeMenu());
        }

        private static void MenuAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show(@"��� ������������� ���������� ����� ������������ ��� ��� �� �� ������������� ���������� ������");
        }

        private static void MenuExitClick(object sender, EventArgs e)
        {
            Program.NeedToClose = true;
            Application.Exit();
        }

        private static void IconDoubleClick(object sender, EventArgs e)
        {
            if (_mainForm == null || _mainForm.IsDisposed)
                _mainForm = new Form();
            if (!_mainForm.Visible)
                _mainForm.Show();
        }

        public static void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            _notifyIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
        }
    }
}