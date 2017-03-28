using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace TrayGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private KeyModifiers _modifier1;
        private KeyModifiers _modifier2;
        private Keys _settingKey;
        private HotKey _hotKey;

        public Form()
        {
            InitializeComponent();
            InitializeSetting();

            if (_hotKey != null && _settingKey != Keys.None)
            {
                Shown += Form_Shown;
            }

            KeyPreview = true;

            _modifier1 = (KeyModifiers)Convert.ToInt32(ConfigurationManager.AppSettings["Modifiers1"], 16);
            _modifier2 = (KeyModifiers)Convert.ToInt32(ConfigurationManager.AppSettings["Modifiers2"], 16);
            _settingKey = (Keys)Convert.ToInt32(ConfigurationManager.AppSettings["SettingKey"], 16);
        }

        private void InitializeSetting()
        {
            ModifierDropDown1.SelectedValue = (KeyModifiers)Convert.ToInt32(ConfigurationManager.AppSettings["Modifiers1"], 16);
            ModifierDropDown2.SelectedValue = (KeyModifiers)Convert.ToInt32(ConfigurationManager.AppSettings["Modifiers2"], 16);
            SettingKeyDropDown.SelectedValue = (Keys)Convert.ToInt32(ConfigurationManager.AppSettings["SettingKey"], 16);

            if (_settingKey != Keys.None)
            {
                HotKeyRegister(_settingKey, _modifier1, _modifier2);
            }
        }

        private void HotKeyRegister(Keys keys, KeyModifiers keyModifiers, KeyModifiers secondKeyModifiers = KeyModifiers.None)
        {
            _hotKey = new HotKey(keys, keyModifiers, secondKeyModifiers);
            _hotKey.Pressed += (o, e) =>
            {
                Clipboard.SetText(DataGenerator.InnIp);
                if (NotificationIcon.ShowNotificationStrategy)
                {
                    NotificationIcon.ShowBalloonTip(2, "Буфер обновлен", "Сгенерирован ИНН для ИП", ToolTipIcon.Info);
                }
                e.Handled = true;
            };
            _hotKey.Register(this);
        }

        private void HotKeyUnregister()
        {
            _hotKey.Unregister();
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

        private void ModifierDropDown1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ModifierDropDown2.Enabled = true;
            _modifier1 = (KeyModifiers) ModifierDropDown1.SelectedValue;
            SaveHotkeyButton.BackColor = Color.LightGray;
        }

        private void KeyDropDown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _settingKey = (Keys) SettingKeyDropDown.SelectedValue;
            SaveHotkeyButton.BackColor = Color.LightGray;
        }

        private void ModifierDropDown2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _modifier2 = (KeyModifiers)ModifierDropDown2.SelectedValue;
            SaveHotkeyButton.BackColor = Color.LightGray;
        }

        private void SaveHotkeyButton_Click(object sender, EventArgs e)
        {
            if (_settingKey == Keys.None) { return; }

            if (_hotKey != null) { HotKeyUnregister(); }

            HotKeyRegister(_settingKey, _modifier1, _modifier2);

            ConfigurationManager.AppSettings["Modifiers1"] = _modifier1.ToString();
            ConfigurationManager.AppSettings["Modifiers2"] = _modifier2.ToString();
            ConfigurationManager.AppSettings["SettingKey"] = _settingKey.ToString();

            SaveHotkeyButton.BackColor = Color.LightGreen;
        }
    }
}
