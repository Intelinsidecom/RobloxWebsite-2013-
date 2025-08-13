using System.Diagnostics.CodeAnalysis;

namespace Roblox.CommunitySift;

/// <summary>
/// Default implementation of <see cref="T:Roblox.CommunitySift.ICommunitySiftDoubleChatRequest" />
/// </summary>
[ExcludeFromCodeCoverage]
public class CommunitySiftDoubleChatRequest : ICommunitySiftDoubleChatRequest
{
	/// <summary>
	/// ID of the author of the text to be filtered.
	/// </summary>
	public long UserId { get; }

	/// <summary>
	/// UserName of the author of the text to be filtered. Useful for Cs.
	/// </summary>
	public string UserName { get; }

	/// <summary>
	/// Text to be filtered.
	/// </summary>
	public string Text { get; }

	/// <summary>
	/// Category grouping for the source of the text.
	/// </summary>
	public string Server { get; }

	/// <summary>
	/// Subcategory grouping for the source of the text.
	/// </summary>
	public string Room { get; }

	/// <summary>
	/// Default Constructor.
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="userName"></param>
	/// <param name="text"></param>
	/// <param name="server"></param>
	/// <param name="room"></param>
	public CommunitySiftDoubleChatRequest(long userId, string userName, string text, string server, string room)
	{
		UserId = userId;
		UserName = userName;
		Text = text;
		Server = server;
		Room = room;
	}
}
