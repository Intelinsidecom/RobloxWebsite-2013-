using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Marketing;

public class UserMobileAdIdentifier : IRobloxEntity<int, UserMobileAdIdentifierDAL>, ICacheableObject<int>, ICacheableObject
{
	private UserMobileAdIdentifierDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UserMobileAdIdentifier).ToString(), isNullCacheable: true);

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

	internal int MobileAdIdentifierID
	{
		get
		{
			return _EntityDAL.MobileAdIdentifierID;
		}
		set
		{
			_EntityDAL.MobileAdIdentifierID = value;
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

	public UserMobileAdIdentifier()
	{
		_EntityDAL = new UserMobileAdIdentifierDAL();
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

	internal static UserMobileAdIdentifier Get(int id)
	{
		return EntityHelper.GetEntity<int, UserMobileAdIdentifierDAL, UserMobileAdIdentifier>(EntityCacheInfo, id, () => UserMobileAdIdentifierDAL.Get(id));
	}

	internal static ICollection<UserMobileAdIdentifier> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, UserMobileAdIdentifierDAL, UserMobileAdIdentifier>(ids, EntityCacheInfo, UserMobileAdIdentifierDAL.MultiGet);
	}

	public static UserMobileAdIdentifier GetOrCreate(long userId, int mobileAdIdentifierId)
	{
		return EntityHelper.GetOrCreateEntity<int, UserMobileAdIdentifier>(EntityCacheInfo, $"UserID:{userId}_MobileAdIdentifierID:{mobileAdIdentifierId}", () => DoGetOrCreate(userId, mobileAdIdentifierId));
	}

	private static UserMobileAdIdentifier DoGetOrCreate(long userId, int mobileAdIdentifierId)
	{
		return EntityHelper.DoGetOrCreate<int, UserMobileAdIdentifierDAL, UserMobileAdIdentifier>(() => UserMobileAdIdentifierDAL.GetOrCreateUserMobileAdIdentifier(userId, mobileAdIdentifierId));
	}

	public static UserMobileAdIdentifier GetByUserIDMobileAdIdentifierID(long userId, int mobileAdIdentifierId)
	{
		return EntityHelper.GetEntityByLookup<int, UserMobileAdIdentifierDAL, UserMobileAdIdentifier>(EntityCacheInfo, $"UserID:{userId}_MobileAdIdentifierID:{mobileAdIdentifierId}", () => UserMobileAdIdentifierDAL.GetUserMobileAdIdentifierByUserIDMobileAdIdentifierID(userId, mobileAdIdentifierId));
	}

	public void Construct(UserMobileAdIdentifierDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UserID:{UserID}_MobileAdIdentifierID:{MobileAdIdentifierID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
