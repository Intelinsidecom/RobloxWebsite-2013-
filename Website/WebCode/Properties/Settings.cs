using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Web.Code.Properties
{
    public static class Settings
    {
        // Matches expected callsites like: Settings.Default.IsCookieConstraintEnabled
        public static class Default
        {
            public static bool IsCookieConstraintEnabled { get; set; } = false;
            public static bool MinifyCss { get; set; } = false;
            public static bool MinifyJavascript { get; set; } = false;
        }

        // Dev helper: when true, always load all JS files under ~/js/** regardless of bundles
        // Used by RobloxScriptsShim via alias CodeSettings.DevLoadAllScripts
        public static bool DevLoadAllScripts { get; set; } = false;
    }
}
