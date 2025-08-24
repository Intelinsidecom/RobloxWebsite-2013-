using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemListActivationTaskEntity : IRobloxEntity<long, GrantedItemListActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GrantedItemListActivationTaskDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(GrantedItemListActivationTaskEntity).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal byte GrantedItemTypeID
	{
		get
		{
			return _EntityDAL.GrantedItemTypeID;
		}
		set
		{
			_EntityDAL.GrantedItemTypeID = value;
		}
	}

	internal long PremiumFeatureActivationTaskID
	{
		get
		{
			return _EntityDAL.PremiumFeatureActivationTaskID;
		}
		set
		{
			_EntityDAL.PremiumFeatureActivationTaskID = value;
		}
	}

	internal Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	internal DateTime? Completed
	{
		get
		{
			return _EntityDAL.Completed;
		}
		set
		{
			_EntityDAL.Completed = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	internal DateTime? LeaseExpiration
	{
		get
		{
			return _EntityDAL.LeaseExpiration;
		}
		set
		{
			_EntityDAL.LeaseExpiration = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GrantedItemListActivationTaskEntity()
	{
		_EntityDAL = new GrantedItemListActivationTaskDAL();
	}

	public GrantedItemListActivationTaskEntity(GrantedItemListActivationTaskDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static GrantedItemListActivationTaskEntity Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedItemListActivationTaskDAL, GrantedItemListActivationTaskEntity>(EntityCacheInfo, id, () => GrantedItemListActivationTaskDAL.Get(id));
	}

	private static ICollection<GrantedItemListActivationTaskEntity> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, GrantedItemListActivationTaskDAL, GrantedItemListActivationTaskEntity>(ids, EntityCacheInfo, GrantedItemListActivationTaskDAL.MultiGet);
	}

	public static GrantedItemListActivationTaskEntity GetOrCreate(byte grantedItemTypeId, long premiumFeatureActivationTaskId)
	{
		return EntityHelper.GetOrCreateEntity<long, GrantedItemListActivationTaskEntity>(EntityCacheInfo, GetCacheQualifierByGrantedItemTypeIDPremiumFeatureActivationTaskID(grantedItemTypeId, premiumFeatureActivationTaskId), () => DoGetOrCreate(grantedItemTypeId, premiumFeatureActivationTaskId));
	}

	private static GrantedItemListActivationTaskEntity DoGetOrCreate(byte grantedItemTypeId, long premiumFeatureActivationTaskId)
	{
		return EntityHelper.DoGetOrCreate<long, GrantedItemListActivationTaskDAL, GrantedItemListActivationTaskEntity>(() => GrantedItemListActivationTaskDAL.GetOrCreateGrantedItemListActivationTask(grantedItemTypeId, premiumFeatureActivationTaskId));
	}

	public static ICollection<GrantedItemListActivationTaskEntity> LeaseTasks(byte grantedItemTypeId, Guid workerId, int leaseDurationInMinutes, int maxToLease)
	{
		List<GrantedItemListActivationTaskEntity> entities = new List<GrantedItemListActivationTaskEntity>();
		foreach (GrantedItemListActivationTaskDAL entityDal in GrantedItemListActivationTaskDAL.MultiGet(GrantedItemListActivationTaskDAL.LeaseTasks(grantedItemTypeId, workerId, leaseDurationInMinutes, maxToLease)))
		{
			if (entityDal != null)
			{
				GrantedItemListActivationTaskEntity entity = new GrantedItemListActivationTaskEntity(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(GrantedItemListActivationTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetCacheQualifierByGrantedItemTypeIDPremiumFeatureActivationTaskID(GrantedItemTypeID, PremiumFeatureActivationTaskID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByGrantedItemTypeIDPremiumFeatureActivationTaskID(byte grantedItemTypeId, long premiumFeatureActivationTaskId)
	{
		return $"GrantedItemTypeID:{grantedItemTypeId}_PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskId}";
	}

	private static string GetCacheQualifierByID(long id)
	{
		return $"ID:{id}";
	}
}
