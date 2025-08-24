using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public static class Helper
{
	internal static readonly string DBConnectionString = Settings.Default.dbConnectionString_RobloxModeration;

	public static bool IsSubmitAutoAbuseReportEnabled = true;
}
