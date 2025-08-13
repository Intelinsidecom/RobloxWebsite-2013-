using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class RobuxStipend : IRobloxEntity<long, RobuxStipendDAL>, ICacheableObject<long>, ICacheableObject
{
	private RobuxStipendDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "RobuxStipend", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	public byte RobuxStipendQuantityTypeID
	{
		get
		{
			return _EntityDAL.RobuxStipendQuantityTypeID;
		}
		set
		{
			_EntityDAL.RobuxStipendQuantityTypeID = value;
		}
	}

	public DateTime? LastAwarded
	{
		get
		{
			return _EntityDAL.LastAwarded;
		}
		set
		{
			_EntityDAL.LastAwarded = value;
		}
	}

	public DateTime Expiration
	{
		get
		{
			return _EntityDAL.Expiration;
		}
		set
		{
			_EntityDAL.Expiration = value;
		}
	}

	public DateTime? LeaseExpiration
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

	public Guid? WorkerID
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

	public DateTime? Completed
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public byte? RobuxStipendFrequencyTypeID
	{
		get
		{
			return _EntityDAL.RobuxStipendFrequencyTypeID;
		}
		set
		{
			_EntityDAL.RobuxStipendFrequencyTypeID = value;
		}
	}

	public DateTime? NextDistribution
	{
		get
		{
			return _EntityDAL.NextDistribution;
		}
		set
		{
			_EntityDAL.NextDistribution = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public RobuxStipend()
	{
		_EntityDAL = new RobuxStipendDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static RobuxStipend CreateNew(long accountId, RobuxStipendQuantityType robuxStipendQuantityType, byte? frequencyTypeId, DateTime expiration)
	{
		RobuxStipend robuxStipend = new RobuxStipend();
		robuxStipend.AccountID = accountId;
		robuxStipend.RobuxStipendQuantityTypeID = robuxStipendQuantityType.ID;
		robuxStipend.LastAwarded = null;
		robuxStipend.Expiration = expiration;
		robuxStipend.LeaseExpiration = null;
		robuxStipend.WorkerID = null;
		robuxStipend.Completed = null;
		robuxStipend.RobuxStipendFrequencyTypeID = frequencyTypeId;
		robuxStipend.NextDistribution = DateTime.Now;
		robuxStipend.Save();
		return robuxStipend;
	}

	public static ICollection<RobuxStipend> GetByAccountId(long accountId)
	{
		string collectionId = $"GetRobuxStipendByAccountID_AccountID:{accountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => RobuxStipendDAL.GetByAccountId(accountId), Get);
	}

	public static RobuxStipend Get(long id)
	{
		return EntityHelper.GetEntity<long, RobuxStipendDAL, RobuxStipend>(EntityCacheInfo, id, () => RobuxStipendDAL.Get(id));
	}

	internal static RobuxStipend Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<RobuxStipend> LeaseRobuxStipends(Guid workerId, int leaseDurationInMinutes, int numberOfItems)
	{
		List<RobuxStipend> entities = new List<RobuxStipend>();
		foreach (long id in RobuxStipendDAL.LeaseRobuxStipendsToAwardV2(workerId, numberOfItems, leaseDurationInMinutes))
		{
			try
			{
				RobuxStipendDAL entityDal = RobuxStipendDAL.Get(id);
				if (entityDal != null)
				{
					RobuxStipend entity = new RobuxStipend();
					entity.Construct(entityDal);
					CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
					entities.Add(entity);
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		return entities;
	}

	public static RobuxStipend LeaseRobuxStipend(long id, Guid workerId, int leaseDurationInMinutes)
	{
		RobuxStipendDAL entityDal = RobuxStipendDAL.LeaseRobuxStipendToAward(id, workerId, leaseDurationInMinutes);
		if (entityDal != null)
		{
			RobuxStipend robuxStipend = new RobuxStipend();
			robuxStipend.Construct(entityDal);
			CacheManager.ProcessEntityChange(robuxStipend, StateChangeEventType.Modification);
			return robuxStipend;
		}
		return null;
	}

	public void Construct(RobuxStipendDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountID:{AccountID}");
	}
}
