using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

[Serializable]
public class AccountMACAddress : IRobloxEntity<long, AccountMACAddressDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountMACAddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountMACAddress", isNullCacheable: true);

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

	public long MACAddressID
	{
		get
		{
			return _EntityDAL.MACAddressID;
		}
		set
		{
			_EntityDAL.MACAddressID = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountMACAddress()
	{
		_EntityDAL = new AccountMACAddressDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public MACAddress GetMACAddress()
	{
		return MACAddress.MustGet(MACAddressID);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, _EntityDAL.Update);
	}

	public static AccountMACAddress CreateNew(long accountId, long macAddressId)
	{
		AccountMACAddress accountMACAddress = new AccountMACAddress();
		accountMACAddress.AccountID = accountId;
		accountMACAddress.MACAddressID = macAddressId;
		accountMACAddress.Save();
		return accountMACAddress;
	}

	public static AccountMACAddress CreateNew(long accountId, string macAddress)
	{
		MACAddress address = MACAddress.GetOrCreate(macAddress);
		return CreateNew(accountId, address.ID);
	}

	public static AccountMACAddress Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountMACAddressDAL, AccountMACAddress>(EntityCacheInfo, id, () => AccountMACAddressDAL.Get(id));
	}

	public static AccountMACAddress Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AccountMACAddress Get(long accountId, long macAddressId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountMACAddressDAL, AccountMACAddress>(EntityCacheInfo, $"AccountID:{accountId}_MACAddressID:{macAddressId}", () => AccountMACAddressDAL.GetAccountMACAddressByAccountIDAndMACAddressID(accountId, macAddressId));
	}

	public static ICollection<AccountMACAddress> GetAccountMACAddressesByAccountPaged(long accountId, int startRowIndex, long maximumRows)
	{
		string collectionId = $"GetAccountMACAddressesByAccountPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"AccountID:{accountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => AccountMACAddressDAL.GetAccountMACAddressIDsByAccountPaged(accountId, startRowIndex + 1, maximumRows), Get);
	}

	public static ICollection<AccountMACAddress> GetAccountMACAddressesByAddressPaged(long macAddressId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAccountMACAddressesByAddressPaged_MACAddressID:{macAddressId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"MACAddressID:{macAddressId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => AccountMACAddressDAL.GetAccountMACAddressIDsByAddressPaged(macAddressId, startRowIndex + 1, maximumRows), Get);
	}

	public static long GetTotalNumberOfAccountMACAddressesByAccount(long accountId)
	{
		string countId = $"GetTotalNumberOfAccountMACAddressesByAccount_AccountID:{accountId}";
		string cachedStateQualifier = $"AccountID:{accountId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AccountMACAddressDAL.GetTotalNumberOfAccountMACAddressesByAccount(accountId));
	}

	public static long GetTotalNumberOfAccountMACAddressesByAddress(long macAddressId)
	{
		string countId = $"GetTotalNumberOfAccountMACAddressesByAddress_MACAddressID:{macAddressId}";
		string cachedStateQualifier = $"MACAddressID:{macAddressId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AccountMACAddressDAL.GetTotalNumberOfAccountMACAddressesByAddress(macAddressId));
	}

	public void Construct(AccountMACAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AccountID:{AccountID}_MACAddressID:{MACAddressID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("MACAddressID:" + MACAddressID);
		yield return new StateToken("AccountID:" + AccountID);
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
