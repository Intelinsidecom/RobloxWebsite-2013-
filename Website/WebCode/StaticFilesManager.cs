using System.Web;

namespace Roblox
{
    // Minimal stub used by Website/WebCode/StaticContent.cs
    public static class StaticFilesManager
    {
        public static string GetUrlByFileName(string virtualPath, HttpRequest request)
        {
            // For now, just resolve the app-relative URL to an absolute virtual path.
            return VirtualPathUtility.ToAbsolute(virtualPath);
        }
    }
}
