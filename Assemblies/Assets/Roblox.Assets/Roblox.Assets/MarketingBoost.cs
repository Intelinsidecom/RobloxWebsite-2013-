using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Assets;

[Obsolete]
public class MarketingBoost : IRobloxEntity<long, MarketingBoostDAL>, ICacheableObject<long>, ICacheableObject
{
	public delegate void EntityCreatedEventHandler(MarketingBoost sender, EventArgs e);

	public delegate void EntityUpdatedEventHandler(MarketingBoost sender, EventArgs e);

	private MarketingBoostDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(MarketingBoost).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	public long BoostAmount
	{
		get
		{
			return _EntityDAL.BoostAmount;
		}
		set
		{
			_EntityDAL.BoostAmount = value;
		}
	}

	public DateTime StartDate
	{
		get
		{
			return _EntityDAL.StartDate;
		}
		set
		{
			_EntityDAL.StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return _EntityDAL.EndDate;
		}
		set
		{
			_EntityDAL.EndDate = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityCreatedEventHandler EntityCreated;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public MarketingBoost()
	{
		_EntityDAL = new MarketingBoostDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
			OnEntityCreated(this, EventArgs.Empty);
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
			OnEntityUpdated(this, EventArgs.Empty);
		});
	}

	public static MarketingBoost CreateNew(long assetid, long boostamount, DateTime startdate, DateTime enddate)
	{
		MarketingBoost marketingBoost = new MarketingBoost();
		marketingBoost.AssetID = assetid;
		marketingBoost.BoostAmount = boostamount;
		marketingBoost.StartDate = startdate;
		marketingBoost.EndDate = enddate;
		marketingBoost.Save();
		return marketingBoost;
	}

	public static MarketingBoost Get(long id)
	{
		return EntityHelper.GetEntity<long, MarketingBoostDAL, MarketingBoost>(EntityCacheInfo, id, () => MarketingBoostDAL.Get(id));
	}

	public static MarketingBoost GetByAssetID(long assetID)
	{
		return EntityHelper.GetEntityByLookup<long, MarketingBoostDAL, MarketingBoost>(EntityCacheInfo, $"AssetID:{assetID}", () => MarketingBoostDAL.GetMarketingBoostByAssetID(assetID));
	}

	private static void OnEntityCreated(MarketingBoost entity, EventArgs e)
	{
		if (MarketingBoost.EntityCreated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				MarketingBoost.EntityCreated(entity, e);
			});
		}
	}

	private static void OnEntityUpdated(MarketingBoost entity, EventArgs e)
	{
		if (MarketingBoost.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				MarketingBoost.EntityUpdated(entity, e);
			});
		}
	}

	public void Construct(MarketingBoostDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
