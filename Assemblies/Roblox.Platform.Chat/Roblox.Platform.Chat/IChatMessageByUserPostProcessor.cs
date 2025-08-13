using Roblox.Platform.Chat.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal interface IChatMessageByUserPostProcessor : IChatMessagePostProcessor
{
	IChatMessage ProcessMessageForSender(IUser senderUser, IChatMessageEntity chatMessageEntity);
}
