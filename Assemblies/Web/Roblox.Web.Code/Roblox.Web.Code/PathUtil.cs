using System.Web;

namespace Roblox.Web.Code;

public class PathUtil
{
	public static string FullyQualifiedUrl(string virtualPath)
	{
		if (virtualPath == null)
		{
			return null;
		}
		HttpContext context = HttpContext.Current;
		if (context == null)
		{
			return virtualPath;
		}
		return $"{context.Request.Url.Scheme}://{context.Request.Url.Authority}{VirtualPathUtility.ToAbsolute(virtualPath)}";
	}
}
