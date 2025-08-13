using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class SaleIPAddress : IRobloxEntity<int, SaleIPAddressDAL>, ICacheableObject<int>, ICacheableObject
{
	private SaleIPAddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(SaleIPAddress).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public int SaleID
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

	public int IPAddressID
	{
		get
		{
			return _EntityDAL.IPAddressID;
		}
		set
		{
			_EntityDAL.IPAddressID = value;
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

	public SaleIPAddress()
	{
		_EntityDAL = new SaleIPAddressDAL();
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
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static SaleIPAddress CreateNew(int saleid, int ipaddressid)
	{
		SaleIPAddress saleIPAddress = new SaleIPAddress();
		saleIPAddress.SaleID = saleid;
		saleIPAddress.IPAddressID = ipaddressid;
		saleIPAddress.Save();
		return saleIPAddress;
	}

	public static SaleIPAddress Get(int id)
	{
		return EntityHelper.GetEntity<int, SaleIPAddressDAL, SaleIPAddress>(EntityCacheInfo, id, () => SaleIPAddressDAL.Get(id));
	}

	public static SaleIPAddress GetSaleIPAddressBySaleID(int saleID)
	{
		string lookupID = $"SaleID:{saleID}";
		return EntityHelper.GetEntityByLookup<int, SaleIPAddressDAL, SaleIPAddress>(EntityCacheInfo, lookupID, () => SaleIPAddressDAL.GetSaleIPAddressBySaleID(saleID));
	}

	public static ICollection<SaleIPAddress> GetSaleIPAddressIDsByIPAddressID_Paged(int ipAddressID, int startRowIndex, int maxRows)
	{
		string collectionId = string.Format("GetSaleIPAddressIDsByIPAddressID_IPAddressID_StartRowIndex{1}_MaxRows{2}:{0}", ipAddressID, startRowIndex, maxRows);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"IPAddressID:{ipAddressID}"), collectionId, () => SaleIPAddressDAL.GetSaleIPAddressIDsByIPAddressID_Paged(ipAddressID, startRowIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter(int ipAddressID, DateTime startDate)
	{
		string countID = $"GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter_IPAddressID{ipAddressID}_StartDate:{startDate}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"IPAddressID:{ipAddressID}"), countID, () => SaleIPAddressDAL.GetTotalNumberOfSaleIPAddressIDsByIPAddressIDAndCreatedOnOrAfter(ipAddressID, startDate));
	}

	public void Construct(SaleIPAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"SaleID:{SaleID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"IPAddressID:{IPAddressID}");
	}
}
