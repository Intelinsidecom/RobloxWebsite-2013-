using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Moderation;

internal class InGameAdvertisingBan : IRobloxEntity<int, InGameAdvertisingBanDAL>, ICacheableObject<int>, ICacheableObject
{
	private InGameAdvertisingBanDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(InGameAdvertisingBan).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	internal DateTime? Expiration
	{
		get
		{
			return _EntityDAL.Expiration;
		}
		set
		{
			_EntityDAL.Expiration = value;
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

	public InGameAdvertisingBan()
	{
		_EntityDAL = new InGameAdvertisingBanDAL();
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

	public static InGameAdvertisingBan CreateNew(long userId, DateTime? expiryDate)
	{
		InGameAdvertisingBan inGameAdvertisingBan = new InGameAdvertisingBan();
		inGameAdvertisingBan.UserID = userId;
		inGameAdvertisingBan.Expiration = expiryDate;
		inGameAdvertisingBan.Save();
		return inGameAdvertisingBan;
	}

	internal static InGameAdvertisingBan Get(int id)
	{
		return EntityHelper.GetEntity<int, InGameAdvertisingBanDAL, InGameAdvertisingBan>(EntityCacheInfo, id, () => InGameAdvertisingBanDAL.Get(id));
	}

	public static InGameAdvertisingBan GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<int, InGameAdvertisingBanDAL, InGameAdvertisingBan>(EntityCacheInfo, $"UserID:{userId}", () => InGameAdvertisingBanDAL.GetByUserID(userId));
	}

	public void Construct(InGameAdvertisingBanDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
