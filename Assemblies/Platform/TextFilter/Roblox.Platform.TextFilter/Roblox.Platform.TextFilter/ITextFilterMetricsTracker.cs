namespace Roblox.TextFilter;

internal interface ITextFilterMetricsTracker
{
	void RecordTextFilterResult(IModeratedTextRequest request, ITextFilterResultModerationDetails result, TextAudience? audience);
}
