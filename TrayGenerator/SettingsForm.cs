using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using TrayGenerator.Helpers;

namespace TrayGenerator
{
    public partial class SettingsForm : Form
    {
        private static readonly Configuration Cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        
        public SettingsForm()
        {
            InitializeComponent();
            TopMost = true;

            Enum.TryParse(_ipSection.HotkeyActiveCollection[0].Value, out _ipModifier1);
            Enum.TryParse(_ipSection.HotkeyActiveCollection[1].Value, out _ipModifier2);
            Enum.TryParse(_ipSection.HotkeyActiveCollection[2].Value, out _ipSettingKey);

            Enum.TryParse(_ulSection.HotkeyActiveCollection[0].Value, out _ulModifier1);
            Enum.TryParse(_ulSection.HotkeyActiveCollection[1].Value, out _ulModifier2);
            Enum.TryParse(_ulSection.HotkeyActiveCollection[2].Value, out _ulSettingKey);

            InitializeSetting();

            if ((_ipHotKey != null && _ipSettingKey != Keys.None) || (_ulHotKey != null && _ulSettingKey != Keys.None))
            {
                Shown += Form_Shown;
            }

            KeyPreview = true;
        }

        private void InitializeSetting()
        {
            if (_ipSettingKey != Keys.None) { HotKeyIpRegister(_ipSettingKey, _ipModifier1, _ipModifier2); }
            if (_ulSettingKey != Keys.None) { HotKeyUlRegister(_ulSettingKey, _ulModifier1, _ulModifier2); }
            RefreshIpHotkeySettingsLabel();
            RefreshUlHotkeySettingsLabel();
        }

        private static void Form_Shown(object sender, EventArgs e)
        {
            (sender as SettingsForm)?.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Program.NeedToClose;
            Hide();
        }

        #region IpHotkey

        private KeyModifiers _ipModifier1;
        private KeyModifiers _ipModifier2;
        private Keys _ipSettingKey;
        private HotKey _ipHotKey;
        private readonly HotkeyConfigurationSection _ipSection = (HotkeyConfigurationSection)Cfg.GetSection("AppHotkeyIP");

        private void HotKeyIpRegister(Keys keys, KeyModifiers keyModifiers, KeyModifiers secondKeyModifiers = KeyModifiers.None)
        {
            _ipHotKey = new HotKey(keys, keyModifiers, secondKeyModifiers);
            _ipHotKey.Pressed += (o, e) =>
            {
                var inn = DataGenerator.InnIp;
                Clipboard.SetText(inn);
                if (NotificationIcon.ShowNotificationStrategy)
                {
                    NotificationIcon.ShowBalloonTip(2, "Буфер обновлен", "Сгенерирован ИНН для ИП", ToolTipIcon.Info);
                }
                NotificationIcon.AddElementToDataArrayList(inn);
                e.Handled = true;
            };
            _ipHotKey.Register(this);
        }

        private void HotKeyIpUnregister()
        {
            _ipHotKey.Unregister();
            _ipSection.HotkeyActiveCollection[0].Value = KeyModifiers.None.ToString();
            _ipSection.HotkeyActiveCollection[1].Value = KeyModifiers.None.ToString();
            _ipSection.HotkeyActiveCollection[2].Value = Keys.None.ToString();
            Cfg.Save();
        }

        private void ModifierDropDownIp1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((KeyModifiers) ModifierDropDownIp1.SelectedValue != KeyModifiers.None)
            {
                ModifierDropDownIp2.Enabled = true;
            }
            else
            {
                ModifierDropDownIp2.Enabled = false;
            }
            _ipModifier1 = (KeyModifiers)ModifierDropDownIp1.SelectedValue;
            SaveIpHotkeyButton.BackColor = Color.LightGray;
        }

