using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class AccountShoppingCart : IRobloxEntity<int, AccountShoppingCartDAL>, ICacheableObject<int>, ICacheableObject
{
	private AccountShoppingCartDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.AccountShoppingCart", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
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

	public AccountShoppingCart()
	{
		_EntityDAL = new AccountShoppingCartDAL();
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

	public static AccountShoppingCart CreateNew(long accountid, int shoppingcartid)
	{
		AccountShoppingCart accountShoppingCart = new AccountShoppingCart();
		accountShoppingCart.AccountID = accountid;
		accountShoppingCart.ShoppingCartID = shoppingcartid;
		accountShoppingCart.Save();
		return accountShoppingCart;
	}

	public static AccountShoppingCart Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountShoppingCartDAL, AccountShoppingCart>(EntityCacheInfo, id, () => AccountShoppingCartDAL.Get(id));
	}

	public static AccountShoppingCart GetByAccountID(long accountId)
	{
		return EntityHelper.GetEntityByLookup<int, AccountShoppingCartDAL, AccountShoppingCart>(EntityCacheInfo, $"AccountID:{accountId}", () => AccountShoppingCartDAL.GetByAccountID(accountId));
	}

	public static AccountShoppingCart GetByShoppingCartID(int shoppingCartId)
	{
		return EntityHelper.GetEntityByLookup<int, AccountShoppingCartDAL, AccountShoppingCart>(EntityCacheInfo, $"ShoppingCartID:{shoppingCartId}", () => AccountShoppingCartDAL.GetByShoppingCartID(shoppingCartId));
	}

	public void Construct(AccountShoppingCartDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AccountID:{AccountID}";
			yield return $"ShoppingCartID:{ShoppingCartID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"ShoppingCartID:{ShoppingCartID}");
	}
}
