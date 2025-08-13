namespace Roblox.CommunitySift;

/// <summary>
/// Parameters required for making a double chat request.
/// </summary>
public interface ICommunitySiftDoubleChatRequest
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
