using System.Configuration;

namespace TrayGenerator.Helpers
{
    [ConfigurationCollection( typeof(HotkeyActiveElement))]
    public class HotkeyActiveCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new HotkeyActiveElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HotkeyActiveElement)element).Key;
        }

        public HotkeyActiveElement this[int idx] => (HotkeyActiveElement)BaseGet(idx);
    }
}