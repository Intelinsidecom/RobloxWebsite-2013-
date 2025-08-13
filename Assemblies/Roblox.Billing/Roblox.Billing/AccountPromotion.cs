using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class AccountPromotion : IRobloxEntity<int, AccountPromotionDAL>, ICacheableObject<int>, ICacheableObject
{
	private AccountPromotionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.AccountPromotion", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public short PromotionID
	{
		get
		{
			return _EntityDAL.PromotionID;
		}
		set
		{
			_EntityDAL.PromotionID = value;
		}
	}

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

	public DateTime Expires
	{
		get
		{
			return _EntityDAL.Expires;
		}
		set
		{
			_EntityDAL.Expires = value;
		}
	}

	public DateTime? RedemptionDate
	{
		get
		{
			return _EntityDAL.RedemptionDate;
		}
		set
		{
			_EntityDAL.RedemptionDate = value;
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

	public AccountPromotion()
	{
		_EntityDAL = new AccountPromotionDAL();
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

	public static AccountPromotion CreateNew(short promotionId, long accountId, DateTime expires)
	{
		AccountPromotion accountPromotion = new AccountPromotion();
		accountPromotion.PromotionID = promotionId;
		accountPromotion.AccountID = accountId;
		accountPromotion.Expires = expires;
		accountPromotion.RedemptionDate = null;
		accountPromotion.Save();
		return accountPromotion;
	}

	public static AccountPromotion Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountPromotionDAL, AccountPromotion>(EntityCacheInfo, id, () => AccountPromotionDAL.Get(id));
	}

	public void RedeemWithoutCheckout(byte platformTypeId)
	{
		ShoppingCart shoppingCart = ShoppingCart.RetrieveCart(AccountID);
		Promotion promotion = Promotion.Get(PromotionID);
		shoppingCart.RemoveAll();
		shoppingCart.AddToCart(promotion.ProductID, promotion.DiscountedPrice);
		Sale sale = shoppingCart.CheckOut(platformTypeId);
		sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		sale.Save();
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(sale.Products);
		RedemptionDate = DateTime.Now;
		Save();
	}

	public void RedeemWithoutCheckout(byte countryId, byte platformTypeId)
	{
		ShoppingCart shoppingCart = ShoppingCart.RetrieveCart(AccountID);
		Promotion promotion = Promotion.Get(PromotionID);
		shoppingCart.RemoveAll();
		shoppingCart.AddToCart(promotion.ProductID, promotion.DiscountedPrice);
		Sale sale = shoppingCart.CheckOut(countryId, PaymentProviderType.Credit.ID, platformTypeId);
		sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		sale.Save();
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(sale.Products);
		RedemptionDate = DateTime.Now;
		Save();
	}

	public static ICollection<AccountPromotion> GetAccountPromotionsByPromotionID(short PromotionID)
	{
		string collectionId = $"GetAccountPromotionsByPromotionID_PromotionID:{PromotionID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PromotionID:{PromotionID}"), collectionId, () => AccountPromotionDAL.GetAccountPromotionIDsByPromotionID(PromotionID), Get);
	}

	public static ICollection<AccountPromotion> GetAccountPromotionsByAccountID(long accountID)
	{
		string collectionId = $"GetAccountPromotionsByPromotionID_AccountID:{accountID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountID}"), collectionId, () => AccountPromotionDAL.GetAccountPromotionIDsByAccountID(accountID), Get);
	}

	public static ICollection<AccountPromotion> GetAccountPromotionsByAccountIDAndPromotionID(long accountID, short promotionID)
	{
		string collectionId = $"GetAccountPromotionsByAccountIDAndByPromotionID_AccountID:{accountID}_PromotionID:{promotionID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountID}PromotionID:{promotionID}"), collectionId, () => AccountPromotionDAL.GetAccountPromotionIDsByAccountIDAndPromotionID(accountID, promotionID), Get);
	}

	public static AccountPromotion GetEligibleAccountPromotion(long accountId, short promotionId)
	{
		List<AccountPromotion> accountPromotions = (List<AccountPromotion>)GetAccountPromotionsByAccountIDAndPromotionID(accountId, promotionId);
		if (accountPromotions != null)
		{
			foreach (AccountPromotion accountPromotion in accountPromotions)
			{
				if (!accountPromotion.RedemptionDate.HasValue && accountPromotion.Expires > DateTime.Now)
				{
					return accountPromotion;
				}
			}
		}
		return null;
	}

	public void Construct(AccountPromotionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PromotionID:{PromotionID}");
		yield return new StateToken($"AccountID:{AccountID}");
		yield return new StateToken($"AccountID:{AccountID}PromotionID:{PromotionID}");
	}
}
