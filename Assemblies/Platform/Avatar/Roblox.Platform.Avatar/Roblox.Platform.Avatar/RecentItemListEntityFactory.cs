using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Avatar;

internal class RecentItemListEntityFactory : IRecentItemListEntityFactory, IDomainFactory<AvatarDomainFactories>, IDomainObject<AvatarDomainFactories>
{
	public AvatarDomainFactories DomainFactories { get; }

	public RecentItemListEntityFactory(AvatarDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IRecentItemListEntity Get(long id)
	{
		return CalToCachedMssql(RecentItemList.Get(id));
	}

	public IRecentItemListEntity GetOrCreate(long userId, byte recentItemListTypeId)
	{
		return CalToCachedMssql(RecentItemList.GetOrCreate(userId, recentItemListTypeId));
	}

	private static IRecentItemListEntity CalToCachedMssql(RecentItemList cal)
	{
		byte[] typeIds;
		long[] targetIds;
		DateTime[] dates;
		lock (cal.ReadWriteLock)
		{
			typeIds = cal.RecentItemTypeIDs.Clone() as byte[];
			targetIds = cal.TargetIDs.Clone() as long[];
			dates = cal.Dates.Clone() as DateTime[];
		}
		if (cal != null)
		{
			return new RecentItemListCachedMssqlEntity
			{
				Id = cal.ID,
				RecentItemListTypeId = cal.RecentItemListTypeID,
				UserId = cal.UserID,
				RecentItemTypeIds = typeIds,
				TargetIds = targetIds,
				Dates = dates,
				Revision = cal.Revision,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
