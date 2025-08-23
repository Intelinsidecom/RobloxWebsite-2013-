namespace Roblox.Web.Code.Properties;

public interface ICookieConstraintSettings
{
	bool IsCookieConstraintEnabled { get; }

	string CookieConstraintCookieName { get; }

	string CookieConstraintPassword { get; }

	string CookieConstraintIpBypassRangeCsv { get; }

	bool IsGameServerCookieConstraintBypassEnabled { get; }
}
