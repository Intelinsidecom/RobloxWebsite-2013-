using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.ContentRatings;

public class AssetContentRating : IRobloxEntity<long, AssetContentRatingDAL>, ICacheableObject<long>, ICacheableObject
{
	private AssetContentRatingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Assets.AssetContentRating", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AssetHashID
	{
		get
		{
			return _EntityDAL.AssetHashID;
		}
		set
		{
			_EntityDAL.AssetHashID = value;
		}
	}

	public byte ContentRatingTypeID
	{
		get
		{
			return _EntityDAL.ContentRatingTypeID;
		}
		set
		{
			_EntityDAL.ContentRatingTypeID = value;
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

	public AssetContentRating()
	{
		_EntityDAL = new AssetContentRatingDAL();
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

	public static AssetContentRating CreateNew(long assethashid, byte contentratingtypeid)
	{
		AssetContentRating assetContentRating = new AssetContentRating();
		assetContentRating.AssetHashID = assethashid;
		assetContentRating.ContentRatingTypeID = contentratingtypeid;
		assetContentRating.Save();
		return assetContentRating;
	}

	public static AssetContentRating Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetContentRatingDAL, AssetContentRating>(EntityCacheInfo, id, () => AssetContentRatingDAL.Get(id));
	}

	public static AssetContentRating GetByAssetHashID(long assetHashID)
	{
		return EntityHelper.GetEntityByLookup<long, AssetContentRatingDAL, AssetContentRating>(EntityCacheInfo, $"AssetHashID:{assetHashID}", () => AssetContentRatingDAL.GetByAssetHashID(assetHashID));
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Construct(AssetContentRatingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetHashID:{AssetHashID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
