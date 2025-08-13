using System;
using System.Collections.Generic;
using Roblox.Billing.Data_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing.Business_Logic_Layer;

public class GiftCard : IRobloxEntity<int, GiftCardDAL>, ICacheableObject<int>, ICacheableObject
{
	private GiftCardDAL _EntityDAL;

	private static long _RedemptionCodeBoundingPrime = 2971215073L;

	private static long _RedemptionCodeSaltPrime = 1405695061L;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.GiftCard", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string PurchaserName
	{
		get
		{
			return _EntityDAL.PurchaserName;
		}
		set
		{
			_EntityDAL.PurchaserName = value;
		}
	}

	public string PurchaserEmail
	{
		get
		{
			return _EntityDAL.PurchaserEmail;
		}
		set
		{
			_EntityDAL.PurchaserEmail = value;
		}
	}

	public string RecipientName
	{
		get
		{
			return _EntityDAL.RecipientName;
		}
		set
		{
			_EntityDAL.RecipientName = value;
		}
	}

	public string RecipientEmail
	{
		get
		{
			return _EntityDAL.RecipientEmail;
		}
		set
		{
			_EntityDAL.RecipientEmail = value;
		}
	}

	public string Message
	{
		get
		{
			return _EntityDAL.Message;
		}
		set
		{
			_EntityDAL.Message = value;
		}
	}

	public decimal Value
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

	public long? SaleProductID
	{
		get
		{
			return _EntityDAL.SaleProductID;
		}
		set
		{
			_EntityDAL.SaleProductID = value;
		}
	}

	public long ShoppingCartProductID
	{
		get
		{
			return _EntityDAL.ShoppingCartProductID;
		}
		set
		{
			_EntityDAL.ShoppingCartProductID = value;
		}
	}

