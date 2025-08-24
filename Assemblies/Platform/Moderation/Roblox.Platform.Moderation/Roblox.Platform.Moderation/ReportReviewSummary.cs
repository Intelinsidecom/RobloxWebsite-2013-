namespace Roblox.Moderation;

internal class ReportReviewSummary
{
	private readonly bool _RequiresPunishmentReview;

	private readonly bool _WasAutoHandled;

	internal static readonly ReportReviewSummary AutoHandledNoPunishmentRequired = new ReportReviewSummary(wasAutoHandled: true, requiresPunishmentReview: false);

	internal static readonly ReportReviewSummary AutoHandledPunishmentRequired = new ReportReviewSummary(wasAutoHandled: true, requiresPunishmentReview: true);

	internal static readonly ReportReviewSummary NotAutoHandled = new ReportReviewSummary(wasAutoHandled: false, requiresPunishmentReview: false);

	internal bool RequiresPunishmentReview => _RequiresPunishmentReview;

	internal bool WasAutoHandled => _WasAutoHandled;

	private ReportReviewSummary(bool wasAutoHandled, bool requiresPunishmentReview)
	{
		_RequiresPunishmentReview = requiresPunishmentReview;
		_WasAutoHandled = wasAutoHandled;
	}
}
