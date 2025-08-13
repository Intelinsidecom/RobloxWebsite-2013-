namespace Roblox.CommunitySift;

/// <summary>
/// Basic interface for making a request to the CommunitySift UserName endpoint, which is currently used for search in Roblox.
/// </summary>
public interface ICommunitySiftUserNameRequest
{
	/// <summary>
	/// The text to be filtered.
	/// </summary>
	string Text { get; }

	/// <summary>
	/// Id of the user making the request. Use -1 for "anonymous" user.
	/// </summary>
	string UserId { get; }

	/// <summary>
	/// If the author of the text is under 13.
	/// </summary>
	bool IsUnder13 { get; }
}
