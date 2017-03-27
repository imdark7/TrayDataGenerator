using System;
using System.Windows.Forms;

namespace TrayGenerator.Helpers
{
    public static class HotkeyRewriter
    {
        public static KeyModifiers[] Modifiers { get; private set; }
        public static Keys Key { get; private set; }

        public static void ReadForHotkeys()
        {
            //todo: хочу читать нажатия клавиш и записывать их в настройки
        }

    }
}
