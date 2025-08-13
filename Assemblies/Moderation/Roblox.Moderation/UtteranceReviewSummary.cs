namespace Roblox.Moderation;

internal class UtteranceReviewSummary
{
	private readonly AbuseType _AbuseType;

	private readonly bool _IsBad;

	private readonly bool _WasAutoHandled;

	internal static readonly UtteranceReviewSummary AutoHandledIsBad = new UtteranceReviewSummary(wasAutoHandled: true, isBad: true);

	internal static readonly UtteranceReviewSummary AutoHandledIsGood = new UtteranceReviewSummary(wasAutoHandled: true, isBad: false);

	internal static readonly UtteranceReviewSummary NotAutoHandled = new UtteranceReviewSummary(wasAutoHandled: false, isBad: false);

	internal AbuseType AbuseType => _AbuseType;

	internal bool IsBad => _IsBad;

	internal bool WasAutoHandled => _WasAutoHandled;

	private UtteranceReviewSummary(bool wasAutoHandled, bool isBad)
	{
		_IsBad = isBad;
		_WasAutoHandled = wasAutoHandled;
	}

	internal UtteranceReviewSummary(bool wasAutoHandled, bool isBad, AbuseType abuseType)
	{
		_AbuseType = abuseType;
		_IsBad = isBad;
		_WasAutoHandled = wasAutoHandled;
	}
}
