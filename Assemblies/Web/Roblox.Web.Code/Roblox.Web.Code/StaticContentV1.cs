using System.Web;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

/// <summary>
/// This class is used to upload static files to S3 and return the resulting URL (backed by CDN)
/// </summary>
public static class StaticContentV1
{
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
				ExceptionHandler.LogException("File name must begin with ~/ : " + fileName);
				return fileName;
			}
			return StaticFilesManager.GetUrlByFileName(fileName, HttpContext.Current.Request);
		}
		return VirtualPathUtility.ToAbsolute(fileName);
	}
}
