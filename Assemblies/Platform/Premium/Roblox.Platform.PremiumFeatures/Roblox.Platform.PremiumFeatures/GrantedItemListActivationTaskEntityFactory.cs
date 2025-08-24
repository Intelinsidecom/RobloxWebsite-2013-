using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
public class GrantedItemListActivationTaskEntityFactory : IGrantedItemListActivationTaskEntityFactory
{
	public IGrantedItemListActivationTaskEntity Get(long id)
	{
		return CalToCachedMssql(GrantedItemListActivationTaskEntity.Get(id));
	}

	public IGrantedItemListActivationTaskEntity GetOrCreate(byte grantedItemTypeId, long premiumFeatureActivationTaskId)
	{
		return CalToCachedMssql(GrantedItemListActivationTaskEntity.GetOrCreate(grantedItemTypeId, premiumFeatureActivationTaskId));
	}

	public ICollection<IGrantedItemListActivationTaskEntity> LeaseTasks(byte grantedItemTypeId, Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		if (leaseDurationInMinutes <= 0)
		{
			throw new ArgumentOutOfRangeException("leaseDurationInMinutes");
		}
		if (maxToLease <= 0)
		{
			throw new ArgumentOutOfRangeException("maxToLease");
		}
		return GrantedItemListActivationTaskEntity.LeaseTasks(grantedItemTypeId, workerId, leaseDurationInMinutes, maxToLease).Select(CalToCachedMssql).ToList();
	}

	private static IGrantedItemListActivationTaskEntity CalToCachedMssql(GrantedItemListActivationTaskEntity cal)
	{
		if (cal != null)
		{
			return new GrantedItemListActivationTaskCachedMssqlEntity
			{
				Id = cal.ID,
				GrantedItemTypeId = cal.GrantedItemTypeID,
				PremiumFeatureActivationTaskId = cal.PremiumFeatureActivationTaskID,
				WorkerId = cal.WorkerID,
				Completed = cal.Completed,
				Created = cal.Created,
				Updated = cal.Updated,
				LeaseExpiration = cal.LeaseExpiration
			};
		}
		return null;
	}
}
