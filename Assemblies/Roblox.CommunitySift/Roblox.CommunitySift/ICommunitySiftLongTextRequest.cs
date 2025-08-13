namespace Roblox.CommunitySift;

/// <summary>
/// Parameters required for making a long text request.
/// </summary>
public interface ICommunitySiftLongTextRequest
{
	/// <summary>
	/// ID of the author of the text to be filtered.
	/// </summary>
	long UserId { get; }

	/// <summary>
	/// UserName of the author of the text to be filtered. Useful for Cs.
	/// </summary>
	string UserName { get; }

	/// <summary>
	/// Age Category of the author of the text.
	/// </summary>
	bool IsUnder13 { get; }

	/// <summary>
	/// Text to be filtered.
	/// </summary>
	string Text { get; }

	/// <summary>
	/// Category grouping for the source of the text.
	/// </summary>
	string Server { get; }

	/// <summary>
	/// Subcategory grouping for the source of the text.
	/// </summary>
	string Room { get; }
}
