using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.UserSetting.Entities;

[ExcludeFromCodeCoverage]
internal class UserSettingEntityFactory : IUserSettingEntityFactory, IDomainFactory<UserSettingDomainFactories>, IDomainObject<UserSettingDomainFactories>
{
	public UserSettingDomainFactories DomainFactories { get; }

	public UserSettingEntityFactory(UserSettingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IUserSettingEntity Get(long id)
	{
		return CalToCachedMssql(UserSetting.Get(id));
	}

	public IUserSettingEntity GetOrCreate(long userId)
	{
		return CalToCachedMssql(UserSetting.GetOrCreate(userId));
	}

	private static IUserSettingEntity CalToCachedMssql(UserSetting cal)
	{
		if (cal != null)
		{
			return new UserSettingCachedMssqlEntity
			{
				Id = cal.ID,
				UserId = cal.UserID,
				CuratedGamesOnlyIsEnabled = cal.CuratedGamesOnlyIsEnabled,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
