using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Web.Code;
using Roblox.Web.StaticContent.Properties;
using static Roblox.StaticFilesManager;

namespace Roblox.Web.StaticContent
{
    public class RobloxScriptBundle
    {
        public string FileName { get; set; }
        public string Contents { get; set; }

        public RobloxScriptBundle(BundleCreationResult bundleResult)
        {
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
            FileName = bundleResult.FileName;
            Contents = bundleResult.Contents;
        }
    }

    public static class StaticContent
    {
        public static RobloxScriptBundle CreateScriptBundle(string name, params string[] files)
        {
            var bundleResult = Roblox.Web.Code.RobloxScripts.CreateBundle(
                name,
                files,
                Settings.Default.MinifyJavaScript
            );
            return new RobloxScriptBundle(bundleResult);
        }

        public static RobloxScriptBundle CreateScriptBundle(string name, ICollection<string> files)
        {
            var bundleResult = Roblox.Web.Code.RobloxScripts.CreateBundle(
                name,
                files,
                Settings.Default.MinifyJavaScript
            );
            return new RobloxScriptBundle(bundleResult);
        }

        public static RobloxScriptBundle GetPageScriptBundle()
        {
            if (Roblox.Web.Code.RobloxScripts.PageScripts.Count <= 0)
                return null;

            RobloxScriptBundle bundle = CreateScriptBundle("page", Roblox.Web.Code.RobloxScripts.PageScripts);
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
            var bundleResult = Roblox.Web.Code.RobloxCSS.CreateBundle(
                name,
                files,
                Settings.Default.MinifyCss
            );
            return new RobloxCssBundle(bundleResult);
        }

        public static RobloxCssBundle CreateCSSBundle(string name, ICollection<string> files)
        {
            // It must be like this, otherwise stack over blow :(
            // *whooosh*
            var bundleResult = Roblox.Web.Code.RobloxCSS.CreateBundle(
                name,
                files,
                Settings.Default.MinifyCss
            );
            return new RobloxCssBundle(bundleResult);
        }

        public static RobloxCssBundle GetPageCSSBundle()
        {
            if (Roblox.Web.Code.RobloxCSS.PageCSS.Count <= 0)
                return null;

            RobloxCssBundle bundle = CreateCSSBundle("page", Roblox.Web.Code.RobloxCSS.PageCSS);
            return bundle;
        }
    }
}
