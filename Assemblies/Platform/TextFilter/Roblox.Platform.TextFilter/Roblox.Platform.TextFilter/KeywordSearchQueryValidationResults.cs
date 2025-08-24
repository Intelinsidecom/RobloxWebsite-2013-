namespace Roblox.TextFilter;

internal class KeywordSearchQueryValidationResults : IKeywordSearchQueryValidationResults
{
	public bool IsValid13Over { get; }

	public bool IsValidUnder13 { get; }

	public KeywordSearchQueryValidationResults(bool isValid13Over, bool isValidUnder13)
	{
		IsValid13Over = isValid13Over;
		IsValidUnder13 = isValidUnder13;
	}
}
