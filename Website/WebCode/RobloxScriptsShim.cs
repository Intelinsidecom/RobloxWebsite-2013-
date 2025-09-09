using System;

namespace Roblox.Web.Code
{
    // Development-time shim to render JS bundles without relying on the
    // implementation inside the Roblox.Web.Code assembly.
    public static class RobloxScriptsShim
    {
        public static string RenderBundle(string name)
        {
            try
            {
                var result = RobloxScripts.CreateBundle(name, new string[0], false);
                var js = result?.Contents ?? string.Empty;
                if (string.IsNullOrWhiteSpace(js))
                {
                    js = $"/* JS bundle '{name}' (empty in dev) */";
                }
                return "<script>" + js + "</script>";
            }
            catch
            {
                return $"<!-- Failed to render JS bundle '{name}' -->";
            }
        }

        public static string Render(Roblox.Web.StaticContent.RobloxScriptBundle bundle)
        {
            if (bundle == null) return string.Empty;
            var js = bundle.Contents ?? string.Empty;
            return "<script>" + js + "</script>";
        }
    }
}
