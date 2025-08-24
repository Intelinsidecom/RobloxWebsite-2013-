using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Social.Follow.Entities;

[ExcludeFromCodeCoverage]
internal class UserFollowPrivacySettingEntityFactory : IUserFollowPrivacySettingEntityFactory, IDomainFactory<FollowDomainFactories>, IDomainObject<FollowDomainFactories>
{
	public FollowDomainFactories DomainFactories { get; }

	public UserFollowPrivacySettingEntityFactory(FollowDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IUserFollowPrivacySettingEntity Get(long id)
	{
		return CalToCachedMssql(UserFollowPrivacySetting.Get(id));
	}

	public virtual IUserFollowPrivacySettingEntity GetOrCreate(long userId, byte defaultPrivacyTypeId)
	{
		if (userId == 0L)
		{
			return null;
		}
		return CalToCachedMssql(UserFollowPrivacySetting.GetOrCreate(userId, defaultPrivacyTypeId));
	}

	private static IUserFollowPrivacySettingEntity CalToCachedMssql(UserFollowPrivacySetting cal)
	{
		if (cal != null)
		{
			return new UserFollowPrivacySettingCachedMssqlEntity
			{
				Id = cal.ID,
				UserId = cal.UserID,
				FollowPrivacyTypeId = (byte)cal.FollowPrivacyTypeID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
