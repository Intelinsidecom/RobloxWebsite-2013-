namespace Roblox.TextFilter;

/// <summary>
/// Parameters for requesting the filtering of text.
/// </summary>
public interface IModeratedTextRequest
{
	/// <summary>
	/// The textRequest to filter.
	/// </summary>
	string Text { get; }

	/// <summary>
	/// The user for which we are filtering the textRequest.
	/// </summary>
	ITextAuthor Author { get; }

	/// <summary>
	/// PlaceID or TextFilterServerType.WebChat, WebPost, WebAsset or WebPm
	/// </summary>
	string Server { get; }

	/// <summary>
	/// GameInstanceId or ConversationId. This can be optional for WebPost, WebAsset and WebPm
	/// </summary>
	string Room { get; }

	/// <summary>
	/// The client/requester of the filtering
	/// </summary>
	string Client { get; }

	/// <summary>
	/// Whether or to track detailed statistics for this client
	/// </summary>
	bool TrackDetailedClientStatistics { get; }
}
