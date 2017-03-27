using System;

namespace TrayGenerator
{
    /// <summary>
    /// Specifies key modifiers.
    /// </summary>
    [Flags]
    public enum KeyModifiers : uint
    {
        /// <summary>
        /// Empty modifiers
        /// </summary>
        None = 0x0000,
        /// <summary>
        /// Either ALT key must be held down.
        /// </summary>
        Alt = 0x0001,
        /// <summary>
        /// Either CTRL key must be held down.
        /// </summary>
        Control = 0x0002,
        /// <summary>
        /// Either SHIFT key must be held down.
        /// </summary>
        Shift = 0x0004,
        /// <summary>
        /// Either WINDOWS key was held down. 
        /// These keys are labeled with the Windows logo. 
        /// Keyboard shortcuts that involve the WINDOWS key are reserved for use by the operating system.
        /// </summary>
        Windows = 0x0008,
        //IgnoreAllModifier   = 0x0400,
        //OnKeyUp             = 0x0800,
        //MouseRight          = 0x4000,
        //MouseLeft           = 0x8000,
    }
}