        private void KeyDropDownIp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ipSettingKey = (Keys)SettingKeyDropDownIp.SelectedValue;
            SaveIpHotkeyButton.BackColor = Color.LightGray;
        }

        private void ModifierDropDownIp2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ipModifier2 = (KeyModifiers)ModifierDropDownIp2.SelectedValue;
            SaveIpHotkeyButton.BackColor = Color.LightGray;
        }

        private void SaveIpHotkeyButton_Click(object sender, EventArgs e)
        {
            if (_ipSettingKey == Keys.None || _ipModifier1 == KeyModifiers.None) { return; }

            if (_ipHotKey != null) { HotKeyIpUnregister(); }

            HotKeyIpRegister(_ipSettingKey, _ipModifier1, _ipModifier2);

            _ipSection.HotkeyActiveCollection[0].Value = _ipModifier1.ToString();
            _ipSection.HotkeyActiveCollection[1].Value = _ipModifier2.ToString();
            _ipSection.HotkeyActiveCollection[2].Value = _ipSettingKey.ToString();

            Cfg.Save();
            RefreshIpHotkeySettingsLabel();

            SaveIpHotkeyButton.BackColor = Color.LightGreen;
        }

        private void RefreshIpHotkeySettingsLabel()
        {
            if (_ipModifier1 == KeyModifiers.None && _ipSettingKey == Keys.None)
            {
                InfoHotkeySettingsIP.Text = @"не задан";
            }
            else if (_ipModifier1 != KeyModifiers.None && _ipModifier2 != KeyModifiers.None && _ipSettingKey != Keys.None)
            {
                InfoHotkeySettingsIP.Text = $@"{_ipModifier1} + {_ipModifier2} + {_ipSettingKey}";
            }
            else if (_ipModifier1 != KeyModifiers.None && _ipSettingKey != Keys.None)
            {
                InfoHotkeySettingsIP.Text = $@"{_ipModifier1} + {_ipSettingKey}";
            }
        }

        private void ResetHotkeyIp_Click(object sender, EventArgs e)
        {
            if(_ipHotKey != null) { HotKeyIpUnregister(); }
            _ipModifier1 = KeyModifiers.None;
            _ipModifier2 = KeyModifiers.None;
            _ipSettingKey = Keys.None;
            RefreshIpHotkeySettingsLabel();
            SaveIpHotkeyButton.BackColor = Color.LightGray;
        }

        #endregion

        #region UlHotkey

        private KeyModifiers _ulModifier1;
        private KeyModifiers _ulModifier2;
        private Keys _ulSettingKey;
        private HotKey _ulHotKey;
        private readonly HotkeyConfigurationSection _ulSection = (HotkeyConfigurationSection)Cfg.GetSection("AppHotkeyUL");

        private void HotKeyUlRegister(Keys keys, KeyModifiers keyModifiers, KeyModifiers secondKeyModifiers = KeyModifiers.None)
        {
            _ulHotKey = new HotKey(keys, keyModifiers, secondKeyModifiers);
            _ulHotKey.Pressed += (o, e) =>
            {
                var inn = DataGenerator.InnUl;
                Clipboard.SetText(inn);
                if (NotificationIcon.ShowNotificationStrategy)
                {
                    NotificationIcon.ShowBalloonTip(2, "Буфер обновлен", "Сгенерирован ИНН для ЮЛ", ToolTipIcon.Info);
                }
                NotificationIcon.AddElementToDataArrayList(inn);
                e.Handled = true;
            };
            _ulHotKey.Register(this);
        }

        private void HotKeyUlUnregister()
        {
            _ulHotKey.Unregister();
            _ulSection.HotkeyActiveCollection[0].Value = KeyModifiers.None.ToString();
            _ulSection.HotkeyActiveCollection[1].Value = KeyModifiers.None.ToString();
            _ulSection.HotkeyActiveCollection[2].Value = Keys.None.ToString();
            Cfg.Save();
        }

        private void ModifierDropDownUl1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((KeyModifiers)ModifierDropDownUl1.SelectedValue != KeyModifiers.None)
            {
                ModifierDropDownUl2.Enabled = true;
            }
            else
            {
                ModifierDropDownUl2.Enabled = false;
            }
            _ulModifier1 = (KeyModifiers)ModifierDropDownUl1.SelectedValue;
            SaveUlHotkeyButton.BackColor = Color.LightGray;
        }

        private void KeyDropDownUl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ulSettingKey = (Keys)SettingKeyDropDownUl.SelectedValue;
            SaveUlHotkeyButton.BackColor = Color.LightGray;
        }

        private void ModifierDropDownUl2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _ulModifier2 = (KeyModifiers)ModifierDropDownUl2.SelectedValue;
            SaveUlHotkeyButton.BackColor = Color.LightGray;
        }

        private void SaveUlHotkeyButton_Click(object sender, EventArgs e)
        {
            if (_ulSettingKey == Keys.None || _ulModifier1 == KeyModifiers.None) { return; }

            if (_ulHotKey != null) { HotKeyUlUnregister(); }

            HotKeyUlRegister(_ulSettingKey, _ulModifier1, _ulModifier2);

            _ulSection.HotkeyActiveCollection[0].Value = _ulModifier1.ToString();
            _ulSection.HotkeyActiveCollection[1].Value = _ulModifier2.ToString();
            _ulSection.HotkeyActiveCollection[2].Value = _ulSettingKey.ToString();

            Cfg.Save();
            RefreshUlHotkeySettingsLabel();

            SaveUlHotkeyButton.BackColor = Color.LightGreen;
        }

        private void RefreshUlHotkeySettingsLabel()
        {
            if (_ulModifier1 == KeyModifiers.None && _ulSettingKey == Keys.None)
            {
                InfoHotkeySettingsUL.Text = @"не задан";
            }
            else if (_ulModifier1 != KeyModifiers.None && _ulModifier2 != KeyModifiers.None && _ulSettingKey != Keys.None)
            {
                InfoHotkeySettingsUL.Text = $@"{_ulModifier1} + {_ulModifier2} + {_ulSettingKey}";
            }
            else if (_ulModifier1 != KeyModifiers.None && _ulSettingKey != Keys.None)
            {
                InfoHotkeySettingsUL.Text = $@"{_ulModifier1} + {_ulSettingKey}";
            }
        }

        private void ResetHotkeyUl_Click(object sender, EventArgs e)
        {
            if (_ulHotKey != null) { HotKeyUlUnregister(); }
            _ulModifier1 = KeyModifiers.None;
            _ulModifier2 = KeyModifiers.None;
            _ulSettingKey = Keys.None;
            RefreshUlHotkeySettingsLabel();
            SaveUlHotkeyButton.BackColor = Color.LightGray;
        }

        #endregion

    }
}
