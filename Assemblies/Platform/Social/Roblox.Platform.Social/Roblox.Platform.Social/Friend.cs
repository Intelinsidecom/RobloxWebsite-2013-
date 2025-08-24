using System;

namespace Roblox.Platform.Social;

internal class Friend : IFriend
{
	public long UserId { get; set; }

	public DateTime FriendsSince { get; set; }
}
