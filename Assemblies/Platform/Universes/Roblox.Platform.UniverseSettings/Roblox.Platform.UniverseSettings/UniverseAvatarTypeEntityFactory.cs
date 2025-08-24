using Roblox.Platform.Core;
using Roblox.Platform.UniverseSettings.Entities;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseAvatarTypeEntityFactory : IUniverseAvatarTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories UniverseSettingsDomainFactories { get; }

	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseAvatarTypeEntityFactory(UniverseSettingsDomainFactories universeSettingsDomainFactories)
	{
		DomainFactories = universeSettingsDomainFactories ?? throw new PlatformArgumentNullException("universeSettingsDomainFactories");
	}

	public IUniverseAvatarTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseAvatarTypeEntity.Get(id));
	}

	public IUniverseAvatarTypeEntity GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		return CalToCachedMssql(UniverseAvatarTypeEntity.GetByValue(value));
	}

	private static IUniverseAvatarTypeEntity CalToCachedMssql(UniverseAvatarTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseAvatarTypeCachedMssqlEntity
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
