using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Follow;

internal class FollowValidator : IFollowValidator
{
	private FollowDomainFactories _Factories;

	public FollowValidator(FollowDomainFactories factories)
	{
		if (factories == null)
		{
			throw new PlatformArgumentNullException("factories");
		}
		_Factories = factories;
	}

	public bool CanFollow(IUser follower, IUser followed)
	{
		return CanFollow(follower, followed, _Factories.FriendshipFactory.AreFriends, _Factories.FriendshipFactory.HasFollower);
	}

	public bool CanFollow(IUser follower, IUser followed, Func<long, long, bool> areFriendsFunc, Func<long, long, bool> hasFollowerFunc)
	{
		if (followed == null || follower == null)
		{
			return false;
		}
		IFollowPrivacySetting followedPrivacySetting = _Factories.FollowPrivacySettingFactory.GetOrCreate(followed);
		switch (followedPrivacySetting.PrivacyType)
		{
		case FollowPrivacyType.All:
			return true;
		case FollowPrivacyType.NoOne:
		case FollowPrivacyType.Disabled:
			return false;
		case FollowPrivacyType.TopFriends:
		case FollowPrivacyType.Friends:
			return areFriendsFunc(follower.Id, followed.Id);
		case FollowPrivacyType.Following:
			if (!areFriendsFunc(follower.Id, followed.Id))
			{
				return hasFollowerFunc(follower.Id, followed.Id);
			}
			return true;
		case FollowPrivacyType.Followers:
			if (!areFriendsFunc(follower.Id, followed.Id) && !hasFollowerFunc(follower.Id, followed.Id))
			{
				return hasFollowerFunc(followed.Id, follower.Id);
			}
			return true;
		default:
			throw new PlatformException($"No implementation for follow privacy type {followedPrivacySetting.PrivacyType}");
		}
	}
}
