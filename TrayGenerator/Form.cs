using System;
using System.Windows.Forms;

namespace TrayGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            Shown += Form_Shown;
            KeyPreview = true;
            HotKeyRegister(Keys.V, KeyModifiers.Shift);
        }

        private void HotKeyRegister(Keys keys, KeyModifiers keyModifiers)
        {
            var hkey = new HotKey(keys, keyModifiers);
            hkey.Pressed += (o, e) =>
            {
                Clipboard.SetText(DataGenerator.InnIp);
                if (NotificationIcon.ShowNotificationStrategy)
                {
                    NotificationIcon.ShowBalloonTip(2, "Буфер обновлен", "Сгенерирован ИНН для ИП", ToolTipIcon.Info);
                }
                e.Handled = true;
            };
            hkey.Register(this);
        }

        private static void Form_Shown(object sender, EventArgs e)
        {
            (sender as Form)?.Hide();
        }
    }
}
