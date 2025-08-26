namespace Roblox.Platform.TextFilter {
    interface ITextFilterMetricsTracker

{
	void RecordTextFilterResult(IModeratedTextRequest request, ITextFilterResultModerationDetails result, TextAudience? audience);
}


}
