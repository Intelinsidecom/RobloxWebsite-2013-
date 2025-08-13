using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarAssetOverrideEntity : IRobloxEntity<long, UniverseAvatarAssetOverrideDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseAvatarAssetOverrideDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(UniverseAvatarAssetOverrideEntity).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	internal long AssetID
	{
		get
		{
			return _EntityDAL.AssetID;
		}
		set
		{
			_EntityDAL.AssetID = value;
		}
	}

	internal int AssetTypeID
	{
		get
		{
			return _EntityDAL.AssetTypeID;
		}
		set
		{
			_EntityDAL.AssetTypeID = value;
		}
	}

	internal bool IsPlayerChoice
	{
		get
		{
			return _EntityDAL.IsPlayerChoice;
		}
		set
		{
			_EntityDAL.IsPlayerChoice = value;
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

	public UniverseAvatarAssetOverrideEntity()
	{
		_EntityDAL = new UniverseAvatarAssetOverrideDAL();
	}

	public UniverseAvatarAssetOverrideEntity(UniverseAvatarAssetOverrideDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public static UniverseAvatarAssetOverrideEntity Create(long universeId, long assetId, int assetTypeId, bool isPlayerChoice)
	{
		UniverseAvatarAssetOverrideEntity universeAvatarAssetOverrideEntity = new UniverseAvatarAssetOverrideEntity();
		universeAvatarAssetOverrideEntity.UniverseID = universeId;
		universeAvatarAssetOverrideEntity.AssetID = assetId;
		universeAvatarAssetOverrideEntity.AssetTypeID = assetTypeId;
		universeAvatarAssetOverrideEntity.IsPlayerChoice = isPlayerChoice;
		universeAvatarAssetOverrideEntity.Save();
		return universeAvatarAssetOverrideEntity;
	}

	internal void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static UniverseAvatarAssetOverrideEntity Get(long id)
	{
		return EntityHelper.GetEntity<long, UniverseAvatarAssetOverrideDAL, UniverseAvatarAssetOverrideEntity>(EntityCacheInfo, id, () => UniverseAvatarAssetOverrideDAL.Get(id));
	}

	private static ICollection<UniverseAvatarAssetOverrideEntity> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UniverseAvatarAssetOverrideDAL, UniverseAvatarAssetOverrideEntity>(ids, EntityCacheInfo, UniverseAvatarAssetOverrideDAL.MultiGet);
	}

	public static ICollection<UniverseAvatarAssetOverrideEntity> GetUniverseAvatarAssetOverridesByUniverseIDPaged(long universeId, int count, long exclusiveStartUniverseInstanceId)
	{
		string collectionId = $"GetUniverseAvatarAssetOverridesByUniverseIDPaged_UniverseID:{universeId}_Count:{count}_ExclusiveStartUniverseInstanceId:{exclusiveStartUniverseInstanceId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, GetUniverseKey(universeId)), collectionId, () => UniverseAvatarAssetOverrideDAL.GetUniverseAvatarAssetOverridesByUniverseIDPaged(universeId, count, exclusiveStartUniverseInstanceId), Get);
	}

	public void Construct(UniverseAvatarAssetOverrideDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetUniverseKey(UniverseID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetUniverseKey(UniverseID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetUniverseKey(long universeID)
	{
		return string.Format($"UniverseId:{0}", universeID);
	}
}
