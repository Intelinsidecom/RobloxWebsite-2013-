namespace Roblox.TextFilter;

/// <summary>
/// Wrapper class for the results of FilterLiveText call.
/// </summary>
internal class TextFilterResults : ITextFilterResults
{
	/// <summary>
	/// Did the operation complete successfully?
	/// </summary>
	public bool Success { get; set; }

	/// <summary>
	/// If the operation failed, message for why the operation failed.
	/// </summary>
	public string Message { get; set; }

	/// <summary>
	/// The result of filtering the text so that it is safe for users with age under 13
	/// </summary>
	public ITextFilterRuleResult AgeUnder13Result { get; set; }

	/// <summary>
	/// The result of filtering the text so that it is safe for users aged 13 and over
	/// </summary>
	public ITextFilterRuleResult Age13OrOverResult { get; set; }
}
