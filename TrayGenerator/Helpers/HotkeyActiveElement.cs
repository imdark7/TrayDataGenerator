using System.Configuration;

namespace TrayGenerator.Helpers
{
    public class HotkeyActiveElement : ConfigurationElement
    {
        [ConfigurationProperty("key", IsKey = true, IsRequired = true)]
        public string Key
        {
            get { return (string) base["key"]; }
            set { base["key"] = value; }
        }

        [ConfigurationProperty("value", DefaultValue = "0x0000", IsKey = false, IsRequired = false)]
        public string Value
        {
            get { return (string) base["value"]; }
            set { base["value"] = value; }
        }
    }
}