using System;
using System.Collections.Generic;
using Roblox.Platform.Chat.Events;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

public interface IChatEventStreamer
{
	void StreamEvents(IUser actingUser, ChatEventStreamContextType chatEventStreamContextType, Lazy<IReadOnlyCollection<long>> userIds, long conversationId);
}
