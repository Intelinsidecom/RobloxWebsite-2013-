using System;
using System.Collections.Generic;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IChatMessageSender
{
	/// <summary>
	///
	/// </summary>
	/// <param name="senderUser"></param>
	/// <param name="rawContent"></param>
	/// <param name="conversationId"></param>
	/// <param name="platform"></param>
	/// <param name="decorators"></param>
	/// <returns></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException"></exception>
	ISentMessageDetails SendPlainTextChatMessage(IUser senderUser, string rawContent, long conversationId, IPlatform platform, IReadOnlyCollection<string> decorators);

	ISentMessageDetails SendGameLinkChatMessage(IUser senderUser, long conversationId, long universeId, IPlatform platform, IReadOnlyCollection<string> decorators);

	bool MarkAsRead(IUser currentUser, long conversationId, Guid? endMessageId = null);

	void MarkAsSeen(IUser seeingUser, long conversationId);
}
