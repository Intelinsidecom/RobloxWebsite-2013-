using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class GrantedItemEntityFactory : IGrantedItemEntityFactory
{
	public IGrantedItemEntity Get(long id)
	{
		return CalToCachedMssql(GrantedItemEntity.Get(id));
	}

	public IGrantedItemEntity Create(long grantedItemListId, byte grantedItemTypeId, long grantedItemTargetId)
	{
		GrantedItemEntity grantedItemEntity = new GrantedItemEntity();
		grantedItemEntity.GrantedItemListID = grantedItemListId;
		grantedItemEntity.GrantedItemTypeID = grantedItemTypeId;
		grantedItemEntity.GrantedItemTargetID = grantedItemTargetId;
		grantedItemEntity.Save();
		return CalToCachedMssql(grantedItemEntity);
	}

	public ICollection<IGrantedItemEntity> GetByGrantedItemListIdEnumerative(long grantedItemListId, int count, long? exclusiveStartId = null)
	{
		if (count < 1)
		{
			throw new ArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		return GrantedItemEntity.GetGrantedItemsByGrantedItemListID(grantedItemListId, count, exclusiveStartId).Select(CalToCachedMssql).ToArray();
	}

	private static IGrantedItemEntity CalToCachedMssql(GrantedItemEntity cal)
	{
		if (cal != null)
		{
			return new GrantedItemCachedMssqlEntity
			{
				Id = cal.ID,
				GrantedItemListId = cal.GrantedItemListID,
				GrantedItemTargetId = cal.GrantedItemTargetID,
				GrantedItemTypeId = cal.GrantedItemTypeID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
