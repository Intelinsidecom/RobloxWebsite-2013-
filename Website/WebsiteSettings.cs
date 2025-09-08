using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.WebsiteSettings.Properties
{
    public static class Settings
    {
        public static bool MergeJavaScriptFiles { get; set; } = false;
        public static bool MergeCSS { get; set; } = false;
        public static string ClientInstallHost { get; set; } = "localhost";
        public static bool IsUpdatedInstallationInstructionsModalEnabled { get; set; } = false;
        public static bool UseClientInstallerBrowserSwitch { get; set; } = false;
        public static bool IsGameLaunchAttemptLoggingEnabled { get; set; } = false;

        public static class Default
        {
            public static bool MergeJavaScriptFiles { get; set; } = Settings.MergeJavaScriptFiles;
            public static bool MergeCSS { get; set; } = Settings.MergeCSS;
            public static string ClientInstallHost { get; set; } = Settings.ClientInstallHost;
            public static bool IsUpdatedInstallationInstructionsModalEnabled { get; set; } = Settings.IsUpdatedInstallationInstructionsModalEnabled;
            public static bool UseClientInstallerBrowserSwitch { get; set; } = Settings.UseClientInstallerBrowserSwitch;
            public static bool IsGameLaunchAttemptLoggingEnabled { get; set; } = Settings.IsGameLaunchAttemptLoggingEnabled;
        }
    }

    public static class Layout
    {
        public static class Default
        {
            public static bool IsUpdatedInstallationInstructionsModalEnabled { get; set; } = false;
        }
    }

    public static class WebsiteBootstrapSettings
    {
        public static class Default
        {
            public static string GeneralEventLogSource { get; set; } = "Roblox";
            public static int GeneralEventLogLevel { get; set; } = 1;
        }
    }
}
