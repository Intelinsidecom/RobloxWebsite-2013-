using System.Diagnostics.CodeAnalysis;

namespace Roblox.CommunitySift;

/// <summary>
/// Default implementation of <see cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" /> for public consumption.
/// </summary>
[ExcludeFromCodeCoverage]
public class CommunitySiftChatNoContextRequest : ICommunitySiftChatNoContextRequest
{
	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public long UserId { get; }

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public string UserName { get; }

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public bool IsUnder13 { get; }

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public string Text { get; }

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public string Server { get; }

	/// <inheritdoc cref="T:Roblox.CommunitySift.ICommunitySiftChatNoContextRequest" />
	public string Room { get; }

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="userName"></param>
	/// <param name="isUnder13"></param>
	/// <param name="text"></param>
	/// <param name="server"></param>
	/// <param name="room"></param>
	public CommunitySiftChatNoContextRequest(long userId, string userName, bool isUnder13, string text, string server, string room)
	{
		UserId = userId;
		UserName = userName;
		IsUnder13 = isUnder13;
		Text = text;
		Server = server;
		Room = room;
	}
}
