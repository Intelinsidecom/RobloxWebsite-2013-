using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class PremiumFeature : IEquatable<PremiumFeature>, IRobloxEntity<int, PremiumFeatureDAL>, ICacheableObject<int>, ICacheableObject
{
	private PremiumFeatureDAL _EntityDAL;

	private static string BCMonthlyValue = "Builders Club Monthly";

	private static string BC1MonthValue = "Builders Club 1 Month";

	private static string BC30DaysValue = "Builders Club 30 Days";

	private static string BC90DaysValue = "Builders Club 90 Days";

	private static string BC45DaysValue = "Builders Club 45 Days";

	private static string BC6MonthsValue = "Builders Club 6 Months";

	private static string BC6MonthsRenewingValue = "Builders Club 6 Months Renewing";

	private static string BC12MonthsValue = "Builders Club 12 Months";

	private static string BC12MonthsRenewingValue = "Builders Club 12 Months Renewing";

	private static string BCLifetimeValue = "Builders Club Lifetime";

	private static string TBCMonthlyValue = "Turbo Builders Club Monthly";

	private static string TBC1MonthValue = "Turbo Builders Club 1 Month";

	private static string TBC6MonthsValue = "Turbo Builders Club 6 Months";

	private static string TBC6MonthsRenewingValue = "Turbo Builders Club 6 Months Renewing";

	private static string TBC12MonthsValue = "Turbo Builders Club 12 Months";

	private static string TBC12MonthsRenewingValue = "Turbo Builders Club 12 Months Renewing";

	private static string TBCLifetimeValue = "Turbo Builders Club Lifetime";

	private static string OBCMonthlyValue = "Outrageous Builders Club Monthly";

	private static string OBC1MonthValue = "Outrageous Builders Club 1 Month";

	private static string OBC6MonthsValue = "Outrageous Builders Club 6 Months";

	private static string OBC6MonthsRenewingValue = "Outrageous Builders Club 6 Months Renewing";

	private static string OBC12MonthsValue = "Outrageous Builders Club 12 Months";

	private static string OBC12MonthsRenewingValue = "Outrageous Builders Club 12 Months Renewing";

	private static string OBCLifetimeValue = "Outrageous Builders Club Lifetime";

	private static string Robux450Value = "450 ROBUX";

	private static string Robux731Value = "731 ROBUX";

	private static string Robux1000Value = "1000 ROBUX";

	private static string Robux1005Value = "1005 ROBUX";

	private static string Robux2000Value = "2000 ROBUX";

	private static string Robux2004Value = "2004 ROBUX";

	private static string Robux2750Value = "2750 ROBUX";

	private static string Robux2755Value = "2755 ROBUX";

	private static string Robux4500Value = "4500 ROBUX";

	private static string Robux6000Value = "6000 ROBUX";

	private static string Robux10000Value = "10000 ROBUX";

	private static string Robux15000Value = "15000 ROBUX";

	private static string Robux22500Value = "22500 ROBUX";

	private static string Robux35000Value = "35000 ROBUX";

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "PremiumFeature", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public byte AccountAddOnTypeID
	{
		get
		{
			return _EntityDAL.AccountAddOnTypeID;
		}
		set
		{
			_EntityDAL.AccountAddOnTypeID = value;
		}
	}

	public byte DurationTypeID
	{
		get
		{
			return _EntityDAL.DurationTypeID;
		}
		set
		{
			_EntityDAL.DurationTypeID = value;
		}
	}

	public bool IsRenewal
	{
		get
		{
			return _EntityDAL.IsRenewal;
		}
		set
		{
			_EntityDAL.IsRenewal = value;
		}
	}

	public byte RobuxCreditQuantityTypeID
	{
		get
		{
			return _EntityDAL.RobuxCreditQuantityTypeID;
		}
		set
		{
			_EntityDAL.RobuxCreditQuantityTypeID = value;
		}
	}

	public byte RobuxStipendQuantityTypeID
	{
		get
		{
			return _EntityDAL.RobuxStipendQuantityTypeID;
		}
		set
		{
			_EntityDAL.RobuxStipendQuantityTypeID = value;
		}
	}

	public byte? RobuxStipendFrequencyTypeID
	{
		get
		{
			return _EntityDAL.RobuxStipendFrequencyTypeID;
		}
		set
		{
			_EntityDAL.RobuxStipendFrequencyTypeID = value;
		}
	}

	public byte ShowcaseAllotmentTypeID
	{
		get
		{
			return _EntityDAL.ShowcaseAllotmentTypeID;
		}
		set
		{
			_EntityDAL.ShowcaseAllotmentTypeID = value;
		}
	}

	public byte ContentPrivilegeTypeID
	{
		get
		{
			return _EntityDAL.ContentPrivilegeTypeID;
		}
		set
		{
			_EntityDAL.ContentPrivilegeTypeID = value;
		}
	}

	public byte AdvertisingSuppressionTypeID
	{
		get
		{
			return _EntityDAL.AdvertisingSuppressionTypeID;
		}
		set
		{
			_EntityDAL.AdvertisingSuppressionTypeID = value;
		}
	}

	public int GrantedAssetListID
	{
		get
		{
			return _EntityDAL.GrantedAssetListID;
		}
		set
		{
			_EntityDAL.GrantedAssetListID = value;
		}
	}

	public byte GrantedBadgeListID
	{
		get
		{
			return _EntityDAL.GrantedBadgeListID;
		}
		set
		{
			_EntityDAL.GrantedBadgeListID = value;
		}
	}

	public long? GrantedItemListID
	{
		get
		{
			return _EntityDAL.GrantedItemListID;
		}
		set
		{
			_EntityDAL.GrantedItemListID = value;
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public bool IsAnyBuildersClub
	{
		get
		{
			if (AccountAddOnTypeID != AccountAddOnType.BuildersClubMembershipID && AccountAddOnTypeID != AccountAddOnType.TurboBuildersClubMembershipID)
			{
				return AccountAddOnTypeID == AccountAddOnType.OutrageousBuildersClubMembershipID;
			}
			return true;
		}
	}

	public bool IsAnySubscription => AccountAddOnTypeID == AccountAddOnType.SubscriptionID;

	public bool IsBuildersClub => AccountAddOnTypeID == AccountAddOnType.BuildersClubMembershipID;

	public bool IsTurboBuildersClub => AccountAddOnTypeID == AccountAddOnType.TurboBuildersClubMembershipID;

	public bool IsOutrageousBuildersClub => AccountAddOnTypeID == AccountAddOnType.OutrageousBuildersClubMembershipID;

	public static PremiumFeature BCMonthly => GetByName(BCMonthlyValue);

	public static PremiumFeature BC1Month => GetByName(BC1MonthValue);

	public static PremiumFeature BC30Days => GetByName(BC30DaysValue);

	public static PremiumFeature BC90Days => GetByName(BC90DaysValue);

	public static PremiumFeature BC45Days => GetByName(BC45DaysValue);

	public static PremiumFeature BC6Months => GetByName(BC6MonthsValue);

	public static PremiumFeature BC6MonthsRenewing => GetByName(BC6MonthsRenewingValue);

	public static PremiumFeature BC12Months => GetByName(BC12MonthsValue);

	public static PremiumFeature BC12MonthsRenewing => GetByName(BC12MonthsRenewingValue);

	public static PremiumFeature BCLifetime => GetByName(BCLifetimeValue);

	public static PremiumFeature TBCMonthly => GetByName(TBCMonthlyValue);

	public static PremiumFeature TBC1Month => GetByName(TBC1MonthValue);

	public static PremiumFeature TBC6Months => GetByName(TBC6MonthsValue);

	public static PremiumFeature TBC6MonthsRenewing => GetByName(TBC6MonthsRenewingValue);

	public static PremiumFeature TBC12Months => GetByName(TBC12MonthsValue);

	public static PremiumFeature TBC12MonthsRenewing => GetByName(TBC12MonthsRenewingValue);

	public static PremiumFeature TBCLifetime => GetByName(TBCLifetimeValue);

	public static PremiumFeature OBCMonthly => GetByName(OBCMonthlyValue);

	public static PremiumFeature OBC1Month => GetByName(OBC1MonthValue);

	public static PremiumFeature OBC6Months => GetByName(OBC6MonthsValue);

	public static PremiumFeature OBC6MonthsRenewing => GetByName(OBC6MonthsRenewingValue);

	public static PremiumFeature OBC12Months => GetByName(OBC12MonthsValue);

	public static PremiumFeature OBC12MonthsRenewing => GetByName(OBC12MonthsRenewingValue);

	public static PremiumFeature OBCLifetime => GetByName(OBCLifetimeValue);

	public static PremiumFeature Robux450 => GetByName(Robux450Value);

	public static PremiumFeature Robux731 => GetByName(Robux731Value);

	public static PremiumFeature Robux1000 => GetByName(Robux1000Value);

	public static PremiumFeature Robux1005 => GetByName(Robux1005Value);

	public static PremiumFeature Robux2000 => GetByName(Robux2000Value);

	public static PremiumFeature Robux2004 => GetByName(Robux2004Value);

	public static PremiumFeature Robux2750 => GetByName(Robux2750Value);

	public static PremiumFeature Robux2755 => GetByName(Robux2755Value);

	public static PremiumFeature Robux4500 => GetByName(Robux4500Value);

	public static PremiumFeature Robux6000 => GetByName(Robux6000Value);

	public static PremiumFeature Robux10000 => GetByName(Robux10000Value);

	public static PremiumFeature Robux15000 => GetByName(Robux15000Value);

	public static PremiumFeature Robux22500 => GetByName(Robux22500Value);

	public static PremiumFeature Robux35000 => GetByName(Robux35000Value);

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static ICollection<PremiumFeature> GetNonRenewalFeatureList()
	{
		return new List<PremiumFeature>
		{
			BC1Month, BC30Days, BC45Days, BC90Days, BC6Months, BC12Months, BCLifetime, TBC1Month, TBC6Months, TBC12Months,
			TBCLifetime, OBC1Month, OBC6Months, OBC12Months, OBCLifetime
		};
	}

	public PremiumFeature()
	{
		_EntityDAL = new PremiumFeatureDAL();
	}

	internal void Delete()
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

	internal static ICollection<PremiumFeature> GetPremiumFeaturesPaged(int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPremiumFeaturesPaged_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, collectionId, () => PremiumFeatureDAL.GetPremiumFeatureIDsPaged(startRowIndex + 1, maximumRows), Get);
	}

	internal static int GetTotalNumberOfPremiumFeatures()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.UnqualifiedNonExpiringCachePolicy, "GetTotalNumberOfPremiumFeatures", PremiumFeatureDAL.GetTotalNumberOfPremiumFeatures);
	}

	public static ICollection<PremiumFeature> GetPremiumFeaturesByAccountAddOnTypeIdPaged(int accountAddOnTypeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPremiumFeaturesByAccountAddOnTypeID_AccountAddOnTypeID:{accountAddOnTypeId}_startRowIndex:{startRowIndex}_maximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountAddOnTypeID:{accountAddOnTypeId}_startRowIndex{startRowIndex}_maximumRows{maximumRows}"), collectionId, () => PremiumFeatureDAL.GetPremiumFeaturesByAccountAddOnTypeIdPaged(accountAddOnTypeId, startRowIndex + 1, maximumRows), Get);
	}

	public static PremiumFeature Get(int id)
	{
		return EntityHelper.GetEntity<int, PremiumFeatureDAL, PremiumFeature>(EntityCacheInfo, id, () => PremiumFeatureDAL.Get(id));
	}

	public static PremiumFeature GetByName(string name)
	{
		return EntityHelper.GetEntityByLookup<int, PremiumFeatureDAL, PremiumFeature>(EntityCacheInfo, $"Name:{name}", () => PremiumFeatureDAL.GetByName(name));
	}

	public static PremiumFeature MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public bool Equals(PremiumFeature other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(PremiumFeatureDAL dal)
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
