using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

public class AccountIPAddressV2 : IRobloxEntity<long, AccountIPAddressV2DAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountIPAddressV2DAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountIPAddressV2", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AccountID
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

	public long IPAddressID
	{
		get
		{
			return _EntityDAL.IPAddressID;
		}
		set
		{
			_EntityDAL.IPAddressID = value;
		}
	}

	public DateTime? LastSeen
	{
		get
		{
			return _EntityDAL.LastSeen;
		}
		set
		{
			_EntityDAL.LastSeen = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountIPAddressV2()
		: this(new AccountIPAddressV2DAL())
	{
	}

	public AccountIPAddressV2(AccountIPAddressV2DAL dal)
	{
		_EntityDAL = dal;
	}

	public Account GetAccount()
	{
		return Account.MustGet(AccountID);
	}

	public IPAddress GetIPAddress()
	{
		return IPAddress.MustGet(Convert.ToInt32(IPAddressID));
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, _EntityDAL.Update);
	}

	public static AccountIPAddressV2 Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountIPAddressV2DAL, AccountIPAddressV2>(EntityCacheInfo, id, () => AccountIPAddressV2DAL.Get(id));
	}

	public static AccountIPAddressV2 Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ICollection<AccountIPAddressV2> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountIPAddressV2DAL, AccountIPAddressV2>(ids, EntityCacheInfo, AccountIPAddressV2DAL.MultiGet);
	}

	public static ICollection<AccountIPAddressV2> GetAccountIPAddressesV2ByAccountPaged(long accountId, int startRowIndex, long maximumRows)
	{
		string collectionId = $"GetAccountIPAddressesV2ByAccountPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = GetCacheQualifierByAccountID(accountId);
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => AccountIPAddressV2DAL.GetAccountIPAddressV2IDsByAccountPaged(accountId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AccountIPAddressV2> GetAccountIPAddressesV2ByAddressPaged(long ipAddressId, int startRowIndex, long maximumRows)
	{
		string collectionId = $"GetAccountIPAddressesV2ByAddressPaged_IPAddressID:{ipAddressId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"IPAddressID:{ipAddressId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => AccountIPAddressV2DAL.GetAccountIPAddressV2IDsByAddressPaged(ipAddressId, startRowIndex + 1, maximumRows), Get);
	}

	[Obsolete("DO NOT USE: this exists only as a workaround for an aspx ObjectDataSource")]
	public static int GetTotalNumberOfAccountIPAddressesV2ByAccountAsInt(long accountId)
	{
		return (int)GetTotalNumberOfAccountIPAddressesV2ByAccount(accountId);
	}

	public static long GetTotalNumberOfAccountIPAddressesV2ByAccount(long accountId)
	{
		string countId = $"GetTotalNumberOfAccountIPAddressesV2ByAccount_AccountID:{accountId}";
		string cachedStateQualifier = GetCacheQualifierByAccountID(accountId);
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AccountIPAddressV2DAL.GetTotalNumberOfAccountIPAddressesV2ByAccount(accountId));
	}

	[Obsolete("DO NOT USE: this exists only as a workaround for an aspx ObjectDataSource")]
	public static int GetTotalNumberOfAccountIPAddressesV2ByAddressAsInt(long ipAddressId)
	{
		return Convert.ToInt32(GetTotalNumberOfAccountIPAddressesV2ByAddress(ipAddressId));
	}

	public static long GetTotalNumberOfAccountIPAddressesV2ByAddress(long ipAddressId)
	{
		string countId = $"GetTotalNumberOfAccountIPAddressesV2ByAddress_IPAddressID:{ipAddressId}";
		string cachedStateQualifier = $"IPAddressID:{ipAddressId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AccountIPAddressV2DAL.GetTotalNumberOfAccountIPAddressesV2ByAddress(ipAddressId));
	}

	public static AccountIPAddressV2 GetOrCreate(long accountId, long ipAddressId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, AccountIPAddressV2>(EntityCacheInfo, $"AccountID:{accountId}_IPAddressID:{ipAddressId}", () => DoGetOrCreate(accountId, ipAddressId), Get);
	}

	private static AccountIPAddressV2 DoGetOrCreate(long accountId, long ipAddressId)
	{
		return EntityHelper.DoGetOrCreate<long, AccountIPAddressV2DAL, AccountIPAddressV2>(() => AccountIPAddressV2DAL.GetOrCreate(accountId, ipAddressId));
	}

	public static ICollection<AccountIPAddressV2> GetAccountIPAddressesV2ByAccountID(long accountId, int count, DateTime? exclusiveStartLastSeen, long? exclusiveStartID)
	{
		string collectionId = $"GetAccountIPAddressesV2ByAccountID_AccountID:{accountId}_Count:{count}_ExclusiveStartLastSeen:{exclusiveStartLastSeen}_ExclusiveStartID:{exclusiveStartID}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetCacheQualifierByAccountID(accountId)), collectionId, () => AccountIPAddressV2DAL.GetAccountIPAddressV2IDsByAccountID(accountId, count, exclusiveStartLastSeen, exclusiveStartID), MultiGet);
	}

	public void Construct(AccountIPAddressV2DAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AccountID:{AccountID}_IPAddressID:{IPAddressID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("IPAddressID:" + IPAddressID);
		yield return new StateToken(GetCacheQualifierByAccountID(AccountID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByAccountID(long accountId)
	{
		return $"AccountID:{accountId}";
	}
}
