using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roblox.Web.Code
{
    public static class RobloxScripts
    {
        public static List<string> PageScripts { get; } = new List<string>();
        public static bool MergeFiles { get; set; } = false;

        public static BundleCreationResult CreateBundle(string virtualPath, bool minify = true)
        {
            // This would typically create a bundle of scripts
            // For now, we'll return a mock implementation
            return new BundleCreationResult
            {
                FileName = "scripts.js",
                Contents = "// Bundled scripts content",
                Url = "/bundles/scripts.js"
            };
        }

        // Overload used by StaticContent to bundle a set of files
        public static BundleCreationResult CreateBundle(string name, IEnumerable<string> files, bool minify)
        {
            var contents = string.Join("\n", files ?? Enumerable.Empty<string>());
            return new BundleCreationResult
            {
                FileName = (name ?? "bundle") + ".js",
                Contents = contents,
                Url = "/bundles/" + (name ?? "bundle") + ".js"
            };
        }

        public static BundleCreationResult CreateBundle(string name, string[] files, bool minify)
        {
            return CreateBundle(name, (IEnumerable<string>)files, minify);
        }
    }

    public class BundleCreationResult
    {
        public string FileName { get; set; }
        public string Contents { get; set; }
        public string Url { get; set; }
    }
}