	public string RedemptionCode
	{
		get
		{
			return _EntityDAL.RedemptionCode;
		}
		set
		{
			_EntityDAL.RedemptionCode = value;
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

	public long? RedeemerAccountID
	{
		get
		{
			return _EntityDAL.RedeemerAccountID;
		}
		set
		{
			_EntityDAL.RedeemerAccountID = value;
		}
	}

	public byte StatusTypeID
	{
		get
		{
			return _EntityDAL.StatusTypeID;
		}
		set
		{
			_EntityDAL.StatusTypeID = value;
		}
	}

	public byte ThemeTypeID
	{
		get
		{
			return _EntityDAL.ThemeTypeID;
		}
		set
		{
			_EntityDAL.ThemeTypeID = value;
		}
	}

	public DateTime? DeliveryDate
	{
		get
		{
			return _EntityDAL.DeliveryDate;
		}
		set
		{
			_EntityDAL.DeliveryDate = value;
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

	public Product Product
	{
		get
		{
			if (StatusTypeID != GiftCardStatusType.Pending.ID)
			{
				return SaleProduct.Get(SaleProductID.Value).Product;
			}
			return ShoppingCartProduct.Get(ShoppingCartProductID).Product;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GiftCard()
	{
		_EntityDAL = new GiftCardDAL();
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

	public static GiftCard CreateNew(string purchasername, string purchaseremail, string recipientname, string recipientemail, string message, decimal value, long shoppingcartproductid, long? redeemeraccountid, byte themetypeid, DateTime? deliverydate, long? saleProductId = null)
	{
		string redemptioncode = Guid.NewGuid().ToString().Substring(0, 12);
		GiftCard giftCard = new GiftCard();
		giftCard.PurchaserName = purchasername;
		giftCard.PurchaserEmail = purchaseremail;
		giftCard.RecipientName = recipientname;
		giftCard.RecipientEmail = recipientemail;
		giftCard.Message = message;
		giftCard.Value = value;
		giftCard.SaleProductID = saleProductId;
		giftCard.ShoppingCartProductID = shoppingcartproductid;
		giftCard.RedemptionCode = redemptioncode;
		giftCard.RedemptionDate = null;
		giftCard.RedeemerAccountID = redeemeraccountid;
		giftCard.StatusTypeID = GiftCardStatusType.Pending.ID;
		giftCard.ThemeTypeID = themetypeid;
		giftCard.DeliveryDate = deliverydate;
		giftCard.Save();
		giftCard.RedemptionCode = _GenerateRedemptionCode(giftCard.ID);
		giftCard.Save();
		return giftCard;
	}

	public static GiftCard CreateNew(string redemptionCode, string purchasername, string purchaseremail, string recipientname, string recipientemail, string message, decimal value, long shoppingcartproductid, int? redeemeraccountid, byte themetypeid, DateTime? deliverydate, long? saleProductId = null)
	{
		GiftCard giftCard = new GiftCard();
		giftCard.PurchaserName = purchasername;
		giftCard.PurchaserEmail = purchaseremail;
		giftCard.RecipientName = recipientname;
		giftCard.RecipientEmail = recipientemail;
		giftCard.Message = message;
		giftCard.Value = value;
		giftCard.SaleProductID = saleProductId;
		giftCard.ShoppingCartProductID = shoppingcartproductid;
		giftCard.RedemptionCode = redemptionCode;
		giftCard.RedemptionDate = null;
		giftCard.RedeemerAccountID = redeemeraccountid;
		giftCard.StatusTypeID = GiftCardStatusType.Pending.ID;
		giftCard.ThemeTypeID = themetypeid;
		giftCard.DeliveryDate = deliverydate;
		giftCard.Save();
		return giftCard;
	}

	public static GiftCard Get(int id)
	{
		return EntityHelper.GetEntity<int, GiftCardDAL, GiftCard>(EntityCacheInfo, id, () => GiftCardDAL.Get(id));
	}

	public static GiftCard GetByShoppingCartProductID(long shoppingCartProductId)
	{
		return EntityHelper.GetEntityByLookup<int, GiftCardDAL, GiftCard>(EntityCacheInfo, $"ShoppingCartProductID:{shoppingCartProductId}", () => GiftCardDAL.GetByShoppingCartProductID(shoppingCartProductId));
	}

	public static GiftCard GetBySaleProductID(long saleProductId)
	{
		return EntityHelper.GetEntityByLookup<int, GiftCardDAL, GiftCard>(EntityCacheInfo, $"SaleProductID:{saleProductId}", () => GiftCardDAL.GetBySaleProductID(saleProductId));
	}

	public static GiftCard GetByRedemptionCode(string redemptionCode)
	{
		if (string.IsNullOrEmpty(redemptionCode))
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, GiftCardDAL, GiftCard>(EntityCacheInfo, $"RedemptionCode:{redemptionCode}", () => GiftCardDAL.GetByRedemptionCode(redemptionCode));
	}

	public static ICollection<GiftCard> GetByRedeemerAccountID(int count, int redeemerAccountID)
	{
		if (redeemerAccountID == 0)
		{
			return null;
		}
		string collectionId = $"GetGiftCardIDsByRedeemerAccountID_Count:{count}_RedeemerAccountID:{redeemerAccountID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"RedeemerAccountID:{redeemerAccountID}"), collectionId, () => GiftCardDAL.GetGiftCardIDsByRedeemerAccountID(count, redeemerAccountID), Get);
	}

	public static void ActivateGiftCardsForSale(int saleId)
	{
		foreach (GiftCard item in GetGiftCardsForSale(saleId))
		{
			item.Activate();
		}
	}

	public static bool IsGiftCardProduct(ShoppingCartProduct product)
	{
		return product.ProductGroupID == ProductGroup.GiftCard.ID;
	}

	public static bool IsGiftCardProduct(SaleProduct product)
	{
		return product.Product.ProductGroupID == ProductGroup.GiftCard.ID;
	}

	public static bool IsGiftCardProduct(Product product)
	{
		return product.ProductGroupID == ProductGroup.GiftCard.ID;
	}

	public bool Activate()
	{
		if (StatusTypeID == GiftCardStatusType.Pending.ID)
		{
			StatusTypeID = GiftCardStatusType.Active.ID;
			Save();
			return true;
		}
		return false;
	}

	public bool Redeem(Account account)
	{
		if (StatusTypeID == GiftCardStatusType.Active.ID)
		{
			StatusTypeID = GiftCardStatusType.Redeemed.ID;
			RedeemerAccountID = account.ID;
			RedemptionDate = DateTime.Now;
			Save();
			return true;
		}
		return false;
	}

	public string RedemptionCodeAsQueryParameter()
	{
		int offset = 0;
		char[] buffer = new char[14];
		char[] rcCharArray = RedemptionCode.ToCharArray();
		for (int i = 0; i < buffer.Length; i++)
		{
			if (i == 4 || i == 9)
			{
				buffer[i] = '-';
				offset++;
			}
			else
			{
				buffer[i] += (char)(ushort)(rcCharArray[i - offset] + 63);
			}
		}
		return new string(buffer);
	}

	public static string RedemptionCodeFromQueryParameter(string queryParameter)
	{
		string result = "";
		foreach (char ch in queryParameter)
		{
			if (ch != '-')
			{
				result += (char)(ch - 63);
			}
		}
		return result;
	}

	public static ICollection<GiftCard> GetGiftCardsForSale(int saleId)
	{
		ICollection<SaleProduct> saleProductsBySaleID = SaleProduct.GetSaleProductsBySaleID(saleId);
		List<GiftCard> giftCards = new List<GiftCard>();
		foreach (SaleProduct saleProduct in saleProductsBySaleID)
		{
			if (IsGiftCardProduct(saleProduct))
			{
				giftCards.Add(GetBySaleProductID(saleProduct.ID));
			}
		}
		return giftCards;
	}

	private static string _GenerateRedemptionCode(int id)
	{
		if (id <= 0)
		{
			return null;
		}
		int randomPostfix = new Random().Next(10, 99);
		return (id * _RedemptionCodeSaltPrime % _RedemptionCodeBoundingPrime + _RedemptionCodeBoundingPrime).ToString().ToString() + randomPostfix;
	}

	public void Construct(GiftCardDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"ShoppingCartProductID:{ShoppingCartProductID}";
			if (!string.IsNullOrEmpty(RedemptionCode))
			{
				yield return $"RedemptionCode:{RedemptionCode}";
			}
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
