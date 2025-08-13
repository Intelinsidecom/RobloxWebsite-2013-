namespace Roblox.TextFilter;

/// <summary>
/// Results from filtering a Keyword.
/// Returns a value for both U13 and 13O.
/// </summary>
public interface IKeywordSearchQueryValidationResults
{
	/// <summary>
	/// Was the given user valid for users 13+?
	/// </summary>
	bool IsValid13Over { get; }

	/// <summary>
	/// Was the given user valid for users under 13?
	/// </summary>
	bool IsValidUnder13 { get; }
}
