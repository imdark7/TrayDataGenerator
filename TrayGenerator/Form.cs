using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using TrayGenerator.Helpers;

namespace TrayGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private KeyModifiers _modifier1;
        private KeyModifiers _modifier2;
        private Keys _settingKey;
        private HotKey _hotKey;
        private static readonly Configuration Cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        private readonly HotkeyConfigurationSection _section = Cfg.GetSection("AppHotkey") as HotkeyConfigurationSection;


        public Form()
        {
            InitializeComponent();

            Enum.TryParse(_section.HotkeyActiveCollection[0].Value, out _modifier1);
            Enum.TryParse(_section.HotkeyActiveCollection[1].Value, out _modifier2);
            Enum.TryParse(_section.HotkeyActiveCollection[2].Value, out _settingKey);

            InitializeSetting();

            if (_hotKey != null && _settingKey != Keys.None)
            {
                Shown += Form_Shown;
            }

            KeyPreview = true;

            Enum.TryParse(_section.HotkeyActiveCollection[0].Value, out _modifier1);
            Enum.TryParse(_section.HotkeyActiveCollection[1].Value, out _modifier2);
            Enum.TryParse(_section.HotkeyActiveCollection[2].Value, out _settingKey);
        }

        private void InitializeSetting()
        {

            if (_settingKey != Keys.None)
            {
                HotKeyRegister(_settingKey, _modifier1, _modifier2);
            }

            RefreshHotkeySettingsLabel();
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
            if ((KeyModifiers) ModifierDropDown1.SelectedValue != KeyModifiers.None)
            {
                ModifierDropDown2.Enabled = true;
            }
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
            if (_settingKey == Keys.None || _modifier1 == KeyModifiers.None) { return; }

            if (_hotKey != null) { HotKeyUnregister(); }

            HotKeyRegister(_settingKey, _modifier1, _modifier2);

            _section.HotkeyActiveCollection[0].Value = _modifier1.ToString();
            _section.HotkeyActiveCollection[1].Value = _modifier2.ToString();
            _section.HotkeyActiveCollection[2].Value = _settingKey.ToString();

            Cfg.Save();
            RefreshHotkeySettingsLabel();

            SaveHotkeyButton.BackColor = Color.LightGreen;
        }

        private void RefreshHotkeySettingsLabel()
        {
            if (_modifier1 == KeyModifiers.None && _settingKey == Keys.None)
            {
                InfoHotkeySettings.Text = @"не задан";
            } else if (_modifier1 != KeyModifiers.None && _modifier2 != KeyModifiers.None && _settingKey != Keys.None)
            {
                InfoHotkeySettings.Text = $@"{_modifier1} + {_modifier2} + {_settingKey}";
            } else if (_modifier1 != KeyModifiers.None && _settingKey != Keys.None)
            {
                InfoHotkeySettings.Text = $@"{_modifier1} + {_settingKey}";
            }
        }
    }
}
