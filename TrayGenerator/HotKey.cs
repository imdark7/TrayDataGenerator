using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TrayGenerator
{
    public class HotKey : IMessageFilter, IDisposable
    {
        #region Extern

        private const int WmHotkey = 0x312;
        private const int ErrorHotkeyAlreadyRegistered = 0x581;

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool RegisterHotKey(IntPtr hWnd, IntPtr id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool UnregisterHotKey(IntPtr hWnd, IntPtr id);
        #endregion

        private IntPtr _windowHandle;
        public event HandledEventHandler Pressed;

        public HotKey(Keys keyCode = Keys.None, KeyModifiers modifiers = KeyModifiers.None, KeyModifiers secondModifiers = KeyModifiers.None)
        {
            KeyCode = keyCode;
            Modifiers = modifiers;
            SecondModifiers = secondModifiers;
            Application.AddMessageFilter(this);
        }

        ~HotKey()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (IsRegistered)
                Unregister();

            _windowHandle = IntPtr.Zero;
            Modifiers = KeyModifiers.None;
            KeyCode = Keys.None;
            Tag = 0;
        }

        private bool OnPressed()
        {
            var e = new HandledEventArgs(false);
            Pressed?.Invoke(this, e);

            return e.Handled;
        }

        /// <summary>
        /// Filters out a message before it is dispatched.
        /// </summary>
        /// <param name="message">
        /// The message to be dispatched. You cannot modify this message.
        /// </param>
        /// <returns>
        /// true to filter the message and stop it from being dispatched;
        /// false to allow the message to continue to the next filter or control.
        /// </returns>
        public bool PreFilterMessage(ref Message message)
        {
            return message.Msg == WmHotkey && IsRegistered && (message.WParam == Guid && OnPressed());
        }

        /// <summary>
        /// Defines a system-wide hot key.
        /// </summary>
        /// <param name="program"></param>
        public void Register(Control program)
        {
            if (IsRegistered)
                throw new NotSupportedException("You cannot register a hotkey that is already registered");

            if (IsEmpty)
                throw new NotSupportedException("You cannot register an empty hotkey");

            if (program.IsDisposed)
                throw new ArgumentNullException(nameof(program));

            _windowHandle = program.Handle;

            if (!RegisterHotKey(_windowHandle, Guid, Modifiers, KeyCode))
            {
                if (Marshal.GetLastWin32Error() != ErrorHotkeyAlreadyRegistered)
                    throw new Win32Exception();
            }
            IsRegistered = true;
        }

        /// <summary>
        /// Frees a hot key previously registered by the calling thread.
        /// </summary>
        public void Unregister()
        {
            if (!IsRegistered)
            {
                return;
            }

            //todo: тут кидается исключение при закрытии программы, не могу разобраться в причинах
            if (!UnregisterHotKey(_windowHandle, Guid))
            {
                //throw new Win32Exception();
            }

            IsRegistered = false;
        }

        public bool HasModifier(KeyModifiers modifiers)
        {
            return (Modifiers & modifiers) != 0;
        }

        public static HotKey Parse(object content)
        {
            return content == null ? new HotKey() : Parse(content.ToString());
        }

        #region Fields

        private IntPtr Guid => new IntPtr((int)Modifiers << 16 | (int)KeyCode & 0xFFFF);

        public bool IsEmpty => KeyCode == Keys.None;

        public bool IsRegistered { get; private set; }

        public KeyModifiers Modifiers { get; private set; }

        public KeyModifiers SecondModifiers { get; private set; }
        
        public Keys KeyCode { get; private set; }

        public int Tag { get; set; }

        #endregion
    }
}
