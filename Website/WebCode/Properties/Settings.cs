using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Web.Code.Properties
{
    public static class Settings
    {
        public static bool Default { get; set; } = true;
        public static bool MinifyCss { get; set; } = false;
        public static bool MinifyJavascript { get; set; } = false;
        public static bool IsCookieConstraintEnabled { get; set; } = false;
    }
}
