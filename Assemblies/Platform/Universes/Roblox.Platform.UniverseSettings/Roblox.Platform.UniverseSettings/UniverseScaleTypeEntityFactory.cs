using Roblox.Platform.Core;

namespace Roblox.Platform.UniverseSettings;

internal class UniverseScaleTypeEntityFactory : IUniverseScaleTypeEntityFactory, IDomainFactory<UniverseSettingsDomainFactories>, IDomainObject<UniverseSettingsDomainFactories>
{
	public UniverseSettingsDomainFactories DomainFactories { get; }

	public UniverseScaleTypeEntityFactory(UniverseSettingsDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IUniverseScaleTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseScaleTypeEntity.Get(id));
	}

	public IUniverseScaleTypeEntity GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		return CalToCachedMssql(UniverseScaleTypeEntity.GetByValue(value));
	}

	private static IUniverseScaleTypeEntity CalToCachedMssql(UniverseScaleTypeEntity cal)
	{
		if (cal != null)
		{
			return new UniverseScaleTypeCachedMssqlEntity
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
