using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.Entities;

internal class FacebookAccount : IRobloxEntity<int, FacebookAccountDAL>, ICacheableObject<int>, ICacheableObject
{
	private FacebookAccountDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(FacebookAccount).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	internal ulong FacebookID
	{
		get
		{
			return _EntityDAL.FacebookID;
		}
		set
		{
			_EntityDAL.FacebookID = value;
		}
	}

	internal bool IsValid
	{
		get
		{
			return _EntityDAL.IsValid;
		}
		set
		{
			_EntityDAL.IsValid = value;
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

	public FacebookAccount()
	{
		_EntityDAL = new FacebookAccountDAL();
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

	internal static FacebookAccount Get(int id)
	{
		return EntityHelper.GetEntity<int, FacebookAccountDAL, FacebookAccount>(EntityCacheInfo, id, () => FacebookAccountDAL.Get(id));
	}

	internal static ICollection<FacebookAccount> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, FacebookAccountDAL, FacebookAccount>(ids, EntityCacheInfo, FacebookAccountDAL.MultiGet);
	}

	internal static ICollection<FacebookAccount> GetFacebookAccountsByAccountIDAndIsValid(long accountID, bool isValid, int count, int exclusiveStartFacebookAccountId)
	{
		string collectionId = $"GetFacebookAccountsByAccountIDAndIsValid_AccountID:{accountID}_IsValid:{isValid}_Count:{count}_ExclusiveStartFacebookAccountID:{exclusiveStartFacebookAccountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountID(accountID)), collectionId, () => FacebookAccountDAL.GetFacebookAccountIDsByAccountIDAndIsValid(accountID, isValid, count, exclusiveStartFacebookAccountId), MultiGet);
	}

	public static FacebookAccount GetByFacebookIDAndIsValid(ulong facebookID, bool isValid)
	{
		return EntityHelper.GetEntityByLookup<int, FacebookAccountDAL, FacebookAccount>(EntityCacheInfo, GetLookupCacheKeysByFacebookID(facebookID), () => FacebookAccountDAL.GetFacebookAccountByFacebookIDAndIsValid(facebookID, isValid));
	}

	public void Construct(FacebookAccountDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByFacebookID(FacebookID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountID(AccountID));
	}

	private static string GetLookupCacheKeysByAccountID(long accountID)
	{
		return $"AccountID:{accountID}";
	}

	private static string GetLookupCacheKeysByFacebookID(ulong facebookID)
	{
		return $"FacebookID:{facebookID}";
	}
}
