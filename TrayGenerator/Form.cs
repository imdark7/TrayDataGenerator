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

        public Form()
        {
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
                SystemSounds.Hand.Play();
                e.Handled = true;
            };
            hkey.Register(this);
        }
    }
}
