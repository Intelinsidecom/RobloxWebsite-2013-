using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAvatarCollisionTypeEntityFactory : IUniverseAvatarCollisionTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarCollisionTypeEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseAvatarCollisionTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseAvatarCollisionTypeEntity.Get(id));
	}

	public IUniverseAvatarCollisionTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(UniverseAvatarCollisionTypeEntity.GetByValue(value));
	}

	private static IUniverseAvatarCollisionTypeEntity CalToCachedMssql(UniverseAvatarCollisionTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarCollisionTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
