using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Concurrent;
using Roblox.Web.Code;
using Roblox.Web.StaticContent.Properties;
using static Roblox.StaticFilesManager;

namespace Roblox.Web.StaticContent
{
    internal static class BundleRegistry
    {
        private static readonly ConcurrentDictionary<string, List<string>> _cssBundles = new ConcurrentDictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        private static readonly ConcurrentDictionary<string, List<string>> _scriptBundles = new ConcurrentDictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        public static void SetCssBundle(string name, IEnumerable<string> files)
        {
            _cssBundles[name ?? string.Empty] = NormalizeCssFiles(files).ToList();
        }

        public static void SetScriptBundle(string name, IEnumerable<string> files)
        {
            _scriptBundles[name ?? string.Empty] = NormalizeScriptFiles(files).ToList();
        }

        public static IReadOnlyList<string> GetCssBundleFiles(string name)
        {
            if (name != null && _cssBundles.TryGetValue(name, out var files))
                return files;
            return Array.Empty<string>();
        }

        public static IReadOnlyList<string> GetScriptBundleFiles(string name)
        {
            if (name != null && _scriptBundles.TryGetValue(name, out var files))
                return files;
            return Array.Empty<string>();
        }

        private static IEnumerable<string> NormalizeCssFiles(IEnumerable<string> files)
        {
            foreach (var f in files ?? Enumerable.Empty<string>())
            {
                if (string.IsNullOrWhiteSpace(f)) continue;
                var file = f.Trim();
                // If explicit virtual path provided, keep as is
                if (file.StartsWith("~/")) { yield return file; continue; }
                if (file.StartsWith("/")) { yield return "~" + file; continue; }
                // If already rooted under CSS/, just add ~/
                if (file.StartsWith("CSS/", StringComparison.OrdinalIgnoreCase))
                {
                    yield return "~/" + file.Replace("\\", "/");
                    continue;
                }
                // Otherwise, treat as relative to /CSS/
                yield return "~/CSS/" + file.TrimStart('/');
            }
        }

        private static IEnumerable<string> NormalizeScriptFiles(IEnumerable<string> files)
        {
            foreach (var f in files ?? Enumerable.Empty<string>())
            {
                if (string.IsNullOrWhiteSpace(f)) continue;
                var file = f.Trim();
                if (file.StartsWith("~/")) { yield return file; continue; }
                if (file.StartsWith("/")) { yield return "~" + file; continue; }
                if (file.StartsWith("js/", StringComparison.OrdinalIgnoreCase) || file.StartsWith("JS/", StringComparison.OrdinalIgnoreCase))
                {
                    yield return "~/" + file.Replace("\\", "/");
                    continue;
                }
                // Default to /js/
                yield return "~/js/" + file.TrimStart('/');
            }
        }
    }

    public class RobloxScriptBundle
    {
        public string FileName { get; set; }
        public string Contents { get; set; }

        public RobloxScriptBundle(BundleCreationResult bundleResult)
        {
            if (bundleResult == null)
            {
                FileName = "bundle.js";
                Contents = string.Empty;
                return;
            }
            FileName = bundleResult.FileName;
            Contents = bundleResult.Contents;
        }
    }

    public class RobloxCssBundle
    {
        public string FileName { get; set; }
        public string Contents { get; set; }

        public RobloxCssBundle(BundleCreationResult bundleResult)
        {
            if (bundleResult == null)
            {
                FileName = "bundle.css";
                Contents = string.Empty;
                return;
            }
            FileName = bundleResult.FileName;
            Contents = bundleResult.Contents;
        }
    }

    public static class StaticContent
    {
        private static volatile bool _bundlesRegistered = false;

        public static void EnsureBundlesRegistered()
        {
            if (_bundlesRegistered) return;
            try
            {
                // Attempt to register bundles if Application_Start hasn't done so yet.
                Roblox.Website.BundleConfig.RegisterBundles();
                _bundlesRegistered = true;
            }
            catch
            {
                // Swallow – this is best-effort for dev
            }
        }

        public static RobloxScriptBundle CreateScriptBundle(string name, params string[] files)
        {
            var bundleResult = Roblox.Web.Code.RobloxScripts.CreateBundle(
                name,
                files,
                Settings.Default.MinifyJavaScript
            );
            // Record the files for rendering link/script tags in dev
            BundleRegistry.SetScriptBundle(name, files);
            _bundlesRegistered = true;
            return new RobloxScriptBundle(bundleResult);
        }

        public static RobloxScriptBundle CreateScriptBundle(string name, ICollection<string> files)
        {
            var bundleResult = Roblox.Web.Code.RobloxScripts.CreateBundle(
                name,
                files,
                Settings.Default.MinifyJavaScript
            );
            // Record the files for rendering script tags in dev
            BundleRegistry.SetScriptBundle(name, files);
            _bundlesRegistered = true;
            return new RobloxScriptBundle(bundleResult);
        }

        public static RobloxScriptBundle GetPageScriptBundle()
        {
            var files = Roblox.Web.Code.RobloxScripts.PageScripts.ToList();
            if (files.Count <= 0)
                return null;

            RobloxScriptBundle bundle = CreateScriptBundle("page", files);
            return bundle;
        }

        /// <summary>
        /// Returns CDN url for a static file
        /// </summary>
        public static string GetUrl(string fileName)
        {
            if (Settings.Default.PushStaticImagesToS3)
            {
                if (fileName.StartsWith("/"))
                {
                    fileName = "~" + fileName;
                }
                if (!fileName.StartsWith("~/"))
                {
                    // Log exception here if needed
                    return fileName;
                }
                return GetUrlByFileName(fileName, System.Web.HttpContext.Current.Request);
            }
            return System.Web.VirtualPathUtility.ToAbsolute(fileName);
        }

        // ROBLOX CSS //

        public static RobloxCssBundle CreateCSSBundle(string name, params string[] files)
        {
            var filesArr = files?.ToArray() ?? Array.Empty<string>();
            var bundleResult = Roblox.Web.Code.RobloxCSS.CreateBundle(
                name,
                filesArr,
                Settings.Default.MinifyCss
            );
            // Record the files for rendering link tags in dev
            BundleRegistry.SetCssBundle(name, filesArr);
            _bundlesRegistered = true;
            return new RobloxCssBundle(bundleResult);
        }

        public static RobloxCssBundle CreateCSSBundle(string name, ICollection<string> files)
        {
            // It must be like this, otherwise stack over blow :(
            // *whooosh*
            var filesArr = files?.ToArray() ?? Array.Empty<string>();
            var bundleResult = Roblox.Web.Code.RobloxCSS.CreateBundle(
                name,
                filesArr,
                Settings.Default.MinifyCss
            );
            // Record the files for rendering link tags in dev
            BundleRegistry.SetCssBundle(name, filesArr);
            return new RobloxCssBundle(bundleResult);
        }

        public static RobloxCssBundle GetPageCSSBundle()
        {
            var files = Roblox.Web.Code.RobloxCSS.PageCSS.ToList();
            if (files.Count <= 0)
                return null;

            RobloxCssBundle bundle = CreateCSSBundle("page", files);
            return bundle;
        }

        // Helpers for shims to render correct tags
        public static IReadOnlyList<string> GetCssBundleFiles(string name)
        {
            return BundleRegistry.GetCssBundleFiles(name);
        }

        public static IReadOnlyList<string> GetScriptBundleFiles(string name)
        {
            return BundleRegistry.GetScriptBundleFiles(name);
        }
    }
}
