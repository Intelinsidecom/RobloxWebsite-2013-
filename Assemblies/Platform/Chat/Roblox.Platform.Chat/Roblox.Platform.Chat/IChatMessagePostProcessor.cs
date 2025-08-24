using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal interface IChatMessagePostProcessor
{
	IChatMessage ProcessMessageForRecipient(IUser viewingUser, IChatMessageEntity chatMessageEntity, MessageStatus status, long conversationId);
}
