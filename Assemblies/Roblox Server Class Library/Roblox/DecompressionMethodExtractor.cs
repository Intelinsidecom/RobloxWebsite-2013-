using System.Net;
using System.Web;

namespace Roblox;

internal static class DecompressionMethodExtractor
{
	internal static DecompressionMethods ParseAcceptEncoding(HttpRequest request)
	{
		return ParseAcceptEncoding(request.Headers["Accept-Encoding"], request.UserAgent);
	}

	internal static DecompressionMethods ParseAcceptEncoding(string acceptEncoding, string userAgent)
	{
		DecompressionMethods result = DecompressionMethods.None;
		if (acceptEncoding != null)
		{
			string[] array = acceptEncoding.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				string s = array[i].Trim().ToLower();
				if (s == "gzip")
				{
					result |= DecompressionMethods.GZip;
				}
				else if (s == "deflate")
				{
					result |= DecompressionMethods.Deflate;
				}
			}
		}
		else if (userAgent != null && userAgent.StartsWith("Roblox"))
		{
			result |= DecompressionMethods.GZip;
		}
		return result;
	}
}
