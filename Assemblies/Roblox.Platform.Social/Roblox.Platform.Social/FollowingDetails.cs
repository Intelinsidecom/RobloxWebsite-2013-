using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Social;

[ExcludeFromCodeCoverage]
internal class FollowingDetails : IFollowingDetails
{
	public long UserId1 { get; }

	public long UserId2 { get; }

	public bool User1FollowsUser2 { get; }

	public bool User2FollowsUser1 { get; }

	public FollowingDetails(long userId1, long userId2, bool user1FollowsUser2, bool user2FollowsUser1)
	{
		UserId1 = userId1;
		UserId2 = userId2;
		User1FollowsUser2 = user1FollowsUser2;
		User2FollowsUser1 = user2FollowsUser1;
	}
}
