using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ProductPaymentProviderType : IRobloxEntity<int, ProductPaymentProviderTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private ProductPaymentProviderTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.ProductPaymentProviderType", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public byte PaymentProviderTypeID
	{
		get
		{
			return _EntityDAL.PaymentProviderTypeID;
		}
		set
		{
			_EntityDAL.PaymentProviderTypeID = value;
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

	public ProductPaymentProviderType()
	{
		_EntityDAL = new ProductPaymentProviderTypeDAL();
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

	public static ProductPaymentProviderType CreateNew(int productid, byte paymentprovidertypeid)
	{
		ProductPaymentProviderType productPaymentProviderType = new ProductPaymentProviderType();
		productPaymentProviderType.ProductID = productid;
		productPaymentProviderType.PaymentProviderTypeID = paymentprovidertypeid;
		productPaymentProviderType.Save();
		return productPaymentProviderType;
	}

	public static ProductPaymentProviderType Get(int id)
	{
		return EntityHelper.GetEntity<int, ProductPaymentProviderTypeDAL, ProductPaymentProviderType>(EntityCacheInfo, id, () => ProductPaymentProviderTypeDAL.Get(id));
	}

	public static bool IsValidPaymentProviderType(int productId, int paymentProviderTypeId)
	{
		return EntityHelper.GetEntityByLookup<int, ProductPaymentProviderTypeDAL, ProductPaymentProviderType>(EntityCacheInfo, $"ProductID:{productId}_PaymentProviderTypeID:{paymentProviderTypeId}", () => ProductPaymentProviderTypeDAL.GetProductPaymentProviderTypeByProductIDAndPaymentProviderTypeID(productId, paymentProviderTypeId)) != null;
	}

	public static ProductPaymentProviderType GetByProductIDAndPaymentProviderTypeID(int productId, int paymentProviderTypeId)
	{
		return EntityHelper.GetEntityByLookup<int, ProductPaymentProviderTypeDAL, ProductPaymentProviderType>(EntityCacheInfo, $"ProductID:{productId}_PaymentProviderTypeID:{paymentProviderTypeId}", () => ProductPaymentProviderTypeDAL.GetProductPaymentProviderTypeByProductIDAndPaymentProviderTypeID(productId, paymentProviderTypeId));
	}

	public static ICollection<ProductPaymentProviderType> GetProductPaymentProviderTypesByPaymentProviderTypeID(byte paymentProviderTypeId)
	{
		string collectionId = $"GetProductPaymentProviderTypesByPaymentProviderTypeID_PaymentProviderTypeID:{paymentProviderTypeId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PaymentProviderTypeID:{paymentProviderTypeId}"), collectionId, () => ProductPaymentProviderTypeDAL.GetProductPaymentProviderTypeIDsByPaymentProviderTypeID(paymentProviderTypeId), Get);
	}

	public static ICollection<ProductPaymentProviderType> GetProductPaymentProviderTypesByProductID(int productID)
	{
		string collectionId = $"GetProductPaymentProviderTypesByProductID_ProductID:{productID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ProductID:{productID}"), collectionId, () => ProductPaymentProviderTypeDAL.GetProductPaymentProviderTypeIDsByProductID(productID), Get);
	}

	public void Construct(ProductPaymentProviderTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"ProductID:{ProductID}_PaymentProviderTypeID:{PaymentProviderTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PaymentProviderTypeID:{PaymentProviderTypeID}");
		yield return new StateToken($"ProductID:{ProductID}");
	}
}
