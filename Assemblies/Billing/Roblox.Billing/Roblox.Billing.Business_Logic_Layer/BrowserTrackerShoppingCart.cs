using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class BrowserTrackerShoppingCart : IRobloxEntity<int, BrowserTrackerShoppingCartDAL>, ICacheableObject<int>, ICacheableObject
{
	private BrowserTrackerShoppingCartDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.BrowserTrackerShoppingCart", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long BrowserTrackerID
	{
		get
		{
			return _EntityDAL.BrowserTrackerID;
		}
		set
		{
			_EntityDAL.BrowserTrackerID = value;
		}
	}

	public int ShoppingCartID
	{
		get
		{
			return _EntityDAL.ShoppingCartID;
		}
		set
		{
			_EntityDAL.ShoppingCartID = value;
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

	public BrowserTrackerShoppingCart()
	{
		_EntityDAL = new BrowserTrackerShoppingCartDAL();
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

	public static BrowserTrackerShoppingCart CreateNew(long browsertrackerid, int shoppingcartid)
	{
		BrowserTrackerShoppingCart browserTrackerShoppingCart = new BrowserTrackerShoppingCart();
		browserTrackerShoppingCart.BrowserTrackerID = browsertrackerid;
		browserTrackerShoppingCart.ShoppingCartID = shoppingcartid;
		browserTrackerShoppingCart.Save();
		return browserTrackerShoppingCart;
	}

	public static BrowserTrackerShoppingCart Get(int id)
	{
		return EntityHelper.GetEntity<int, BrowserTrackerShoppingCartDAL, BrowserTrackerShoppingCart>(EntityCacheInfo, id, () => BrowserTrackerShoppingCartDAL.Get(id));
	}

	public static BrowserTrackerShoppingCart GetByBrowserTrackerID(long browserTrackerId)
	{
		return EntityHelper.GetEntityByLookup<int, BrowserTrackerShoppingCartDAL, BrowserTrackerShoppingCart>(EntityCacheInfo, $"BrowserTrackerID:{browserTrackerId}", () => BrowserTrackerShoppingCartDAL.GetByBrowserTrackerID(browserTrackerId));
	}

	public void Construct(BrowserTrackerShoppingCartDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"BrowserTrackerID:{BrowserTrackerID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ShoppingCartID:{ShoppingCartID}");
	}
}
