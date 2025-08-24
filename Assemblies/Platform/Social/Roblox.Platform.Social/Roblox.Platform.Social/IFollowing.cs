using System;

namespace Roblox.Platform.Social;

public interface IFollowing
{
	long? Id { get; }

	long UserId { get; }

	long FollowerUserId { get; }

	DateTime FollowerSince { get; }
}
