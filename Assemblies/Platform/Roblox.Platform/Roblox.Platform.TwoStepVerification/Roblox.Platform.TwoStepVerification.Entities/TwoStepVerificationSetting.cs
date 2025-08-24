using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSetting : IRobloxEntity<long, TwoStepVerificationSettingDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private TwoStepVerificationSettingDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TwoStepVerificationSetting).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal bool IsEnabled
	{
		get
		{
			return _EntityDAL.IsEnabled;
		}
		set
		{
			_EntityDAL.IsEnabled = value;
		}
	}

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

	internal byte? TwoStepVerificationMediaTypeID
	{
		get
		{
			return _EntityDAL.TwoStepVerificationMediaTypeID;
		}
		set
		{
			_EntityDAL.TwoStepVerificationMediaTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TwoStepVerificationSetting()
	{
		_EntityDAL = new TwoStepVerificationSettingDAL();
	}

	public TwoStepVerificationSetting(TwoStepVerificationSettingDAL entityDAL)
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

	internal static TwoStepVerificationSetting Get(long id)
	{
		return EntityHelper.GetEntity<long, TwoStepVerificationSettingDAL, TwoStepVerificationSetting>(EntityCacheInfo, id, () => TwoStepVerificationSettingDAL.Get(id));
	}

	private static ICollection<TwoStepVerificationSetting> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, TwoStepVerificationSettingDAL, TwoStepVerificationSetting>(ids, EntityCacheInfo, TwoStepVerificationSettingDAL.MultiGet);
	}

	public static TwoStepVerificationSetting GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<long, TwoStepVerificationSettingDAL, TwoStepVerificationSetting>(EntityCacheInfo, GetLookupCacheKeysByUserID(userId), () => TwoStepVerificationSettingDAL.GetTwoStepVerificationSettingByUserID(userId));
	}

	public static TwoStepVerificationSetting GetOrCreate(long userId)
	{
		return EntityHelper.GetOrCreateEntity<long, TwoStepVerificationSetting>(EntityCacheInfo, GetLookupCacheKeysByUserID(userId), () => DoGetOrCreate(userId));
	}

	private static TwoStepVerificationSetting DoGetOrCreate(long userId)
	{
		return EntityHelper.DoGetOrCreate<long, TwoStepVerificationSettingDAL, TwoStepVerificationSetting>(() => TwoStepVerificationSettingDAL.GetOrCreateTwoStepVerificationSetting(userId));
	}

	public void Construct(TwoStepVerificationSettingDAL dal)
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
