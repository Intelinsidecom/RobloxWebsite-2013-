using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTicketsV2 : IRobloxEntity<long, AccountSecurityTicketsV2DAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountSecurityTicketsV2DAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountSecurityTicketsV2).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
		}
	}

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

	public AccountSecurityTicketsV2()
	{
		_EntityDAL = new AccountSecurityTicketsV2DAL();
	}

	public AccountSecurityTicketsV2(AccountSecurityTicketsV2DAL entityDAL)
	{
		_EntityDAL = new AccountSecurityTicketsV2DAL();
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
			_EntityDAL.IsValid = true;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static AccountSecurityTicketsV2 Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountSecurityTicketsV2DAL, AccountSecurityTicketsV2>(EntityCacheInfo, id, () => AccountSecurityTicketsV2DAL.Get(id));
	}

	private static ICollection<AccountSecurityTicketsV2> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountSecurityTicketsV2DAL, AccountSecurityTicketsV2>(ids, EntityCacheInfo, AccountSecurityTicketsV2DAL.MultiGet);
	}

	public static AccountSecurityTicketsV2 GetByValue(Guid value)
	{
		return EntityHelper.GetEntityByLookup<long, AccountSecurityTicketsV2DAL, AccountSecurityTicketsV2>(EntityCacheInfo, GetLookupCacheKeysByGUID(value), () => AccountSecurityTicketsV2DAL.GetAccountSecurityTicketsV2ByValue(value));
	}

	internal static ICollection<AccountSecurityTicketsV2> GetAccountSecurityTicketsV2ByAccountIDAndIsValid(long accountId, bool isValid, long count, long exclusiveStartAccountSecurityTicketsV2Id)
	{
		string collectionId = $"GetAccountSecurityTicketsV2ByAccountIDAndIsValid_AccountID:{accountId}_IsValid:{isValid}_Count:{count}_ExclusiveStartAccountSecurityTicketsV2ID:{exclusiveStartAccountSecurityTicketsV2Id}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountIDIsValid(accountId, isValid)), collectionId, () => AccountSecurityTicketsV2DAL.GetAccountSecurityTicketsV2IDsByAccountIDAndIsValid(accountId, isValid, count, exclusiveStartAccountSecurityTicketsV2Id), MultiGet);
	}

	internal static long GetTotalNumberOfAccountSecurityTicketsV2ByAccountIdAndIsValid(long accountId, bool isValid)
	{
		string countId = $"GetTotalNumberOfAccountSecurityTicketsV2ByAccountIdAndIsValid_AccountID:{accountId}_IsValid:{isValid}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountIDIsValid(accountId, isValid)), countId, () => AccountSecurityTicketsV2DAL.GetTotalNumberOfAccountSecurityTicketsV2ByAccountIDAndIsValid(accountId, isValid));
	}

	public void Construct(AccountSecurityTicketsV2DAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByGUID(Value);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountIDIsValid(AccountID, IsValid));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByGUID(Guid gUId)
	{
		return $"GUID:{gUId}";
	}

	private static string GetLookupCacheKeysByAccountIDIsValid(long accountId, bool isValid)
	{
		return $"AccountID:{accountId}_IsValid:{isValid}";
	}
}
