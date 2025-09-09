namespace Roblox.Web.Code
{
    public static class SiteSettings
    {
        // Local toggles to replace external Roblox.WebsiteSettings dependency at app start
        public static bool MergeJavaScriptFiles { get; set; } = false;
        public static bool MergeCSS { get; set; } = false;
    }
}
