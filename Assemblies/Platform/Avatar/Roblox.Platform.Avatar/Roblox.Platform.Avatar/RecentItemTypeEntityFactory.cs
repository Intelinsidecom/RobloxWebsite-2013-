using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal class RecentItemTypeEntityFactory : IRecentItemTypeEntityFactory, IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	public AvatarDomainFactories DomainFactories { get; }

	public IRecentItemTypeEntity Asset => GetByValue("Asset");

	public IRecentItemTypeEntity Outfit => GetByValue("Outfit");

	public RecentItemTypeEntityFactory(AvatarDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IRecentItemTypeEntity Get(byte id)
	{
		return CalToCachedMssql(RecentItemType.Get(id));
	}

	public IRecentItemTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(RecentItemType.GetByValue(value));
	}

	private static IRecentItemTypeEntity CalToCachedMssql(RecentItemType cal)
	{
		if (cal != null)
		{
			return new RecentItemTypeCachedMssqlEntity
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
