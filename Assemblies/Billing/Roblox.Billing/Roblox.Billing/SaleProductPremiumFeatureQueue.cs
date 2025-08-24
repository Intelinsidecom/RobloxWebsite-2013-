using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class SaleProductPremiumFeatureQueue : IRobloxEntity<long, SaleProductPremiumFeatureQueueDAL>, ICacheableObject<long>, ICacheableObject
{
	private SaleProductPremiumFeatureQueueDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.SaleProductPremiumFeatureQueue", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SaleProductID
	{
		get
		{
			return _EntityDAL.SaleProductID;
		}
		set
		{
			_EntityDAL.SaleProductID = value;
		}
	}

	public bool PremiumFeatureGrantRequested
	{
		get
		{
			return _EntityDAL.PremiumFeatureGrantRequested;
		}
		set
		{
			_EntityDAL.PremiumFeatureGrantRequested = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SaleProductPremiumFeatureQueue()
	{
		_EntityDAL = new SaleProductPremiumFeatureQueueDAL();
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

	private static SaleProductPremiumFeatureQueue DoGet(long id)
	{
		return EntityHelper.DoGet<long, SaleProductPremiumFeatureQueueDAL, SaleProductPremiumFeatureQueue>(() => SaleProductPremiumFeatureQueueDAL.Get(id), id);
	}

	public static void GrantPremiumFeatures(ICollection<SaleProduct> saleProducts)
	{
		foreach (SaleProduct saleProduct in saleProducts)
		{
			try
			{
				if (saleProduct.RecipientAccountID.HasValue)
				{
					CreateNew(saleProduct);
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
	}

	public static SaleProductPremiumFeatureQueue CreateNew(SaleProduct saleProduct)
	{
		SaleProductPremiumFeatureQueue saleProductPremiumFeatureQueue = new SaleProductPremiumFeatureQueue();
		saleProductPremiumFeatureQueue.SaleProductID = saleProduct.ID;
		saleProductPremiumFeatureQueue.PremiumFeatureGrantRequested = false;
		saleProductPremiumFeatureQueue.Save();
		return saleProductPremiumFeatureQueue;
	}

	public static SaleProductPremiumFeatureQueue Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(SaleProductPremiumFeatureQueueDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		return new List<StateToken>();
	}
}
