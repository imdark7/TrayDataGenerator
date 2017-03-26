using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            HotKeyRegister(Keys.X, KeyModifiers.Shift);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.C&&e.Control&&e.Shift)
            {
                MessageBox.Show(@"Test");
                e.Handled = true;
            }
        }

        private void HotKeyRegister(Keys keys, KeyModifiers keyModifiers)
        {
            var hkey = new HotKey(keys, keyModifiers);
            hkey.Pressed += (o, e) => { MessageBox.Show(@"Hello World!"); e.Handled = true; };
            hkey.Register(this);

        }
    }
}
