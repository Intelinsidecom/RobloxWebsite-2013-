using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Places.Entities;

/// <summary>
/// This class contains code that cannot be overwritten by files generated from the dbwireup tool
/// </summary>
[ExcludeFromCodeCoverage]
internal class GameConstraint : IRobloxEntity<long, GameConstraintDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GameConstraintDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Web.Games.GameConstraint", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PlaceID
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

	internal int MaxPlayers
	{
		get
		{
			return _EntityDAL.MaxPlayers;
		}
		set
		{
			_EntityDAL.MaxPlayers = value;
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

	internal int? SocialSlots
	{
		get
		{
			return _EntityDAL.SocialSlots;
		}
		set
		{
			_EntityDAL.SocialSlots = value;
		}
	}

	internal int? SocialSlotTypeID
	{
		get
		{
			return _EntityDAL.SocialSlotTypeID;
		}
		set
		{
			_EntityDAL.SocialSlotTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public GameConstraint()
	{
		_EntityDAL = new GameConstraintDAL();
	}

	public GameConstraint(GameConstraintDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	internal static GameConstraint Get(long id)
	{
		return EntityHelper.GetEntity<long, GameConstraintDAL, GameConstraint>(EntityCacheInfo, id, () => GameConstraintDAL.Get(id));
	}

	public static GameConstraint GetByPlaceID(long placeId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, GameConstraintDAL, GameConstraint>(EntityCacheInfo, GetLookupCacheKeysByPlaceID(placeId), () => GameConstraintDAL.GetGameConstraintByPlaceID(placeId), Get);
	}

	public void Construct(GameConstraintDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPlaceID(PlaceID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByPlaceID(long placeId)
	{
		return $"PlaceID:{placeId}";
	}

	public static GameConstraint GetOrCreate(long placeId, int defaultMaxPlayers)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, GameConstraint>(EntityCacheInfo, GetLookupCacheKeysByPlaceID(placeId), () => DoGetOrCreate(placeId, defaultMaxPlayers), Get);
	}

	private static GameConstraint DoGetOrCreate(long placeId, int defaultMaxPlayers)
	{
		return EntityHelper.DoGetOrCreate<long, GameConstraintDAL, GameConstraint>(() => GameConstraintDAL.GetOrCreateGameConstraint(placeId, defaultMaxPlayers));
	}
}
