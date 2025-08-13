using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class PlaceProductPromotion : IRobloxEntity<long, PlaceProductPromotionDAL>, ICacheableObject<long>, ICacheableObject
{
	private PlaceProductPromotionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Economy.PlaceProductPromotion", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long PlaceID
	{
		get
		{
			return _EntityDAL.PlaceID;
		}
		set
		{
			_EntityDAL.PlaceID = value;
		}
	}

	public long ProductID
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

	public int SortOrder
	{
		get
		{
			return _EntityDAL.SortOrder;
		}
		set
		{
			_EntityDAL.SortOrder = value;
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

	public PlaceProductPromotion()
	{
		_EntityDAL = new PlaceProductPromotionDAL();
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

	public static PlaceProductPromotion CreateNew(long placeid, long productid, int sortorder)
	{
		PlaceProductPromotion placeProductPromotion = new PlaceProductPromotion();
		placeProductPromotion.PlaceID = placeid;
		placeProductPromotion.ProductID = productid;
		placeProductPromotion.SortOrder = sortorder;
		placeProductPromotion.Save();
		return placeProductPromotion;
	}

	public static PlaceProductPromotion Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceProductPromotionDAL, PlaceProductPromotion>(EntityCacheInfo, id, () => PlaceProductPromotionDAL.Get(id));
	}

	public static ICollection<PlaceProductPromotion> GetPlaceProductPromotionsByPlaceID_Paged(long placeId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetPlaceProductPromotionsByPlaceID_Paged_PlaceID:{placeId}_StartRowIndex:{startRowIndex}_MaxRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), collectionId, () => PlaceProductPromotionDAL.GetPlaceProductPromotionIDsByPlaceID_Paged(placeId, startRowIndex, maximumRows), Get);
	}

	public static long GetTotalNumberOfPlaceProductPromotionsByPlaceID(long placeId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value placeId not supplied: " + placeId);
		}
		string countId = $"GetTotalNumberOfPlaceProductPromotionsByPlaceID_PlaceID:{placeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"PlaceID:{placeId}"), countId, () => PlaceProductPromotionDAL.GetTotalNumberOfProductPromotionIDsByPlaceID(placeId));
	}

	public static PlaceProductPromotion GetPlaceProductPromotionByPlaceIDAndProductID(long placeId, long productId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value placeId not supplied: " + placeId);
		}
		if (productId == 0L)
		{
			throw new ApplicationException("Required value productId not supplied: " + productId);
		}
		string id = $"PlaceID:{placeId}_ProductID:{productId}";
		return EntityHelper.GetEntityByLookup<long, PlaceProductPromotionDAL, PlaceProductPromotion>(EntityCacheInfo, id, () => PlaceProductPromotionDAL.GetPlaceProductPromotionByPlaceIDAndProductID(placeId, productId));
	}

	public void Construct(PlaceProductPromotionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PlaceID:{PlaceID}_ProductID:{ProductID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PlaceID:{PlaceID}");
	}
}
