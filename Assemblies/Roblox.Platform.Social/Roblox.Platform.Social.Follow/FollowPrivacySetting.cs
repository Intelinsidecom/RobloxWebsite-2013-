using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Social.Follow;

internal class FollowPrivacySetting : IFollowPrivacySetting
{
	private readonly FollowDomainFactories _DomainFactories;

	private IUser _User { get; }

	private FollowPrivacyType _DefaultPrivacyTypeForUnder13User { get; }

	private FollowPrivacyType _DefaultPrivacyTypeFor13PlusUser { get; }

	public FollowPrivacyType PrivacyType { get; private set; }

	public FollowPrivacySetting(FollowDomainFactories domainFactories, IUser user, FollowPrivacyType privacyType, FollowPrivacyType defaultForUnder13, FollowPrivacyType defaultFor13Plus)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		_DomainFactories = domainFactories;
		_User = user;
		PrivacyType = privacyType;
		_DefaultPrivacyTypeFor13PlusUser = defaultFor13Plus;
		_DefaultPrivacyTypeForUnder13User = defaultForUnder13;
	}

	public virtual bool SetPrivacyType(FollowPrivacyType privacyType)
	{
		if (!IsValid(privacyType))
		{
			return false;
		}
		UpdatePrivacyType(privacyType);
		return true;
	}

	public void Sanitize()
	{
		if (!IsValid(PrivacyType))
		{
			FollowPrivacyType defaultPrivacy = GetDefaultPrivacyForUser();
			UpdatePrivacyType(defaultPrivacy);
		}
	}

	internal virtual bool IsValid(FollowPrivacyType privacyType)
	{
		if (privacyType == FollowPrivacyType.Disabled || privacyType == FollowPrivacyType.TopFriends)
		{
			return false;
		}
		if (_User.IsUnder13())
		{
			if ((uint)(privacyType - 2) <= 1u || privacyType == FollowPrivacyType.Following)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	internal virtual FollowPrivacyType GetDefaultPrivacyForUser()
	{
		if (_User.IsUnder13())
		{
			return _DefaultPrivacyTypeForUnder13User;
		}
		return _DefaultPrivacyTypeFor13PlusUser;
	}

	private void UpdatePrivacyType(FollowPrivacyType newPrivacyType)
	{
		IUserFollowPrivacySettingEntity entity = _DomainFactories.FollowPrivacySettingEntityFactory.GetOrCreate(_User.Id, (byte)newPrivacyType);
		if (entity.FollowPrivacyTypeId != (byte)newPrivacyType)
		{
			entity.FollowPrivacyTypeId = (byte)newPrivacyType;
			entity.Update();
		}
		PrivacyType = newPrivacyType;
	}
}
