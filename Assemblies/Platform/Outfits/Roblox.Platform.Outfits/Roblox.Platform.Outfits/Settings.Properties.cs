using System.Configuration;

namespace Roblox.Outfits.Properties
{
    // Minimal Settings proxy to support legacy Settings.Default.RobloxOutfits usage
    internal sealed class Settings
    {
        private static readonly Settings _default = new Settings();
        public static Settings Default => _default;

        // Reads from standard .config connectionStrings entry named "RobloxOutfits"
        public string RobloxOutfits => ConfigurationManager.ConnectionStrings["RobloxOutfits"]?.ConnectionString;
    }
}
