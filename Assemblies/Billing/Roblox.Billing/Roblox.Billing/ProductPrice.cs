using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ProductPrice : IRobloxEntity<int, ProductPriceDAL>, ICacheableObject<int>, ICacheableObject
{
	private ProductPriceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.ProductPrices.ProductPrice", isNullCacheable: true);

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public int ProductPaymentProviderTypeID
	{
		get
		{
			return _EntityDAL.ProductPaymentProviderTypeID;
		}
		set
		{
			_EntityDAL.ProductPaymentProviderTypeID = value;
		}
	}

	public int CountryCurrencyID
	{
		get
		{
			return _EntityDAL.CountryCurrencyID;
		}
		set
		{
			_EntityDAL.CountryCurrencyID = value;
		}
	}

	public decimal Price
	{
		get
		{
			return _EntityDAL.Price;
		}
		set
		{
			_EntityDAL.Price = value;
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

	public bool? IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_EntityDAL.IsActive = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ProductPrice()
	{
		_EntityDAL = new ProductPriceDAL();
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

	public static ProductPrice CreateNew(int productPaymentProviderTypeId, int countryCurrencyId, decimal price, bool? isActive = false)
	{
		ProductPrice productPrice = new ProductPrice();
		productPrice.ProductPaymentProviderTypeID = productPaymentProviderTypeId;
		productPrice.CountryCurrencyID = countryCurrencyId;
		productPrice.Price = price;
		productPrice.IsActive = isActive;
		productPrice.Save();
		return productPrice;
	}

	public static ProductPrice Get(int id)
	{
		return EntityHelper.GetEntity<int, ProductPriceDAL, ProductPrice>(EntityCacheInfo, id, () => ProductPriceDAL.Get(id));
	}

	public static ProductPrice GetByProductPaymentProviderTypeIDAndCountryCurrencyID(int productPaymentProviderTypeID, int countryCurrencyID)
	{
		if (productPaymentProviderTypeID == 0)
		{
			return null;
		}
		if (countryCurrencyID == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, ProductPriceDAL, ProductPrice>(EntityCacheInfo, $"ProductPaymentProviderTypeID:{productPaymentProviderTypeID}_CountryCurrencyID:{countryCurrencyID}", () => ProductPriceDAL.GetByProductPaymentProviderTypeIDAndCountryCurrencyID(productPaymentProviderTypeID, countryCurrencyID));
	}

	public static int GetTotalNumberOfProductPricesByProductPaymentProviderID(int productPaymentProviderTypeID)
	{
		string countId = "GetTotalNumberOfProductPricesByProductPaymentProviderID_ProductPaymentProviderID:" + productPaymentProviderTypeID;
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductPaymentProviderTypeID:{productPaymentProviderTypeID}"), countId, () => ProductPriceDAL.GetTotalNumberOfProductPricesByProductPaymentProviderTypeID(productPaymentProviderTypeID));
	}

	public void Construct(ProductPriceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ProductPaymentProviderTypeID:{ProductPaymentProviderTypeID}_CountryCurrencyID:{CountryCurrencyID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ProductPaymentProviderTypeID:{ProductPaymentProviderTypeID}");
	}
}
