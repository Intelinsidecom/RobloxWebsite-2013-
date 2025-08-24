using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal class UniverseScaleTypeEntityFactory : IUniverseScaleTypeEntityFactory, IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	public AvatarDomainFactories DomainFactories { get; }

	public UniverseScaleTypeEntityFactory(AvatarDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IUniverseScaleTypeEntity Get(byte id)
	{
		return CalToCachedMssql(UniverseScaleType.Get(id));
	}

	public IUniverseScaleTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(UniverseScaleType.GetByValue(value));
	}

	private static IUniverseScaleTypeEntity CalToCachedMssql(UniverseScaleType cal)
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
