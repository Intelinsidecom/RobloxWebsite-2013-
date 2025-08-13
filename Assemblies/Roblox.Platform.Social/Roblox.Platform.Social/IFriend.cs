using System;

namespace Roblox.Platform.Social;

public interface IFriend
{
	long UserId { get; }

	DateTime FriendsSince { get; }
}
