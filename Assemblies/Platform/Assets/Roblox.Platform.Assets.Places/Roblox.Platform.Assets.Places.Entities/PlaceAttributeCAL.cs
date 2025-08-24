using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Places.Entities;

[ExcludeFromCodeCoverage]
internal class PlaceAttributeCAL : IRobloxEntity<long, PlaceAttributeDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	/// <summary>
	/// The ID of the previous universe.
	/// </summary>
	/// <remarks>Used for cache invalidation.</remarks>
	private long? _OriginalUniverseID;

	private bool _OriginalUniverseIDIsDirty;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.Assets.Places.PlaceAttribute", isNullCacheable: true);

	private PlaceAttributeDAL _EntityDAL;

	internal long? UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			if (_EntityDAL.UniverseID != value && !_OriginalUniverseIDIsDirty)
			{
				_OriginalUniverseID = _EntityDAL.UniverseID;
				_OriginalUniverseIDIsDirty = true;
			}
			_EntityDAL.UniverseID = value;
		}
	}

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

	internal byte PlaceTypeID
	{
		get
		{
			return _EntityDAL.PlaceTypeID;
		}
		set
		{
			_EntityDAL.PlaceTypeID = value;
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

	internal bool? UsePlaceMediaForThumb
	{
		get
		{
			return _EntityDAL.UsePlaceMediaForThumb;
		}
		set
		{
			_EntityDAL.UsePlaceMediaForThumb = value;
		}
	}

	internal bool? OverridesDefaultAvatar
	{
		get
		{
			return _EntityDAL.OverridesDefaultAvatar;
		}
		set
		{
			_EntityDAL.OverridesDefaultAvatar = value;
		}
	}

	internal bool? UsePortraitMode
	{
		get
		{
			return _EntityDAL.UsePortraitMode;
		}
		set
		{
			_EntityDAL.UsePortraitMode = value;
		}
	}

	internal bool? IsFilteringEnabled
	{
		get
		{
			return _EntityDAL.IsFilteringEnabled;
		}
		set
		{
			_EntityDAL.IsFilteringEnabled = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	internal void Save()
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
		_OriginalUniverseID = null;
		_OriginalUniverseIDIsDirty = false;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (_OriginalUniverseIDIsDirty)
		{
			yield return new StateToken(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(_OriginalUniverseID, IsFilteringEnabled));
		}
		yield return new StateToken(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(UniverseID, IsFilteringEnabled));
	}

	/// <summary>
	/// Irregular GetOrCreate -- GET by placeID only, CREATE by placeID and placeTypeID
	/// </summary>
	public static PlaceAttributeCAL GetByPlaceIdOrCreateByPlaceIdAndPlaceTypeId(long placeID, byte placeTypeID)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, PlaceAttributeCAL>(EntityCacheInfo, $"PlaceID:{placeID}", () => DoGetOrCreate(placeID, placeTypeID), Get);
	}

	private static PlaceAttributeCAL DoGetOrCreate(long placeID, byte placeTypeID)
	{
		return EntityHelper.DoGetOrCreate<long, PlaceAttributeDAL, PlaceAttributeCAL>(() => PlaceAttributeDAL.GetByPlaceIdOrCreateByPlaceIdAndPlaceTypeId(placeID, placeTypeID));
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public PlaceAttributeCAL()
	{
		_EntityDAL = new PlaceAttributeDAL();
	}

	public PlaceAttributeCAL(PlaceAttributeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal static PlaceAttributeCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceAttributeDAL, PlaceAttributeCAL>(EntityCacheInfo, id, () => PlaceAttributeDAL.Get(id));
	}

	internal static ICollection<PlaceAttributeCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PlaceAttributeDAL, PlaceAttributeCAL>(ids, EntityCacheInfo, PlaceAttributeDAL.MultiGet);
	}

	public static PlaceAttributeCAL GetByPlaceID(long placeId)
	{
		return EntityHelper.GetEntityByLookup<long, PlaceAttributeDAL, PlaceAttributeCAL>(EntityCacheInfo, GetLookupCacheKeysByPlaceID(placeId), () => PlaceAttributeDAL.GetPlaceAttributeByPlaceID(placeId));
	}

	internal static ICollection<PlaceAttributeCAL> GetPlaceAttributesByUniverseIDAndIsFilteringEnabled(long? universeId, bool? isFilteringEnabled, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetPlaceAttributesByUniverseIDAndIsFilterEnabled_UniverseID:{universeId}_IsFilterEnabled:{isFilteringEnabled}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(universeId, isFilteringEnabled)), collectionId, () => PlaceAttributeDAL.GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled(universeId, isFilteringEnabled, count, exclusiveStartId), MultiGet);
	}

	public void Construct(PlaceAttributeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPlaceID(PlaceID);
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByPlaceID(long placeId)
	{
		return $"PlaceID:{placeId}";
	}

	private static string GetLookupCacheKeysByUniverseIDIsFilteringEnabled(long? universeId, bool? isFilteringEnabled)
	{
		return $"UniverseID:{universeId}_IsFilteringEnabled:{isFilteringEnabled}";
	}
}
