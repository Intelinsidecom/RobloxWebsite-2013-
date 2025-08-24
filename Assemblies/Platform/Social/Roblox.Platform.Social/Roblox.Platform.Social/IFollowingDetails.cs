namespace Roblox.Platform.Social;

public interface IFollowingDetails
{
	long UserId1 { get; }

	long UserId2 { get; }

	bool User1FollowsUser2 { get; }

	bool User2FollowsUser1 { get; }
}
