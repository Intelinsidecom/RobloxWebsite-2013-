using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ShoppingCartProduct : IRobloxEntity<long, ShoppingCartProductDAL>, ICacheableObject<long>, ICacheableObject
{
	private ShoppingCartProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.ShoppingCartProduct", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public long? RecipientAccountID
	{
		get
		{
			return _EntityDAL.RecipientAccountID;
		}
		set
		{
			_EntityDAL.RecipientAccountID = value;
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

	public Product Product => Product.Get(ProductID);

	public decimal ListPrice => Product.Price;

	public byte? RenewalPeriodTypeID => Product.RenewalPeriodTypeID;

	public bool IsRenewable => Product.IsRenewable;

	public string Name => Product.Name;

	public byte ProductGroupID => Product.ProductGroupID;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ShoppingCartProduct()
	{
		_EntityDAL = new ShoppingCartProductDAL();
	}

	private static ShoppingCartProduct DoGet(long id)
	{
		return EntityHelper.DoGet<long, ShoppingCartProductDAL, ShoppingCartProduct>(() => ShoppingCartProductDAL.Get(id), id);
	}

	public static ShoppingCartProduct Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public void RemoveFromCart()
	{
		Delete();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static ICollection<ShoppingCartProduct> GetShoppingCartProductsByShoppingCartID(int shoppingCartID)
	{
		string collectionId = $"GetShoppingCartProductsByShoppingCartID:{shoppingCartID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"ShoppingCartID:{shoppingCartID}"), collectionId, () => ShoppingCartProductDAL.GetIDsByShoppingCartID(shoppingCartID), Get);
	}

	public static ShoppingCartProduct CreateNew(int shoppingcartid, int productid, long? recipientaccountid, decimal price, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		ShoppingCartProduct shoppingCartProduct = new ShoppingCartProduct();
		shoppingCartProduct.ShoppingCartID = shoppingcartid;
		shoppingCartProduct.ProductID = productid;
		shoppingCartProduct.RecipientAccountID = recipientaccountid;
		shoppingCartProduct.Price = price;
		shoppingCartProduct.CurrencyTypeID = currencyTypeID;
		shoppingCartProduct.Save();
		return shoppingCartProduct;
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

	public void Construct(ShoppingCartProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ShoppingCartID:{ShoppingCartID}");
	}
}
