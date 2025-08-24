using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class SaleHold : IRobloxEntity<long, SaleHoldDAL>, ICacheableObject<long>, ICacheableObject
{
	private SaleHoldDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Currency.Entities.SaleHold", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public string RobuxHoldID
	{
		get
		{
			return _EntityDAL.RobuxHoldID;
		}
		set
		{
			_EntityDAL.RobuxHoldID = value;
		}
	}

	public string TicketsHoldID
	{
		get
		{
			return _EntityDAL.TicketsHoldID;
		}
		set
		{
			_EntityDAL.TicketsHoldID = value;
		}
	}

	internal long ProductID
	{
		get
		{
			return _EntityDAL.ProductID;
		}
		set
		{
			_EntityDAL.ProductID = value;
		}
	}

	public long? PriceInTickets
	{
		get
		{
			return _EntityDAL.PriceInTickets;
		}
		set
		{
			_EntityDAL.PriceInTickets = value;
		}
	}

	public long? PriceInRobux
	{
		get
		{
			return _EntityDAL.PriceInRobux;
		}
		set
		{
			_EntityDAL.PriceInRobux = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public SaleHold()
	{
		_EntityDAL = new SaleHoldDAL();
	}

	internal void Save()
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

	public static SaleHold CreateNew(long saleid, string robuxholdid, string ticketsholdid, long productid, long? priceinrobux, long? priceintickets)
	{
		SaleHold saleHold = new SaleHold();
		saleHold.SaleID = saleid;
		saleHold.RobuxHoldID = robuxholdid;
		saleHold.TicketsHoldID = ticketsholdid;
		saleHold.ProductID = productid;
		saleHold.PriceInTickets = priceintickets;
		saleHold.PriceInRobux = priceinrobux;
		saleHold.Save();
		return saleHold;
	}

	internal static SaleHold Get(long id)
	{
		return EntityHelper.GetEntity<long, SaleHoldDAL, SaleHold>(EntityCacheInfo, id, () => SaleHoldDAL.Get(id));
	}

	internal static SaleHold Get_NoLock(long id)
	{
		return EntityHelper.GetEntity<long, SaleHoldDAL, SaleHold>(EntityCacheInfo, id, () => SaleHoldDAL.Get_NoLock(id));
	}

	public static SaleHold GetByRobuxHoldID(string robuxHoldID)
	{
		return EntityHelper.GetEntityByLookup<long, SaleHoldDAL, SaleHold>(EntityCacheInfo, $"RobuxHoldID:{robuxHoldID}", () => SaleHoldDAL.GetByRobuxHoldID(robuxHoldID));
	}

	public static SaleHold GetByRobuxHoldID_NoLock(string robuxHoldID)
	{
		return EntityHelper.GetEntityByLookup<long, SaleHoldDAL, SaleHold>(EntityCacheInfo, $"RobuxHoldID:{robuxHoldID}", () => SaleHoldDAL.GetByRobuxHoldID_NoLock(robuxHoldID));
	}

	public static SaleHold GetByTicketsHoldID(string ticketsHoldID)
	{
		return EntityHelper.GetEntityByLookup<long, SaleHoldDAL, SaleHold>(EntityCacheInfo, $"TicketsHoldID:{ticketsHoldID}", () => SaleHoldDAL.GetByTicketsHoldID(ticketsHoldID));
	}

	public static ICollection<SaleHold> GetSaleHoldsByProductID(long ProductID)
	{
		string collectionId = $"GetSaleHoldsByProductID_ProductID:{ProductID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductID:{ProductID}"), collectionId, () => SaleHoldDAL.GetSaleHoldIDsByProductID(ProductID), Get);
	}

	public static ICollection<SaleHold> GetSaleHoldsByProductID(long productID, int count, long exclusiveStartSaleHoldID)
	{
		string collectionId = $"GetSaleHoldsByProductIDAcs_ProductID:{productID}_Count:{count}_ExclusiveStartSaleHoldID:{exclusiveStartSaleHoldID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductID:{productID}Count:{count}ExclusiveStartSaleHoldID:{exclusiveStartSaleHoldID}"), collectionId, () => SaleHoldDAL.GetSaleHoldIDsByProductID(productID, count, exclusiveStartSaleHoldID), Get);
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(SaleHoldDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"RobuxHoldID:{RobuxHoldID}";
		yield return $"TicketsHoldID:{TicketsHoldID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ProductID:{ProductID}");
	}
}
