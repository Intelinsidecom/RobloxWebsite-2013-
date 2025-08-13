using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class PromoCode : IRobloxEntity<int, PromoCodeDAL>, ICacheableObject<int>, ICacheableObject
{
	private PromoCodeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PromoCode).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Code
	{
		get
		{
			return _EntityDAL.Code;
		}
		set
		{
			_EntityDAL.Code = value;
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

	public DateTime StartDate
	{
		get
		{
			return _EntityDAL.StartDate;
		}
		set
		{
			_EntityDAL.StartDate = value;
		}
	}

	public DateTime EndDate
	{
		get
		{
			return _EntityDAL.EndDate;
		}
		set
		{
			_EntityDAL.EndDate = value;
		}
	}

	public bool IsEnabled
	{
		get
		{
			return _EntityDAL.IsEnabled;
		}
		set
		{
			_EntityDAL.IsEnabled = value;
		}
	}

	internal DateTime Created
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

	internal DateTime Updated
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

	public PromoCode()
	{
		_EntityDAL = new PromoCodeDAL();
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static PromoCode Get(int id)
	{
		return EntityHelper.GetEntity<int, PromoCodeDAL, PromoCode>(EntityCacheInfo, id, () => PromoCodeDAL.Get(id));
	}

	internal static ICollection<PromoCode> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, PromoCodeDAL, PromoCode>(ids, EntityCacheInfo, PromoCodeDAL.MultiGet);
	}

	public static PromoCode GetByCode(string code)
	{
		return EntityHelper.GetEntityByLookup<int, PromoCodeDAL, PromoCode>(EntityCacheInfo, $"Code:{code}", () => PromoCodeDAL.GetPromoCodeByCode(code));
	}

	public static ICollection<PromoCode> GetAllPromoCodesPaged(int startRowIndex, int maxRows)
	{
		string collectionId = $"GetPromoCodesPaged_StartRowIndex:{startRowIndex}_MaxRows:{maxRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "GetAllPromoCodesPaged"), collectionId, () => PromoCodeDAL.GetPromoCodeIDsPaged(startRowIndex, maxRows), MultiGet);
	}

	public static int GetTotalNumberOfPromoCodes()
	{
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, "GetTotalNumberOfPromoCodes"), "GetTotalNumberOfPromoCodes", PromoCodeDAL.GetTotalNumberOfPromoCodes);
	}

	public void Construct(PromoCodeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Code:{Code}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("GetAllPromoCodesPaged");
		yield return new StateToken("GetTotalNumberOfPromoCodes");
	}
}
