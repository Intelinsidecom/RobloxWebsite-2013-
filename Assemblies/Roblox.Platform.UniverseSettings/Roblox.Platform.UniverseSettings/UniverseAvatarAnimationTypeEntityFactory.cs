using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAvatarAnimationTypeEntityFactory : IUniverseAvatarAnimationTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarAnimationTypeEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseAvatarAnimationTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseAvatarAnimationTypeEntity.Get(id));
	}

	public IUniverseAvatarAnimationTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(UniverseAvatarAnimationTypeEntity.GetByValue(value));
	}

	private static IUniverseAvatarAnimationTypeEntity CalToCachedMssql(UniverseAvatarAnimationTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarAnimationTypeCachedMssqlEntity
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
