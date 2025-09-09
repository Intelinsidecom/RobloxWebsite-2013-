using System;

namespace Roblox.Web.Code
{
    // Development-time shim to render CSS bundles without relying on the
    // implementation inside the Roblox.Web.Code assembly.
    public static class RobloxCSSShim
    {
        public static string RenderBundle(string name)
        {
            try
            {
                var result = RobloxCSS.CreateBundle(name, new string[0], false);
                var css = result?.Contents ?? string.Empty;
                if (string.IsNullOrWhiteSpace(css))
                {
                    css = $"/* CSS bundle '{name}' (empty in dev) */";
                }
                return "<style>" + css + "</style>";
            }
            catch
            {
                return $"<!-- Failed to render CSS bundle '{name}' -->";
            }
        }

        public static string Render(Roblox.Web.StaticContent.RobloxCssBundle bundle)
        {
            if (bundle == null) return string.Empty;
            var css = bundle.Contents ?? string.Empty;
            return "<style>" + css + "</style>";
        }
    }
}
