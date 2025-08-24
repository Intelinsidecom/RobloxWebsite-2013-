using Roblox.Platform.Core;
using Roblox.Platform.Social.Follow.Entities;

namespace Roblox.Platform.Social.Follow;

public class FollowDomainFactories : DomainFactoriesBase
{
	internal virtual IFriendshipFactory FriendshipFactory { get; }

	internal virtual IUserFollowPrivacySettingEntityFactory FollowPrivacySettingEntityFactory { get; }

	public virtual IFollowPrivacySettingFactory FollowPrivacySettingFactory { get; }

	public virtual IFollowValidator FollowValidator { get; }

	public FollowDomainFactories(IFriendshipFactory friendshipFactory)
	{
		if (friendshipFactory == null)
		{
			throw new PlatformArgumentNullException("friendshipFactory");
		}
		FriendshipFactory = friendshipFactory;
		FollowPrivacySettingEntityFactory = new UserFollowPrivacySettingEntityFactory(this);
		FollowPrivacySettingFactory = new FollowPrivacySettingFactory(this);
		FollowValidator = new FollowValidator(this);
	}
}
