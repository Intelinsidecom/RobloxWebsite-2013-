using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Assets.Places;

internal class PlaceAttribute : IRobloxEntity<long, PlaceAttributeDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private PlaceAttributeDAL _EntityDAL;

	/// <summary>
	/// The ID of the previous universe.
	/// </summary>
	/// <remarks>Used for cache invalidation.</remarks>
	private long? _OriginalUniverseID;

	private bool _OriginalUniverseIDIsDirty;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PlaceAttribute).ToString(), isNullCacheable: true);

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

	public byte PlaceTypeID
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

	public bool? UsePlaceMediaForThumb
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

	public bool? OverridesDefaultAvatar
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

	public bool? UsePortraitMode
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

	public bool? IsFilteringEnabled
	{
		get
		{
			return _EntityDAL.IsFilteringEnabled;
		}
		internal set
		{
			_EntityDAL.IsFilteringEnabled = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public PlaceAttribute()
	{
		_EntityDAL = new PlaceAttributeDAL();
	}

	public PlaceAttribute(PlaceAttributeDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
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
		_OriginalUniverseID = null;
		_OriginalUniverseIDIsDirty = false;
	}

	public static PlaceAttribute Get(long id)
	{
		return EntityHelper.GetEntity<long, PlaceAttributeDAL, PlaceAttribute>(EntityCacheInfo, id, () => PlaceAttributeDAL.Get(id));
	}

	internal static ICollection<PlaceAttribute> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PlaceAttributeDAL, PlaceAttribute>(ids, EntityCacheInfo, PlaceAttributeDAL.MultiGet);
	}

	public static PlaceAttribute GetByPlaceID(long placeID)
	{
		return EntityHelper.GetEntityByLookup<long, PlaceAttributeDAL, PlaceAttribute>(EntityCacheInfo, $"PlaceID:{placeID}", () => PlaceAttributeDAL.GetPlaceAttributeByPlaceID(placeID));
	}

	public static PlaceAttribute GetOrCreate(long placeID, byte placeTypeID)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, PlaceAttribute>(EntityCacheInfo, $"PlaceID:{placeID}", () => DoGetOrCreate(placeID, placeTypeID), Get);
	}

	private static PlaceAttribute DoGetOrCreate(long placeID, byte placeTypeID)
	{
		return EntityHelper.DoGetOrCreate<long, PlaceAttributeDAL, PlaceAttribute>(() => PlaceAttributeDAL.GetOrCreatePlaceAttribute(placeID, placeTypeID));
	}

	public static ICollection<PlaceAttribute> GetPlaceAttributesByUniverseIDAndIsFilteringEnabled(long? universeId, bool? isFilteringEnabled, int count, long exclusiveStartId)
	{
		string collectionId = $"GetPlaceAttributesByUniverseIDAndIsFilterEnabled_UniverseID:{universeId}_IsFilteringEnabled:{isFilteringEnabled}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(universeId, isFilteringEnabled)), collectionId, () => PlaceAttributeDAL.GetPlaceAttributeIDsByUniverseIDAndIsFilteringEnabled(universeId, isFilteringEnabled, count, exclusiveStartId), MultiGet);
	}

	public void Construct(PlaceAttributeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PlaceID:{PlaceID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (_OriginalUniverseIDIsDirty)
		{
			yield return new StateToken(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(_OriginalUniverseID, IsFilteringEnabled));
		}
		yield return new StateToken(GetLookupCacheKeysByUniverseIDIsFilteringEnabled(UniverseID, IsFilteringEnabled));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUniverseIDIsFilteringEnabled(long? universeId, bool? isFilteringEnabled)
	{
		return $"UniverseID:{universeId}_IsFilteringEnabled:{isFilteringEnabled}";
	}
}
