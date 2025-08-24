using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataV2.Core;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games.Entities;

internal class GameAttributes : IRobloxEntity<long, GameAttributesDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GameAttributesDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(GameAttributes).ToString(), isNullCacheable: true);

	private static bool IsRemoteCachingEnabled => Settings.Default.IsRemoteCachingEnabled;

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

	internal bool IsSecure
	{
		get
		{
			return _EntityDAL.IsSecure;
		}
		set
		{
			_EntityDAL.IsSecure = value;
		}
	}

	internal bool IsTrusted
	{
		get
		{
			return _EntityDAL.IsTrusted;
		}
		set
		{
			_EntityDAL.IsTrusted = value;
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

	public GameAttributes()
	{
		_EntityDAL = new GameAttributesDAL();
	}

	public GameAttributes(GameAttributesDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		if (IsRemoteCachingEnabled)
		{
			EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
		}
		else
		{
			EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		}
	}

	internal void Save()
	{
		if (IsRemoteCachingEnabled)
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
		else
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
	}

	internal static GameAttributes Get(long id)
	{
		if (id <= 0)
		{
			return null;
		}
		return EntityHelper.GetEntity<long, GameAttributesDAL, GameAttributes>(EntityCacheInfo, id, () => GameAttributesDAL.Get(id));
	}

	private static ICollection<GameAttributes> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, GameAttributesDAL, GameAttributes>(ids, EntityCacheInfo, GameAttributesDAL.MultiGet);
	}

	internal static ICollection<GameAttributes> GetGameAttributesByIsTrusted(bool isTrusted, long exclusiveStartUniverseId, int count, SortOrder sortOrder)
	{
		string collectionId = $"GetGameAttributesByIsTrusted_IsTrusted:{isTrusted}_ExclusiveStartUniverseID:{exclusiveStartUniverseId}_Count:{count}_SortOrder:{sortOrder}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByIsTrusted(isTrusted)), collectionId, () => GameAttributesDAL.GetGameAttributeIDsByIsTrusted(isTrusted, exclusiveStartUniverseId, count, sortOrder), MultiGet);
	}

	public static GameAttributes GetByUniverseID(long universeId)
	{
		if (IsRemoteCachingEnabled)
		{
			return EntityHelper.GetEntityByLookupWithRemoteCache<long, GameAttributesDAL, GameAttributes>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => GameAttributesDAL.GetGameAttributeByUniverseID(universeId), Get);
		}
		return EntityHelper.GetEntityByLookup<long, GameAttributesDAL, GameAttributes>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => GameAttributesDAL.GetGameAttributeByUniverseID(universeId));
	}

	public static GameAttributes GetOrCreate(long universeId)
	{
		if (IsRemoteCachingEnabled)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, GameAttributes>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => DoGetOrCreate(universeId), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, GameAttributes>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => DoGetOrCreate(universeId));
	}

	private static GameAttributes DoGetOrCreate(long universeId)
	{
		return EntityHelper.DoGetOrCreate<long, GameAttributesDAL, GameAttributes>(() => GameAttributesDAL.GetOrCreateGameAttribute(universeId));
	}

	public void Construct(GameAttributesDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUniverseID(UniverseID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByIsTrusted(IsTrusted));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUniverseID(long universeId)
	{
		return $"UniverseID:{universeId}";
	}

	private static string GetLookupCacheKeysByIsTrusted(bool isTrusted)
	{
		return $"IsTrusted:{isTrusted}";
	}
}
