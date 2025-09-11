using System.Web;

namespace Roblox.Web.Code
{
    // Default title provider used only when a page/layout hasn't set a title.
    public static class PageTitleProvider
    {
        public static string GetForRequest(HttpContext context)
        {
            // Always return the default; page-defined titles are respected elsewhere.
            return "ROBLOX.com";
        }
    }
}
