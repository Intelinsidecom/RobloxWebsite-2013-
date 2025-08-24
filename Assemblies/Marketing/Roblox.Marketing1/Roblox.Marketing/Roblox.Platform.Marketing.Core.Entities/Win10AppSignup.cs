using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class Win10AppSignup : IRobloxEntity<long, Win10AppSignupDAL>, ICacheableObject<long>, ICacheableObject
{
	private Win10AppSignupDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Win10AppSignup).ToString(), isNullCacheable: true);

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

	public Win10AppSignup()
	{
		_EntityDAL = new Win10AppSignupDAL();
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

	internal static Win10AppSignup Get(long id)
	{
		return EntityHelper.GetEntity<long, Win10AppSignupDAL, Win10AppSignup>(EntityCacheInfo, id, () => Win10AppSignupDAL.Get(id));
	}

	private static ICollection<Win10AppSignup> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, Win10AppSignupDAL, Win10AppSignup>(ids, EntityCacheInfo, Win10AppSignupDAL.MultiGet);
	}

	public void Construct(Win10AppSignupDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByUserID(long userID)
	{
		return $"UserID:{userID}";
	}
}
