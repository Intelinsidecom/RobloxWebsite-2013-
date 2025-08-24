using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class PromoCodeRedemption : IRobloxEntity<long, PromoCodeRedemptionDAL>, ICacheableObject<long>, ICacheableObject
{
	private PromoCodeRedemptionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PromoCodeRedemption).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int PromoCodeID
	{
		get
		{
			return _EntityDAL.PromoCodeID;
		}
		set
		{
			_EntityDAL.PromoCodeID = value;
		}
	}

	public long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public PromoCodeRedemption()
	{
		_EntityDAL = new PromoCodeRedemptionDAL();
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

	internal static PromoCodeRedemption Get(long id)
	{
		return EntityHelper.GetEntity<long, PromoCodeRedemptionDAL, PromoCodeRedemption>(EntityCacheInfo, id, () => PromoCodeRedemptionDAL.Get(id));
	}

	internal static ICollection<PromoCodeRedemption> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PromoCodeRedemptionDAL, PromoCodeRedemption>(ids, EntityCacheInfo, PromoCodeRedemptionDAL.MultiGet);
	}

	public static PromoCodeRedemption GetByPromoCodeIDAndUserID(int promoCodeId, long userId)
	{
		return EntityHelper.GetEntityByLookup<long, PromoCodeRedemptionDAL, PromoCodeRedemption>(EntityCacheInfo, $"PromoCodeID:{promoCodeId}_UserID:{userId}", () => PromoCodeRedemptionDAL.GetPromoCodeRedemptionByPromoCodeIDAndUserID(promoCodeId, userId));
	}

	public static long GetTotalNumberOfPromoCodeRedemptionsByPromoCodeID(int promoCodeID)
	{
		string countId = $"GetTotalNumberOfPromoCodeRedemptionsByPromoCodeID_PromoCodeID:{promoCodeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PromoCodeID:{promoCodeID}"), countId, () => PromoCodeRedemptionDAL.GetTotalNumberOfPromoCodeRedemptionsByPromoCodeID(promoCodeID));
	}

	public void Construct(PromoCodeRedemptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PromoCodeID:{PromoCodeID}_UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PromoCodeID:{PromoCodeID}");
	}
}
