using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox;

[Obsolete("Should use Roblox.Platform.Assets. This entity is going to be deleted.")]
public class AssetOption : IRobloxEntity<long, AssetOptionDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	public enum LookupFilter
	{
		AssetID
	}

	public enum MembershipType
	{
		None,
		BuildersClub,
		TurboBuildersClub,
		OutrageousBuildersClub
	}

	private AssetOptionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AssetOption", isNullCacheable: true);

	public long ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public long AssetID
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

	public bool EnableComments
	{
		get
		{
			return _EntityDAL.EnableComments;
		}
		set
		{
			_EntityDAL.EnableComments = value;
		}
	}

	public bool EnableRatings
	{
		get
		{
			return _EntityDAL.EnableRatings;
		}
		set
		{
			_EntityDAL.EnableRatings = value;
		}
	}

	public bool IsCopyLocked
	{
		get
		{
			return _EntityDAL.IsCopyLocked;
		}
		set
		{
			_EntityDAL.IsCopyLocked = value;
		}
	}

	public bool IsFriendsOnly
	{
		get
		{
			return _EntityDAL.IsFriendsOnly;
		}
		set
		{
			_EntityDAL.IsFriendsOnly = value;
		}
	}

	public bool IsAllowingGear => _EntityDAL.AllowedGearCategories != 0;

	/// <summary>
	/// A bitmask representation of all Gear Categories associated with this asset
	/// </summary>
	public ulong AllowedGearCategories
	{
		get
		{
			return (ulong)_EntityDAL.AllowedGearCategories;
		}
		set
		{
			_EntityDAL.AllowedGearCategories = (long)value;
		}
	}

	public long? DefaultExpirationInTicks
	{
		get
		{
			return _EntityDAL.DefaultExpirationInTicks;
		}
		set
		{
			_EntityDAL.DefaultExpirationInTicks = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool EnforceGenre
	{
		get
		{
			return _EntityDAL.EnforceGenre;
		}
		set
		{
			_EntityDAL.EnforceGenre = value;
		}
	}

	public bool IsExpireable => DefaultExpirationInTicks.HasValue;

	public MembershipType MinMembershipType
	{
		get
		{
			return (MembershipType)_EntityDAL.MinMembershipType;
		}
		set
		{
			_EntityDAL.MinMembershipType = (byte)value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AssetOption()
	{
		_EntityDAL = new AssetOptionDAL();
	}

	public AssetOption(AssetOptionDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static AssetOption Get(long id)
	{
		return EntityHelper.GetEntity<long, AssetOptionDAL, AssetOption>(EntityCacheInfo, id, () => AssetOptionDAL.Get(id));
	}

	[Obsolete]
	public static AssetOption GetOrCreate(LookupFilter filter, long assetId)
	{
		return GetOrCreate(assetId);
	}

	public static AssetOption GetOrCreate(long assetId)
	{
		if (Settings.Default.IsAssetOptionRemoteCached)
		{
			return EntityHelper.GetOrCreateEntityWithRemoteCache<long, AssetOption>(EntityCacheInfo, $"AssetID:{assetId}", () => DoGetOrCreate(assetId), Get);
		}
		return EntityHelper.GetOrCreateEntity<long, AssetOption>(EntityCacheInfo, $"AssetID:{assetId}", () => DoGetOrCreate(assetId));
	}

	private static AssetOption DoGetOrCreate(long assetId)
	{
		return EntityHelper.DoGetOrCreate<long, AssetOptionDAL, AssetOption>(() => AssetOptionDAL.GetOrCreate(assetId));
	}

	public void Construct(AssetOptionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AssetID:{AssetID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
