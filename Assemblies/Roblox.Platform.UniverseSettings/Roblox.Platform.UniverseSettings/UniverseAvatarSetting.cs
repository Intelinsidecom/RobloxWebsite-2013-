using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Platform.UniverseSettings.Properties;

namespace Roblox.Platform.UniverseSettings;

[ExcludeFromCodeCoverage]
internal class UniverseAvatarSetting : IRobloxEntity<long, UniverseAvatarSettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UniverseAvatarSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.UniverseAvatarSettings.UniverseAvatarSetting", isNullCacheable: true);

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

	internal byte UniverseAvatarTypeID
	{
		get
		{
			return _EntityDAL.UniverseAvatarTypeID;
		}
		set
		{
			_EntityDAL.UniverseAvatarTypeID = value;
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

	internal byte? UniverseScaleTypeID
	{
		get
		{
			return _EntityDAL.UniverseScaleTypeID;
		}
		set
		{
			_EntityDAL.UniverseScaleTypeID = value;
		}
	}

	internal byte? UniverseAvatarAnimationTypeID
	{
		get
		{
			return _EntityDAL.UniverseAvatarAnimationTypeID;
		}
		set
		{
			_EntityDAL.UniverseAvatarAnimationTypeID = value;
		}
	}

	internal byte? UniverseAvatarCollisionTypeID
	{
		get
		{
			return _EntityDAL.UniverseAvatarCollisionTypeID;
		}
		set
		{
			_EntityDAL.UniverseAvatarCollisionTypeID = value;
		}
	}

	internal byte? UniverseAvatarBodyTypeID
	{
		get
		{
			return _EntityDAL.UniverseAvatarBodyTypeID;
		}
		set
		{
			_EntityDAL.UniverseAvatarBodyTypeID = value;
		}
	}

	internal byte? UniverseAvatarJointPositioningTypeID
	{
		get
		{
			return _EntityDAL.UniverseAvatarJointPositioningTypeID;
		}
		set
		{
			_EntityDAL.UniverseAvatarJointPositioningTypeID = value;
		}
	}

	internal int? UniverseAvatarMinScaleID
	{
		get
		{
			return _EntityDAL.UniverseAvatarMinScaleID;
		}
		set
		{
			_EntityDAL.UniverseAvatarMinScaleID = value;
		}
	}

	internal int? UniverseAvatarMaxScaleID
	{
		get
		{
			return _EntityDAL.UniverseAvatarMaxScaleID;
		}
		set
		{
			_EntityDAL.UniverseAvatarMaxScaleID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UniverseAvatarSetting()
		: this(new UniverseAvatarSettingDAL())
	{
	}

	public UniverseAvatarSetting(UniverseAvatarSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	internal void Delete()
	{
		if (Settings.Default.EnableRemoteCacheForUniverseAvatarSettingsEntity)
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
		if (Settings.Default.EnableRemoteCacheForUniverseAvatarSettingsEntity)
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

	internal static UniverseAvatarSetting Get(long id)
	{
		return EntityHelper.GetEntity<long, UniverseAvatarSettingDAL, UniverseAvatarSetting>(EntityCacheInfo, id, () => UniverseAvatarSettingDAL.Get(id));
	}

	internal static ICollection<UniverseAvatarSetting> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UniverseAvatarSettingDAL, UniverseAvatarSetting>(ids, EntityCacheInfo, UniverseAvatarSettingDAL.MultiGet);
	}

	public static UniverseAvatarSetting GetByUniverseID(long universeId)
	{
		return EntityHelper.GetEntityByLookup<long, UniverseAvatarSettingDAL, UniverseAvatarSetting>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => UniverseAvatarSettingDAL.GetUniverseAvatarSettingByUniverseID(universeId));
	}

	public static UniverseAvatarSetting GetOrCreate(long universeId, byte universeAvatarTypeId, byte? universeScaleTypeId, byte? universeAvatarAnimationTypeId, byte? universeAvatarCollisionTypeId, byte? universeAvatarBodyTypeID, byte? universeAvatarJointPositioningTypeID, int? universeAvatarMinScaleID, int? universeAvatarMaxScaleID)
	{
		if (Settings.Default.EnableRemoteCacheForUniverseAvatarSettingsEntity)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, UniverseAvatarSetting>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => DoGetOrCreate(universeId, universeAvatarTypeId, universeScaleTypeId, universeAvatarAnimationTypeId, universeAvatarCollisionTypeId, universeAvatarBodyTypeID, universeAvatarJointPositioningTypeID, universeAvatarMinScaleID, universeAvatarMaxScaleID), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, UniverseAvatarSetting>(EntityCacheInfo, GetLookupCacheKeysByUniverseID(universeId), () => DoGetOrCreate(universeId, universeAvatarTypeId, universeScaleTypeId, universeAvatarAnimationTypeId, universeAvatarCollisionTypeId, universeAvatarBodyTypeID, universeAvatarJointPositioningTypeID, universeAvatarMinScaleID, universeAvatarMaxScaleID));
	}

	private static UniverseAvatarSetting DoGetOrCreate(long universeId, byte universeAvatarTypeId, byte? universeScaleTypeId, byte? universeAvatarAnimationTypeId, byte? universeAvatarCollisionTypeId, byte? universeAvatarBodyTypeID, byte? universeAvatarJointPositioningTypeID, int? universeAvatarMinScaleID, int? universeAvatarMaxScaleID)
	{
		return EntityHelper.DoGetOrCreate<long, UniverseAvatarSettingDAL, UniverseAvatarSetting>(() => UniverseAvatarSettingDAL.GetOrCreateUniverseAvatarSetting(universeId, universeAvatarTypeId, universeScaleTypeId, universeAvatarAnimationTypeId, universeAvatarCollisionTypeId, universeAvatarBodyTypeID, universeAvatarJointPositioningTypeID, universeAvatarMinScaleID, universeAvatarMaxScaleID));
	}

	public void Construct(UniverseAvatarSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUniverseID(UniverseID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByUniverseID(long universeId)
	{
		return $"UniverseID:{universeId}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
