using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using CodeSettings = Roblox.Web.Code.Properties.Settings;

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
                var ctx0 = HttpContext.Current;
                if (ctx0?.Response?.StatusCode >= 400)
                {
                    return string.Empty;
                }
                // Ensure bundle registry is populated
                global::Roblox.Web.StaticContent.StaticContent.EnsureBundlesRegistered();
                // If dev flag is on, ignore bundles and load all js
                if (CodeSettings.DevLoadAllScripts)
                {
                    var allDev = EnumerateAllJs();
                    if (allDev.Length > 0)
                    {
                        var sbDev = new StringBuilder();
                        var emittedDev = GetEmittedScriptsSet();
                        foreach (var v in allDev)
                        {
                            if (string.IsNullOrWhiteSpace(v)) continue;
                            if (!emittedDev.Add(v)) continue;
                            var src = global::Roblox.Web.StaticContent.StaticContent.GetUrl(v);
                            sbDev.Append("<script src=\"").Append(src).Append("\"></script>");
                        }
                        return sbDev.ToString();
                    }
                }
                var files = global::Roblox.Web.StaticContent.StaticContent.GetScriptBundleFiles(name);
                if (files != null && files.Count > 0)
                {
                    // Inline the compiled bundle to avoid enumerating many individual files
                    try
                    {
                        var filtered = files.Where(f => !IsMicrosoftAjaxScript(f)).ToArray();
                        var bundle = global::Roblox.Web.StaticContent.StaticContent.CreateScriptBundle(name, filtered);
                        var js = bundle?.Contents ?? string.Empty;
                        js = EscapeInlineScript(js);
                        return "<script>" + js + "</script>";
                    }
                    catch { /* fall back below */ }
                }

                // Fallback: include all JS files under ~/js (dev convenience)
                var allJs = EnumerateAllJs();
                if (allJs.Length > 0)
                {
                    var sbAll = new StringBuilder();
                    var emitted = GetEmittedScriptsSet();
                    foreach (var v in allJs)
                    {
                        if (string.IsNullOrWhiteSpace(v)) continue;
                        if (!emitted.Add(v)) continue; // skip duplicate
                        var src = global::Roblox.Web.StaticContent.StaticContent.GetUrl(v);
                        sbAll.Append("<script src=\"").Append(src).Append("\"></script>");
                    }
                    return sbAll.ToString();
                }

                // Last resort
                return $"<script>/* JS bundle '{name}' (empty in dev) */</script>";
            }
            catch
            {
                return $"<!-- Failed to render JS bundle '{name}' -->";
            }
        }

        public static string Render(Roblox.Web.StaticContent.RobloxScriptBundle bundle)
        {
            if (bundle == null) return string.Empty;
            // Try to render recorded files for the 'page' bundle
            try
            {
                var ctx1 = HttpContext.Current;
                if (ctx1?.Response?.StatusCode >= 400)
                {
                    return string.Empty;
                }
                global::Roblox.Web.StaticContent.StaticContent.EnsureBundlesRegistered();
                // If dev flag is on, ignore bundles and load all js
                if (CodeSettings.DevLoadAllScripts)
                {
                    var allDev = EnumerateAllJs();
                    if (allDev.Length > 0)
                    {
                        var sbDev = new StringBuilder();
                        var emittedDev = GetEmittedScriptsSet();
                        foreach (var v in allDev)
                        {
                            if (string.IsNullOrWhiteSpace(v)) continue;
                            if (!emittedDev.Add(v)) continue;
                            var src = global::Roblox.Web.StaticContent.StaticContent.GetUrl(v);
                            sbDev.Append("<script src=\"").Append(src).Append("\"></script>");
                        }
                        return sbDev.ToString();
                    }
                }
                var files = global::Roblox.Web.StaticContent.StaticContent.GetScriptBundleFiles("page");
                if (files != null && files.Count > 0)
                {
                    // Inline the compiled bundle for the page bundle
                    try
                    {
                        var filteredPage = files.Where(f => !IsMicrosoftAjaxScript(f)).ToArray();
                        var bundleBuilt = global::Roblox.Web.StaticContent.StaticContent.CreateScriptBundle("page", filteredPage);
                        var jsBuilt = bundleBuilt?.Contents ?? string.Empty;
                        jsBuilt = EscapeInlineScript(jsBuilt);
                        return "<script>" + jsBuilt + "</script>";
                    }
                    catch { /* fallback below */ }
                }
            }
            catch { /* fallback below */ }

            // Fallback to loading all JS under ~/js
            var all = EnumerateAllJs();
            if (all.Length > 0)
            {
                var sbAll = new StringBuilder();
                var emitted = GetEmittedScriptsSet();
                foreach (var v in all)
                {
                    if (string.IsNullOrWhiteSpace(v)) continue;
                    if (!emitted.Add(v)) continue; // skip duplicate
                    var src = global::Roblox.Web.StaticContent.StaticContent.GetUrl(v);
                    sbAll.Append("<script src=\"").Append(src).Append("\"></script>");
                }
                return sbAll.ToString();
            }

            var js = bundle.Contents ?? string.Empty;
            return "<script>" + js + "</script>";
        }

        private static string[] EnumerateAllJs()
        {
            try
            {
                var ctx = HttpContext.Current;
                if (ctx == null) return Array.Empty<string>();
                var root = ctx.Server.MapPath("~/js");
                if (string.IsNullOrEmpty(root) || !Directory.Exists(root)) return Array.Empty<string>();

                var files = Directory.GetFiles(root, "*.js", SearchOption.AllDirectories)
                    .Select(p => "~/js/" + p.Substring(root.Length).TrimStart('\\', '/').Replace("\\", "/"))
                    .ToList();

                // Order: jQuery first, then roblox.js, then others alpha
                var jquery = files.Where(f => f.IndexOf("jquery-", StringComparison.OrdinalIgnoreCase) >= 0 || f.IndexOf("/jquery.", StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                var roblox = files.Where(f => f.EndsWith("/roblox.js", StringComparison.OrdinalIgnoreCase)).ToList();
                var rest = files.Except(jquery).Except(roblox)
                                .OrderBy(f => f, StringComparer.OrdinalIgnoreCase)
                                .ToList();

                // De-duplicate while preserving order
                var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var ordered = jquery.Concat(roblox).Concat(rest)
                                    .Where(f => seen.Add(f))
                                    .ToArray();
                return ordered;
            }
            catch
            {
                return Array.Empty<string>();
            }
        }

        // Maintains a per-request set of emitted virtual paths to avoid duplicates across multiple calls.
        private static HashSet<string> GetEmittedScriptsSet()
        {
            var ctx = HttpContext.Current;
            if (ctx == null)
            {
                return new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            }
            const string key = "__RBX_EmittedScripts__";
            var set = ctx.Items[key] as HashSet<string>;
            if (set != null) return set;
            set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            ctx.Items[key] = set;
            return set;
        }

        // Prevent inline script blocks from being prematurely terminated by occurrences of </script
        private static string EscapeInlineScript(string js)
        {
            if (string.IsNullOrEmpty(js)) return string.Empty;
            // Replace any case variant of </script with </scr"+"ipt
            return Regex.Replace(js, "</script", "</scr\"+\"ipt", RegexOptions.IgnoreCase);
        }

        private static bool IsMicrosoftAjaxScript(string virtualPath)
        {
            if (string.IsNullOrEmpty(virtualPath)) return false;
            var v = virtualPath.ToLowerInvariant();
            return v.Contains("microsoftajax")
                || v.Contains("microsoftmvcajax")
                || v.Contains("microsoftmvcvalidation")
                || v.Contains("microsoftajaxwebforms");
        }
    }
}
