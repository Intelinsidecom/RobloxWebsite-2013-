using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ReportCategory : IRobloxEntity<byte, ReportCategoryDAL>, ICacheableObject<byte>, ICacheableObject
{
	private ReportCategoryDAL _EntityDAL;

	public static byte InappropriateLanguageID = 1;

	public static byte PrivateInformationID = 2;

	public static byte BullyingAndHarrassmentID = 3;

	public static byte DatingID = 4;

	public static byte ExploitingCheatingScammingID = 5;

	public static byte AccountTheftID = 6;

	public static byte InappropriateContentID = 7;

	public static byte RealLifeThreatsID = 8;

	public static byte OtherRuleViolationID = 9;

	public static byte WatchDogSuspiciousID = 11;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: false, hasUnqualifiedCollections: false), typeof(ReportCategory).ToString(), isNullCacheable: true);

	public byte ID => _EntityDAL.ID;

	public string InternalName
	{
		get
		{
			return _EntityDAL.InternalName;
		}
		set
		{
			_EntityDAL.InternalName = value;
		}
	}

	public string PublicName
	{
		get
		{
			return _EntityDAL.PublicName;
		}
		set
		{
			_EntityDAL.PublicName = value;
		}
	}

	public bool IsVisible
	{
		get
		{
			return _EntityDAL.IsVisible;
		}
		set
		{
			_EntityDAL.IsVisible = value;
		}
	}

	public byte PublicSortOrder
	{
		get
		{
			return _EntityDAL.PublicSortOrder;
		}
		set
		{
			_EntityDAL.PublicSortOrder = value;
		}
	}

	public byte DefaultPriority
	{
		get
		{
			return _EntityDAL.DefaultPriority;
		}
		set
		{
			_EntityDAL.DefaultPriority = value;
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

	public ReportCategory()
	{
		_EntityDAL = new ReportCategoryDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static ReportCategory CreateNew(string internalName, string publicName, bool isVisible, byte publicSortOrder, byte defaultPriority)
	{
		ReportCategory reportCategory = new ReportCategory();
		reportCategory.InternalName = internalName;
		reportCategory.PublicName = publicName;
		reportCategory.IsVisible = isVisible;
		reportCategory.PublicSortOrder = publicSortOrder;
		reportCategory.DefaultPriority = defaultPriority;
		reportCategory.Save();
		return reportCategory;
	}

	public static ReportCategory Get(byte id)
	{
		return EntityHelper.GetEntity<byte, ReportCategoryDAL, ReportCategory>(EntityCacheInfo, id, () => ReportCategoryDAL.Get(id));
	}

	public void Construct(ReportCategoryDAL dal)
	{
		_EntityDAL = dal;
	}

	public static ICollection<ReportCategory> GetReportCategoriesByIsVisiblePaged(bool isVisible, int startRowIndex, int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"IsVisible:{isVisible}"), $"GetReportCategoriesByIsVisiblePaged_IsVisible:{isVisible}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}", () => ReportCategoryDAL.GetReportCategoriesByIsVisiblePaged(isVisible, startRowIndex, maximumRows), Get);
	}

	public static int GetTotalNumberOfReportCategoriesByIsVisible(bool isVisible)
	{
		string countID = $"GetTotalNumberOfReportCategoriesByIsVisible_IsVisible:{isVisible}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"IsVisible:{isVisible}"), countID, () => ReportCategoryDAL.GetTotalNumberOfReportCategoriesByIsVisible(isVisible));
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"IsVisible:{IsVisible}");
	}
}
