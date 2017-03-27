using System;
using System.Reflection;
using System.Windows.Forms;
using static TrayGenerator.Properties.Resources;

namespace TrayGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private KeyModifiers _modifier1;
        private KeyModifiers _modifier2;
        private Keys _settingKey;

        public Form()
        {
            InitializeComponent();
            Shown += Form_Shown;
            KeyPreview = true;

            _modifier1 = (KeyModifiers)Convert.ToInt32(Modifier1);
            _modifier2 = (KeyModifiers)Convert.ToInt32(Modifier2);
            _settingKey= (Keys)Convert.ToInt32(SettingKey);

            if (_settingKey != Keys.None)
            {
                HotKeyRegister(_settingKey, _modifier1, _modifier2);
            }
        }

        private void HotKeyRegister(Keys keys, KeyModifiers keyModifiers, KeyModifiers secondKeyModifiers = KeyModifiers.None)
        {
            var hkey = new HotKey(keys, keyModifiers, secondKeyModifiers);
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

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Program.NeedToClose;
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_settingKey != Keys.None)
            {
                HotKeyRegister(_settingKey, _modifier1, _modifier2);
            }
        }

        private void ModifierDropDown1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ModifierDropDown2.Enabled = true;
            _modifier1 = (KeyModifiers) ModifierDropDown1.SelectedValue;
            //todo: запилить сохранение настроек в хранилище
        }

        private void KeyDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _settingKey = (Keys) KeyDropDown.SelectedValue;
            //todo: запилить сохранение настроек в хранилище
        }

        private void ModifierDropDown2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _modifier2 = (KeyModifiers)ModifierDropDown2.SelectedValue;
            //todo: запилить сохранение настроек в хранилище
        }
    }
}
