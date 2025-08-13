using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Outfits;

public class Outfit : IRobloxEntity<long, OutfitDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private OutfitDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Outfit).ToString(), isNullCacheable: true);

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

	public long BodyColorSetID
	{
		get
		{
			return _EntityDAL.BodyColorSetID;
		}
		set
		{
			_EntityDAL.BodyColorSetID = value;
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

	public int? ScaleID
	{
		get
		{
			return _EntityDAL.ScaleID;
		}
		set
		{
			_EntityDAL.ScaleID = value;
		}
	}

	public byte? PlayerAvatarTypeID
	{
		get
		{
			return _EntityDAL.PlayerAvatarTypeID;
		}
		set
		{
			_EntityDAL.PlayerAvatarTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Outfit()
	{
		_EntityDAL = new OutfitDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
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

	public static Outfit CreateNew(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId)
	{
		Outfit outfit = new Outfit();
		outfit.AssetHashID = assetHashId;
		outfit.BodyColorSetID = bodyColorSetId;
		outfit.ScaleID = scaleId;
		outfit.PlayerAvatarTypeID = playerAvatarTypeId;
		outfit.Save();
		return outfit;
	}

	public static Outfit GetOrCreate(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId, out bool createdNewEntity)
	{
		bool created = false;
		Outfit orCreateEntityWithRemoteCache = EntityHelper.GetOrCreateEntityWithRemoteCache<long, Outfit>(EntityCacheInfo, GetLookupCacheKeyByAssetHashID(assetHashId), () => DoGetOrCreate(assetHashId, bodyColorSetId, scaleId, playerAvatarTypeId, out created), Get);
		createdNewEntity = created;
		return orCreateEntityWithRemoteCache;
	}

	private static Outfit DoGetOrCreate(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId, out bool createdNewEntity)
	{
		bool created = false;
		Outfit result = EntityHelper.DoGetOrCreate<long, OutfitDAL, Outfit>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<OutfitDAL> orCreateOutfit = OutfitDAL.GetOrCreateOutfit(assetHashId, bodyColorSetId, scaleId, playerAvatarTypeId);
			created = orCreateOutfit.CreatedNewEntity;
			return orCreateOutfit;
		});
		createdNewEntity = created;
		return result;
	}

	public static Outfit Get(long id)
	{
		return EntityHelper.GetEntity<long, OutfitDAL, Outfit>(EntityCacheInfo, id, () => OutfitDAL.Get(id));
	}

	public static ICollection<Outfit> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, OutfitDAL, Outfit>(ids, EntityCacheInfo, OutfitDAL.MultiGet);
	}

	public static Outfit GetOutfitByAssetHashID(long assetHashId)
	{
		return EntityHelper.GetEntityByLookup<long, OutfitDAL, Outfit>(EntityCacheInfo, GetLookupCacheKeyByAssetHashID(assetHashId), () => OutfitDAL.GetByAssetHashID(assetHashId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	public void Construct(OutfitDAL dal)
	{
		_EntityDAL = dal;
	}

	private static string GetLookupCacheKeyByAssetHashID(long assetHashId)
	{
		return $"AssetHashID:{assetHashId}";
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return GetLookupCacheKeyByAssetHashID(AssetHashID);
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
