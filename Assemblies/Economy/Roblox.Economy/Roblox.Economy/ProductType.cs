using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class ProductType : IRobloxEntity<byte, ProductTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ProductTypeDAL _EntityDAL;

	public static readonly byte RobloxProductID;

	public const string RobloxProductValue = "ROBLOX Product";

	public static readonly byte UserProductID;

	public const string UserProductValue = "User Product";

	public static readonly byte ResellableProductID;

	public const string ResellableProductValue = "Resellable Product";

	public static readonly byte DeveloperProductID;

	public const string DeveloperProductValue = "Developer Product";

	public static readonly byte PrivateServerProductID;

	public const string PrivateServerProductValue = "Private Server Product";

	public static readonly byte GamePassProductID;

	public const string GamePassProductValue = "Game Pass";

	public static readonly byte BundleProductID;

	public const string BundleProductValue = "Bundle Product";

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ProductType()
	{
		_EntityDAL = new ProductTypeDAL();
	}

	static ProductType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ProductType", isNullCacheable: true);
		RobloxProductID = Get("ROBLOX Product").ID;
		UserProductID = Get("User Product").ID;
		ResellableProductID = Get("Resellable Product").ID;
		DeveloperProductID = Get("Developer Product").ID;
		PrivateServerProductID = Get("Private Server Product").ID;
		GamePassProductID = Get("Game Pass").ID;
		BundleProductID = Get("Bundle Product").ID;
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static ProductType DoGet(byte id)
	{
		return EntityHelper.DoGet<byte, ProductTypeDAL, ProductType>(() => ProductTypeDAL.Get(id), id);
	}

	private static ProductType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<byte, ProductTypeDAL, ProductType>(() => ProductTypeDAL.Get(value), value);
	}

	public static ProductType Get(byte id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static ProductType Get(byte? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ProductType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<byte, ProductType>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ICollection<ProductType> GetProductTypesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetProductTypesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => ProductTypeDAL.GetProductTypeIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	public static int GetTotalNumberOfProductTypes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfProductTypes", ProductTypeDAL.GetTotalNumberOfProductTypes);
	}

	public void Construct(ProductTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
