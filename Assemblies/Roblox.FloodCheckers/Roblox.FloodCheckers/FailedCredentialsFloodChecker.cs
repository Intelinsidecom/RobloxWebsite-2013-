using System.Web;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class FailedCredentialsFloodChecker : FloodChecker
{
	public FailedCredentialsFloodChecker(string username)
		: base(GetCacheKey(username), Settings.Default.FailedCredentialsFloodCheckLimit, Settings.Default.FailedCredentialsFloodCheckExpiry)
	{
	}

	private static string GetCacheKey(string userName)
	{
		string safeUserName = userName ?? string.Empty;
		safeUserName = HttpUtility.UrlEncode(safeUserName);
		return $"FailedCredentials_Username:{safeUserName}";
	}
}
