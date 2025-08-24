using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Assets.Entities;

internal class AssetProtectionOption : IRobloxEntity<long, AssetProtectionOptionDAL>, ICacheableObject<long>, ICacheableObject
{
	private AssetProtectionOptionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AssetProtectionOption).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AssetId
	{
		get
		{
			return _EntityDAL.AssetId;
		}
		set
		{
			_EntityDAL.AssetId = value;
		}
	}

	internal bool IsCopyAllowed
	{
		get
		{
			return _EntityDAL.IsCopyAllowed;
		}
		set
		{
			_EntityDAL.IsCopyAllowed = value;
		}
	}

	internal bool IsUpdateAllowed
	{
		get
		{
			return _EntityDAL.IsUpdateAllowed;
		}
		set
		{
			_EntityDAL.IsUpdateAllowed = value;
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

	public AssetProtectionOption()
	{
		_EntityDAL = new AssetProtectionOptionDAL();
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

	private static AssetProtectionOption CreateNew(long assetId, bool isCopyAllowed, bool isUpdateAllowed)
	{
		AssetProtectionOption assetProtectionOption = new AssetProtectionOption();
		assetProtectionOption.AssetId = assetId;
		assetProtectionOption.IsCopyAllowed = isCopyAllowed;
		assetProtectionOption.IsUpdateAllowed = isUpdateAllowed;
		assetProtectionOption.Save();
		return assetProtectionOption;
	}

	private static AssetProtectionOption DoGetOrCreate(long assetId)
	{
		return EntityHelper.DoGetOrCreate<long, AssetProtectionOptionDAL, AssetProtectionOption>(() => AssetProtectionOptionDAL.GetOrCreate(assetId));
	}

	internal static AssetProtectionOption Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetProtectionOptionDAL, AssetProtectionOption>(EntityCacheInfo, id, () => AssetProtectionOptionDAL.Get(id));
	}

	internal static AssetProtectionOption GetByAssetId(long assetId)
	{
		return EntityHelper.GetEntityByLookup<long, AssetProtectionOptionDAL, AssetProtectionOption>(EntityCacheInfo, "AssetId:" + assetId, () => AssetProtectionOptionDAL.GetByAssetId(assetId));
	}

	internal static AssetProtectionOption GetOrCreate(long assetId)
	{
		return EntityHelper.GetOrCreateEntity<long, AssetProtectionOption>(EntityCacheInfo, "AssetId:" + assetId, () => DoGetOrCreate(assetId));
	}

	public void Construct(AssetProtectionOptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return "AssetId:" + AssetId;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
