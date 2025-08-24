using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class SellBan : IRobloxEntity<long, SellBanDAL>, ICacheableObject<long>, ICacheableObject
{
	private SellBanDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(SellBan).ToString(), isNullCacheable: true);

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

	public DateTime? Expiration
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

	public SellBan()
	{
		_EntityDAL = new SellBanDAL();
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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
	}

	public static SellBan CreateNew(long userid, DateTime? expiration)
	{
		SellBan sellBan = new SellBan();
		sellBan.UserID = userid;
		sellBan.Expiration = expiration;
		sellBan.Save();
		return sellBan;
	}

	internal static SellBan Get(long id)
	{
		return EntityHelper.GetEntity<long, SellBanDAL, SellBan>(EntityCacheInfo, id, () => SellBanDAL.Get(id));
	}

	public static SellBan GetByUserID(long userId)
	{
		return EntityHelper.GetEntityByLookup<long, SellBanDAL, SellBan>(EntityCacheInfo, $"SellBan_userId:{userId}", () => SellBanDAL.GetByUserID(userId));
	}

	public void Construct(SellBanDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"SellBan_userId:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
