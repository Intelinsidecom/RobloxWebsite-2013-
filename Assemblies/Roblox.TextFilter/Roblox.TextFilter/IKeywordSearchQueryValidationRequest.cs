namespace Roblox.TextFilter;

/// <summary>
/// Request for filtering a Keyword in a search query via the text filter.
/// </summary>
public interface IKeywordSearchQueryValidationRequest
{
	/// <summary>
	/// The Keyword to be filtering.
	/// </summary>
	string Keyword { get; }

	/// <summary>
	/// The user making the call.
	/// </summary>
	ITextAuthor Author { get; }
}
