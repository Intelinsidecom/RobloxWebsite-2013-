using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal class RecentItemListTypeEntityFactory : IRecentItemListTypeEntityFactory, IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	public AvatarDomainFactories DomainFactories { get; }

	public IRecentItemListTypeEntity Clothing => GetByValue("Clothing");

	public IRecentItemListTypeEntity BodyParts => GetByValue("BodyParts");

	public IRecentItemListTypeEntity AvatarAnimations => GetByValue("AvatarAnimations");

	public IRecentItemListTypeEntity Accessories => GetByValue("Accessories");

	public IRecentItemListTypeEntity Outfits => GetByValue("Outfits");

	public IRecentItemListTypeEntity Gear => GetByValue("Gear");

	public RecentItemListTypeEntityFactory(AvatarDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IRecentItemListTypeEntity Get(byte id)
	{
		return CalToCachedMssql(RecentItemListType.Get(id));
	}

	public IRecentItemListTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(RecentItemListType.GetByValue(value));
	}

	private static IRecentItemListTypeEntity CalToCachedMssql(RecentItemListType cal)
	{
		if (cal != null)
		{
			return new RecentItemListTypeCachedMssqlEntity
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
