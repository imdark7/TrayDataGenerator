using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrayGenerator
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly NotifyIcon _notifyIcon;


        public Form(NotifyIcon notifyIcon)
        {
            _notifyIcon = notifyIcon;
            InitializeComponent();
            this.KeyPreview = true;
            HotKeyRegister(Keys.V, KeyModifiers.Shift);
        }

        private void HotKeyRegister(Keys keys, KeyModifiers keyModifiers)
        {
            var hkey = new HotKey(keys, keyModifiers);
            hkey.Pressed += (o, e) =>
            {
                Clipboard.SetText(DataGenerator.InnIp);

                var toolTip = new ToolTip();
                
                _notifyIcon.ShowBalloonTip(2, "Буфер обновлен", "Сгенерирован ИНН для ИП", ToolTipIcon.Info);
                e.Handled = true;
            };
            hkey.Register(this);
        }
    }
}
