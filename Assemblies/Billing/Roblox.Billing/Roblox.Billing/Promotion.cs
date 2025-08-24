using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class Promotion : IRobloxEntity<short, PromotionDAL>, ICacheableObject<short>, ICacheableObject
{
	private PromotionDAL _EntityDAL;

	public static readonly Promotion GameStop2CardRedemption;

	public static readonly Promotion Walmart2CardRedemption;

	public static CacheInfo EntityCacheInfo;

	public short ID => _EntityDAL.ID;

	public int ProductID
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

	public string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public decimal DiscountedPrice
	{
		get
		{
			return _EntityDAL.DiscountedPrice;
		}
		set
		{
			_EntityDAL.DiscountedPrice = value;
		}
	}

	public bool Active
	{
		get
		{
			return _EntityDAL.Active;
		}
		set
		{
			_EntityDAL.Active = value;
		}
	}

	public byte? CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
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

	public Promotion()
	{
		_EntityDAL = new PromotionDAL();
	}

	static Promotion()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.Promotion", isNullCacheable: true);
		GameStop2CardRedemption = Get("GameStop2CardRedemption");
		Walmart2CardRedemption = Get("Walmart2CardRedemption");
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

	public static Promotion CreateNew(int productid, string name, string description, decimal discountedprice, bool active, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		Promotion promotion = new Promotion();
		promotion.ProductID = productid;
		promotion.Name = name;
		promotion.Description = description;
		promotion.DiscountedPrice = discountedprice;
		promotion.Active = active;
		promotion.CurrencyTypeID = currencyTypeID;
		promotion.Save();
		return promotion;
	}

	public static Promotion Get(short id)
	{
		return EntityHelper.GetEntity<short, PromotionDAL, Promotion>(EntityCacheInfo, id, () => PromotionDAL.Get(id));
	}

	public static Promotion Get(string name)
	{
		return EntityHelper.GetEntityByLookupOld<short, Promotion>(EntityCacheInfo, $"Name:{name}", () => DoGet(name));
	}

	private static Promotion DoGet(string name)
	{
		return EntityHelper.DoGetByLookup<short, PromotionDAL, Promotion>(() => PromotionDAL.Get(name), $"Name:{name}");
	}

	public static ICollection<Promotion> GetPromotionsByProductID(int ProductID)
	{
		string collectionId = $"GetPromotionsByProductID_ProductID:{ProductID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductID:{ProductID}"), collectionId, () => PromotionDAL.GetPromotionIDsByProductID(ProductID), Get);
	}

	public void Construct(PromotionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ProductID:{ProductID}");
	}
}
