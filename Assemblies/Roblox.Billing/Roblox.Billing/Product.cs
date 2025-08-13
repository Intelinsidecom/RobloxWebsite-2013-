using System;
using System.Collections.Generic;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

public class Product : IRobloxEntity<int, ProductDAL>, ICacheableObject<int>, ICacheableObject
{
	private ProductDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

	public static int BCMonthlyID => Get("Builders Club Monthly").ID;

	public static int BC6MonthsID => Get("Builders Club 6 Months").ID;

	public static int BC6MonthsRenewalID => Get("Builders Club 6 Month Renewal").ID;

	public static int BC12MonthsID => Get("Builders Club 12 Months").ID;

	public static int BC12MonthsRenewalID => Get("Builders Club 12 Month Renewal").ID;

	public static int BCLifetimeID => Get("Builders Club Lifetime").ID;

	public static int TBCMonthlyID => Get("Turbo Builders Club Monthly").ID;

	public static int TBC6MonthsID => Get("Turbo Builders Club 6 Months").ID;

	public static int TBC6MonthsRenewalID => Get("Turbo Builders Club 6 Month Renewal").ID;

	public static int TBC12MonthsID => Get("Turbo Builders Club 12 Months").ID;

	public static int TBC12MonthsRenewalID => Get("Turbo Builders Club 12 Month Renewal").ID;

	public static int TBCLifetimeID => Get("Turbo Builders Club Lifetime").ID;

	public static int OBCMonthlyID => Get("Outrageous Builders Club Monthly").ID;

	public static int OBC6MonthsID => Get("Outrageous Builders Club 6 Months").ID;

	public static int OBC6MonthsRenewalID => Get("Outrageous Builders Club 6 Month Renewal").ID;

	public static int OBC12MonthsID => Get("Outrageous Builders Club 12 Months").ID;

	public static int OBC12MonthsRenewalID => Get("Outrageous Builders Club 12 Month Renewal").ID;

	public static int OBCLifetimeID => Get("Outrageous Builders Club Lifetime").ID;

	public static int BC30DaysID => Get("Builders Club 30 Days").ID;

	public static int BC45DaysID => Get("Builders Club 45 Days").ID;

	public static HashSet<int> ListOf6And12MonthMembershipProductIDs { get; private set; }

	public int ID => _EntityDAL.ID;

	public byte ProductGroupID
	{
		get
		{
			return _EntityDAL.ProductGroupID;
		}
		set
		{
			_EntityDAL.ProductGroupID = value;
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

	public bool IsRenewable
	{
		get
		{
			return _EntityDAL.IsRenewable;
		}
		set
		{
			_EntityDAL.IsRenewable = value;
		}
	}

	public byte? RenewalPeriodTypeID
	{
		get
		{
			return _EntityDAL.RenewalPeriodTypeID;
		}
		set
		{
			_EntityDAL.RenewalPeriodTypeID = value;
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

	public int PremiumFeatureID
	{
		get
		{
			return _EntityDAL.PremiumFeatureID;
		}
		set
		{
			_EntityDAL.PremiumFeatureID = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	static Product()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.Product", isNullCacheable: true);
		ListOf6And12MonthMembershipProductIDs = new HashSet<int>
		{
			BC6MonthsID, BC6MonthsRenewalID, BC12MonthsID, BC12MonthsRenewalID, TBC6MonthsID, TBC6MonthsRenewalID, TBC12MonthsID, TBC12MonthsRenewalID, OBC6MonthsID, OBC6MonthsRenewalID,
			OBC12MonthsID, OBC12MonthsRenewalID
		};
	}

	public Product()
	{
		_EntityDAL = new ProductDAL();
	}

	private static Product DoGet(int id)
	{
		return EntityHelper.DoGet<int, ProductDAL, Product>(() => ProductDAL.Get(id), id);
	}

	public static Product Get(int id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Product DoGet(string name)
	{
		return EntityHelper.DoGetByLookup<int, ProductDAL, Product>(() => ProductDAL.Get(name), $"Name:{name}");
	}

	public static Product Get(string name)
	{
		return EntityHelper.GetEntityByLookupOld<int, Product>(EntityCacheInfo, $"Name:{name}", () => DoGet(name));
	}

	private static Product DoGetByPremiumFeatureID(int premiumFeatureID)
	{
		return EntityHelper.DoGetByLookup<int, ProductDAL, Product>(() => ProductDAL.GetByPremiumFeatureID(premiumFeatureID), $"PremiumFeatureID:{premiumFeatureID}");
	}

	public static Product GetByPremiumFeatureID(int premiumFeatureID)
	{
		return EntityHelper.GetEntityByLookupOld<int, Product>(EntityCacheInfo, $"PremiumFeatureID:{premiumFeatureID}", () => DoGetByPremiumFeatureID(premiumFeatureID));
	}

	public static Product CreateNew(byte productgroupid, string name, decimal price, bool isrenewable, byte? renewalperiodtypeid, int premiumfeatureid, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		Product product = new Product();
		product.ProductGroupID = productgroupid;
		product.Name = name;
		product.Price = price;
		product.IsRenewable = isrenewable;
		product.RenewalPeriodTypeID = renewalperiodtypeid;
		product.PremiumFeatureID = premiumfeatureid;
		product.CurrencyTypeID = currencyTypeID;
		product.Save();
		return product;
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

	public PremiumFeature GetPremiumFeature()
	{
		return PremiumFeature.MustGet(PremiumFeatureID);
	}

	public static Product UpdateProductToRecurring(Product product)
	{
		if (product != null)
		{
			if (product.ID == BC6MonthsID)
			{
				return Get("Builders Club 6 Month Renewal");
			}
			if (product.ID == BC12MonthsID)
			{
				return Get("Builders Club 12 Month Renewal");
			}
			if (product.ID == TBC6MonthsID)
			{
				return Get("Turbo Builders Club 6 Month Renewal");
			}
			if (product.ID == TBC12MonthsID)
			{
				return Get("Turbo Builders Club 12 Month Renewal");
			}
			if (product.ID == OBC6MonthsID)
			{
				return Get("Outrageous Builders Club 6 Month Renewal");
			}
			if (product.ID == OBC12MonthsID)
			{
				return Get("Outrageous Builders Club 12 Month Renewal");
			}
		}
		return product;
	}

	public static Product UpdateProductToNonRecurring(Product recurrProduct)
	{
		if (recurrProduct == null || !recurrProduct.RenewalPeriodTypeID.HasValue || recurrProduct.RenewalPeriodTypeID.Value == RenewalPeriodType.Monthly.ID)
		{
			return recurrProduct;
		}
		return Get(recurrProduct.Name.Replace("Monthly", "1 Month").Replace("Month Renewal", "Months"));
	}

	public static bool IsLifetime(Product product)
	{
		if (product.ID == BCLifetimeID)
		{
			return true;
		}
		if (product.ID == OBCLifetimeID)
		{
			return true;
		}
		if (product.ID == TBCLifetimeID)
		{
			return true;
		}
		return false;
	}

	public static ICollection<Product> GetProductsPaged(int startIndex, int maxRows)
	{
		string collectionId = $"GetProductsPaged_StartRowIndex:{startIndex}_MaximumRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), collectionId, () => ProductDAL.GetProductsPaged(startIndex + 1, maxRows), Get);
	}

	public static int GetTotalNumberOfProducts()
	{
		return ProductDAL.GetTotalNumberOfProducts();
	}

	public void Construct(ProductDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
