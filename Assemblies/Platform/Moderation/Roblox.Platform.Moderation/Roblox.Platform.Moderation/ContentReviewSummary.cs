namespace Roblox.Moderation;

internal class ContentReviewSummary
{
	private readonly bool _MayDisseminate = true;

	private readonly bool _WarrantsAbuseReport;

	internal static ContentReviewSummary OK = new ContentReviewSummary(mayDisseminate: true, warrantsAbuseReport: false);

	internal static ContentReviewSummary BlockAndExcuse = new ContentReviewSummary(mayDisseminate: false, warrantsAbuseReport: false);

	internal static ContentReviewSummary BlockAndReport = new ContentReviewSummary(mayDisseminate: false, warrantsAbuseReport: true);

	internal bool MayDisseminate => _MayDisseminate;

	internal bool WarrantsAbuseReport => _WarrantsAbuseReport;

	internal ContentReviewSummary(bool mayDisseminate, bool warrantsAbuseReport)
	{
		_MayDisseminate = mayDisseminate;
		_WarrantsAbuseReport = warrantsAbuseReport;
	}
}
