using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class AbuseReportSubmissionFloodChecker : FloodChecker
{
	public AbuseReportSubmissionFloodChecker(long userId, string ipAddress)
		: base($"AbuseReportSubmissionFloodChecker_UserID:{userId}_IPAddress:{ipAddress}", Settings.Default.AbuseReportSubmissionFloodCheckLimit, Settings.Default.AbuseReportSubmissionFloodCheckTimeSpan)
	{
	}
}
