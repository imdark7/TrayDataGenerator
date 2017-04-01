using System.Configuration;

namespace TrayGenerator.Helpers
{
    public class HotkeyConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("HotkeyActiveCollection")]
        public HotkeyActiveCollection HotkeyActiveCollection => (HotkeyActiveCollection) (base["HotkeyActiveCollection"]);
    }
}
