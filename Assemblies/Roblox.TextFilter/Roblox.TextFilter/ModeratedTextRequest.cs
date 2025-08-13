namespace Roblox.TextFilter;

/// <summary>
/// Default implementation of <see cref="T:Roblox.TextFilter.IModeratedTextRequest" />.
/// </summary>
public class ModeratedTextRequest : IModeratedTextRequest
{
	/// <summary>
	/// The textRequest to filter.
	/// </summary>
	public string Text { get; }

	/// <summary>
	/// The user for which we are filtering the textRequest.
	/// </summary>
	public ITextAuthor Author { get; }

	/// <summary>
	/// PlaceID or TextFilterServerType.WebChat, WebPost, WebAsset or WebPm
	/// </summary>
	public string Server { get; }

	/// <summary>
	/// GameInstanceId or ConversationId. This can be optional for WebPost, WebAsset and WebPm
	/// </summary>
	public string Room { get; }

	/// <summary>
	/// The client/requester of the filtering
	/// </summary>
	public string Client { get; }

	/// <summary>
	/// Whether or to track detailed statistics for this client
	/// </summary>
	public bool TrackDetailedClientStatistics { get; }

	/// <summary>
	/// Default constructor with required arguments.
	/// </summary>
	/// <param name="user"><see cref="P:Roblox.TextFilter.ModeratedTextRequest.Author" /><see cref="T:Roblox.TextFilter.TextAuthor" /> who is submitting this text.</param>
	/// <param name="text"><see cref="P:Roblox.TextFilter.ModeratedTextRequest.Text" />Original text value entered by the user.</param>
	/// <param name="server"><see cref="P:Roblox.TextFilter.ModeratedTextRequest.Server" /></param>
	/// <param name="room"><see cref="P:Roblox.TextFilter.ModeratedTextRequest.Room" /></param>
	public ModeratedTextRequest(ITextAuthor user, string text, string server = null, string room = null, string client = null, bool trackDetailedClientStatistics = false)
	{
		Author = user;
		Text = text;
		Server = server;
		Room = room;
		Client = client;
		TrackDetailedClientStatistics = trackDetailedClientStatistics;
	}
}
