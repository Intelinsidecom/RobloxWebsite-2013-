using System.Diagnostics.CodeAnalysis;
using System.Web;
using Roblox.FloodCheckers;
using Roblox.Platform.Authentication.Properties;

namespace Roblox.Platform.Authentication;

[ExcludeFromCodeCoverage]
internal class GlobalFailedLoginFloodChecker : FloodChecker
{
	private const string _KeyNamePrefix = "Roblox.Platform.Authentication.FailedLoginFloodChecker_AccountName:";

	public GlobalFailedLoginFloodChecker(string accountName)
		: base(BuildKeyName(accountName), Settings.Default.FailedLoginFloodCheck_FailureLimit, Settings.Default.FailedLoginFloodCheck_CoolOff)
	{
	}

	private static string BuildKeyName(string accountName)
	{
		string sanitizedAccountName = (string.IsNullOrWhiteSpace(accountName) ? string.Empty : HttpUtility.UrlEncode(accountName.ToLowerInvariant()));
		return "Roblox.Platform.Authentication.FailedLoginFloodChecker_AccountName:" + sanitizedAccountName;
	}
}
