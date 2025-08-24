namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationRequest" />.
/// </summary>
public class KeywordSearchQueryValidationRequest : IKeywordSearchQueryValidationRequest
{
	/// <inheritdoc cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationRequest" />
	public string Keyword { get; }

	/// <inheritdoc cref="T:Roblox.TextFilter.IKeywordSearchQueryValidationRequest" />
	public ITextAuthor Author { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="keyword"></param>
	/// <param name="author"></param>
	public KeywordSearchQueryValidationRequest(string keyword, ITextAuthor author)
	{
		Keyword = keyword;
		Author = author;
	}
}
