using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.UserSetting.Entities;

[ExcludeFromCodeCoverage]
internal class UserSetting : IRobloxEntity<long, UserSettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private UserSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UserSetting).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UserID
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

	internal bool CuratedGamesOnlyIsEnabled
	{
		get
		{
			return _EntityDAL.CuratedGamesOnlyIsEnabled;
		}
		set
		{
			_EntityDAL.CuratedGamesOnlyIsEnabled = value;
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

	public UserSetting()
	{
		_EntityDAL = new UserSettingDAL();
	}

	public UserSetting(UserSettingDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

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
	}

	internal static UserSetting Get(long id)
	{
		return EntityHelper.GetEntity<long, UserSettingDAL, UserSetting>(EntityCacheInfo, id, () => UserSettingDAL.Get(id));
	}

	private static ICollection<UserSetting> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UserSettingDAL, UserSetting>(ids, EntityCacheInfo, UserSettingDAL.MultiGet);
	}

	public static UserSetting GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, UserSetting>(EntityCacheInfo, GetLookupCacheKeysByUserID(userId), () => DoGetOrCreate(userId), Get);
	}

	private static UserSetting DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<long, UserSettingDAL, UserSetting>(() => UserSettingDAL.GetOrCreateUserSetting(userId));
	}

	public void Construct(UserSettingDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByUserID(UserID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUserID(long userId)
	{
		return $"UserID:{userId}";
	}
}
