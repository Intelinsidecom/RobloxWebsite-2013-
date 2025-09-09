using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Web.Code
{
    public static class RobloxCSS
    {
        public static List<string> PageCSS { get; } = new List<string>();
        public static bool MergeFiles { get; set; } = false;

        public static BundleCreationResult CreateBundle(string virtualPath, bool minify = true)
        {
            // This would typically create a bundle of CSS files
            // For now, we'll return a mock implementation
            return new BundleCreationResult
            {
                FileName = "styles.css",
                Contents = "/* Bundled CSS content */",
                Url = "/bundles/styles.css"
            };
        }

        // Overload used by StaticContent to bundle a set of files
        public static BundleCreationResult CreateBundle(string name, IEnumerable<string> files, bool minify)
        {
            var contents = string.Join("\n", files ?? Enumerable.Empty<string>());
            return new BundleCreationResult
            {
                FileName = (name ?? "bundle") + ".css",
                Contents = contents,
                Url = "/bundles/" + (name ?? "bundle") + ".css"
            };
        }

        public static BundleCreationResult CreateBundle(string name, string[] files, bool minify)
        {
            return CreateBundle(name, (IEnumerable<string>)files, minify);
        }

        // Renders a named bundle reference. For development, we inline an empty or generated bundle as <style> to avoid extra HTTP requests.
        public static string RenderBundle(string name)
        {
            try
            {
                var result = CreateBundle(name, Array.Empty<string>(), minify: false);
                // If we eventually have a URL, we could emit a <link>. For now, inline contents to keep startup simple.
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

        // Renders a specific CSS bundle created via StaticContent.GetPageCSSBundle().
        public static string Render(Roblox.Web.StaticContent.RobloxCssBundle bundle)
        {
            if (bundle == null) return string.Empty;
            var css = bundle.Contents ?? string.Empty;
            return "<style>" + css + "</style>";
        }
    }
}
