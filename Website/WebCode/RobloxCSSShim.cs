using System;
using System.Linq;
using System.Text;
using System.Web;
// Note: avoid 'using Roblox.Web.StaticContent;' to prevent namespace/type ambiguity with StaticContent

namespace Roblox.Web.Code
{
    // Development-time shim to render CSS bundles without relying on the
    // implementation inside the Roblox.Web.Code assembly.
    public static class RobloxCSSShim
    {
        // Back-compat: primary API returns string
        public static string RenderBundle(string name)
        {
            return RenderBundleHtml(name).ToHtmlString();
        }

        public static IHtmlString RenderBundleHtml(string name)
        {
            try
            {
                // Make sure BundleConfig has populated the bundle registry (dev-safety)
                global::Roblox.Web.StaticContent.StaticContent.EnsureBundlesRegistered();
                // Prefer emitting <link> tags to actual bundle files captured by StaticContent
                var files = global::Roblox.Web.StaticContent.StaticContent.GetCssBundleFiles(name);
                if (files != null && files.Count > 0)
                {
                    var sb = new StringBuilder();
                    foreach (var vpath in files)
                    {
                        var href = global::Roblox.Web.StaticContent.StaticContent.GetUrl(vpath);
                        sb.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"")
                          .Append(href)
                          .Append("\" />");
                    }
                    return new HtmlString(sb.ToString());
                }

                // Fallback: emit conservative core styles for known bundles if registry is empty
                if (!string.IsNullOrWhiteSpace(name))
                {
                    var sbFallback = new StringBuilder();
                    if (string.Equals(name, "reset", StringComparison.OrdinalIgnoreCase))
                    {
                        var href = global::Roblox.Web.StaticContent.StaticContent.GetUrl("~/CSS/YUIReset.css");
                        sbFallback.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"")
                                  .Append(href).Append("\" />");
                        return new HtmlString(sbFallback.ToString());
                    }
                    if (string.Equals(name, "main", StringComparison.OrdinalIgnoreCase))
                    {
                        string[] core = new[]
                        {
                            "~/CSS/Base/CSS/Roblox.css",
                            "~/CSS/Base/CSS/Header.css",
                            "~/CSS/Base/CSS/Footer.css",
                            "~/CSS/RBX2/CSS/Roblox.css"
                        };
                        foreach (var v in core)
                        {
                            var href = global::Roblox.Web.StaticContent.StaticContent.GetUrl(v);
                            sbFallback.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"")
                                      .Append(href).Append("\" />");
                        }
                        return new HtmlString(sbFallback.ToString());
                    }
                }
                // Last resort
                return new HtmlString($"<style>/* CSS bundle '{name}' (empty in dev) */</style>");
            }
            catch
            {
                return new HtmlString($"<!-- Failed to render CSS bundle '{name}' -->");
            }
        }

        // Back-compat: primary API returns string
        public static string Render(Roblox.Web.StaticContent.RobloxCssBundle bundle)
        {
            return RenderHtml(bundle).ToHtmlString();
        }

        public static IHtmlString RenderHtml(Roblox.Web.StaticContent.RobloxCssBundle bundle)
        {
            if (bundle == null) return new HtmlString(string.Empty);
            // Try to render recorded files for the page bundle
            try
            {
                global::Roblox.Web.StaticContent.StaticContent.EnsureBundlesRegistered();
                var pageFiles = global::Roblox.Web.StaticContent.StaticContent.GetCssBundleFiles("page");
                if (pageFiles != null && pageFiles.Count > 0)
                {
                    var sb = new StringBuilder();
                    foreach (var vpath in pageFiles)
                    {
                        var href = global::Roblox.Web.StaticContent.StaticContent.GetUrl(vpath);
                        sb.Append("<link rel=\"stylesheet\" type=\"text/css\" href=\"")
                          .Append(href)
                          .Append("\" />");
                    }
                    return new HtmlString(sb.ToString());
                }
            }
            catch { /* fallback below */ }

            // Fallback: inline whatever the bundle carried
            var css = bundle.Contents ?? string.Empty;
            return new HtmlString("<style>" + css + "</style>");
        }
    }
}
