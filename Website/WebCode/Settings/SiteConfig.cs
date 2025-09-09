using System;
using System.IO;
using System.Web.Script.Serialization;

namespace Roblox.Web.Code
{
    public sealed class SiteConfigModel
    {
        public BundlingSettings Bundling { get; set; } = new BundlingSettings();
        public NavigationSettings Navigation { get; set; } = new NavigationSettings();
        public InstallerSettings Installer { get; set; } = new InstallerSettings();
        public AnalyticsSettings Analytics { get; set; } = new AnalyticsSettings();

        public sealed class BundlingSettings
        {
            public bool MergeJavaScriptFiles { get; set; } = false;
            public bool MergeCSS { get; set; } = false;
        }

        public sealed class NavigationSettings
        {
            public bool UseMvcNavBar { get; set; } = false;
        }

        public sealed class InstallerSettings
        {
            public bool UseUpdatedInstallationInstructionsModal { get; set; } = false;
            public string ClientInstallHost { get; set; } = "localhost";
        }

        public sealed class AnalyticsSettings
        {
            // Default disabled/empty; set in JSON e.g. "UA-11419793-2"
            public string GoogleAnalyticsAccountCode { get; set; } = "";
        }
    }

    public static class SiteConfig
    {
        private static readonly Lazy<SiteConfigModel> _current = new Lazy<SiteConfigModel>(Load, isThreadSafe: true);
        public static SiteConfigModel Current => _current.Value;

        private static SiteConfigModel Load()
        {
            try
            {
                // Resolve path: ~/App_Data/Configuration/site-settings.json
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                var path = Path.Combine(baseDir, "App_Data", "Configuration", "site-settings.json");
                if (File.Exists(path))
                {
                    var json = File.ReadAllText(path);
                    var serializer = new JavaScriptSerializer();
                    var model = serializer.Deserialize<SiteConfigModel>(json);
                    return model ?? new SiteConfigModel();
                }
            }
            catch
            {
                // fall through to defaults
            }
            return new SiteConfigModel();
        }
    }
}
