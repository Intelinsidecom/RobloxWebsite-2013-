using System.Web;
using Roblox.Common;

namespace Roblox.Web.Authentication;

internal static class Extensions
{
	internal static bool OriginIpAddressIsValid(this RobloxAuthenticationCookie robloxAuthenticationCookie)
	{
		string originIpAddress = HttpContext.Current.GetOriginIP();
		return robloxAuthenticationCookie.IP == originIpAddress;
	}
}
