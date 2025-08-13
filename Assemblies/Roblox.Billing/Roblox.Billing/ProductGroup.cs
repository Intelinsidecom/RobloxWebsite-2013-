using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ProductGroup : IRobloxEntity<byte, ProductGroupDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ProductGroupDAL _EntityDAL;

	public static readonly ProductGroup BC;

	public static readonly ProductGroup Robux;

	public static readonly ProductGroup GiftCard;

	public static readonly ProductGroup Subscription;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	static ProductGroup()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.ProductGroup", isNullCacheable: true);
		BC = Get("BC");
		Robux = Get("Robux");
		GiftCard = Get("Gift Card");
		Subscription = Get("Subscription");
	}

	public ProductGroup()
	{
		_EntityDAL = new ProductGroupDAL();
	}

	private static ProductGroup DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, ProductGroupDAL, ProductGroup>(() => ProductGroupDAL.Get(id), id);
	}

	public static ProductGroup Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	private static ProductGroup DoGet(string name)
	{
		return EntityHelper.DoGetByLookup<byte, ProductGroupDAL, ProductGroup>(() => ProductGroupDAL.Get(name), $"Name:{name}");
	}

	public static ProductGroup Get(string name)
	{
		return EntityHelper.GetEntityByLookupOld<byte, ProductGroup>(EntityCacheInfo, $"Name:{name}", () => DoGet(name));
	}

	public static ProductGroup CreateNew(string name)
	{
		ProductGroup productGroup = new ProductGroup();
		productGroup.Name = name;
		productGroup.Save();
		return productGroup;
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(ProductGroupDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Name:{Name}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
