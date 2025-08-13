namespace Roblox.TextFilter;

/// <summary>
/// Results from calling FilterText.
/// </summary>
public interface ITextFilterResults
{
	/// <summary>
	/// Did the operation complete successfully?
	/// </summary>
	bool Success { get; }

	/// <summary>
	/// If the operation failed, message for why the operation failed.
	/// </summary>
	string Message { get; }

	ITextFilterRuleResult AgeUnder13Result { get; }

	ITextFilterRuleResult Age13OrOverResult { get; }
}
