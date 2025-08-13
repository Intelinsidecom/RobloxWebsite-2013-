using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class ImbursementBlacklistUser : IRobloxEntity<int, ImbursementBlacklistUserDAL>, ICacheableObject<int>, ICacheableObject
{
	private ImbursementBlacklistUserDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(ImbursementBlacklistUser).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long UserID
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

	public ImbursementBlacklistUser()
	{
		_EntityDAL = new ImbursementBlacklistUserDAL();
	}

	public void Delete()
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

	internal static ImbursementBlacklistUser Get(int id)
	{
		return EntityHelper.GetEntity<int, ImbursementBlacklistUserDAL, ImbursementBlacklistUser>(EntityCacheInfo, id, () => ImbursementBlacklistUserDAL.Get(id));
	}

	internal static ICollection<ImbursementBlacklistUser> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, ImbursementBlacklistUserDAL, ImbursementBlacklistUser>(ids, EntityCacheInfo, ImbursementBlacklistUserDAL.MultiGet);
	}

	public static ImbursementBlacklistUser GetByUserID(long userID)
	{
		return EntityHelper.GetEntityByLookup<int, ImbursementBlacklistUserDAL, ImbursementBlacklistUser>(EntityCacheInfo, $"UserID:{userID}", () => ImbursementBlacklistUserDAL.GetImbursementBlacklistUserByUserID(userID));
	}

	public static ImbursementBlacklistUser CreateNew(long userID)
	{
		ImbursementBlacklistUser imbursementBlacklistUser = new ImbursementBlacklistUser();
		imbursementBlacklistUser.UserID = userID;
		imbursementBlacklistUser.Save();
		return imbursementBlacklistUser;
	}

	public void DeleteFromBlacklist()
	{
		Delete();
	}

	public static bool IsUserInBlacklist(long userID)
	{
		return GetByUserID(userID) != null;
	}

	public void Construct(ImbursementBlacklistUserDAL dal)
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
