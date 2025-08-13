using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
public class AccountSecurityTicket : IRobloxEntity<int, AccountSecurityTicketDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private AccountSecurityTicketDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountSecurityTicket", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public Guid GUID
	{
		get
		{
			return _EntityDAL.GUID;
		}
		set
		{
			_EntityDAL.GUID = value;
		}
	}

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

	public Account Account
	{
		get
		{
			return GetAccount();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AccountID = value.ID;
			}
			else
			{
				_EntityDAL.AccountID = 0L;
			}
		}
	}

	public int? AcountEmailAddressID
	{
		get
		{
			return _EntityDAL.AccountEmailAddressID;
		}
		set
		{
			_EntityDAL.AccountEmailAddressID = value;
		}
	}

	public AccountEmailAddress AccountEmailAddress
	{
		get
		{
			return GetAccountEmailAddress();
		}
		set
		{
			if (value != null)
			{
				_EntityDAL.AccountEmailAddressID = value.ID;
			}
			else
			{
				_EntityDAL.AccountEmailAddressID = null;
			}
		}
	}

	public int? AccountPasswordHashID
	{
		get
		{
			return _EntityDAL.AccountPasswordHashID;
		}
		set
		{
			_EntityDAL.AccountPasswordHashID = value;
		}
	}

	public bool IsValid
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountSecurityTicket()
	{
		_EntityDAL = new AccountSecurityTicketDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public Account GetAccount()
	{
		return Account.MustGet(AccountID);
	}

	public AccountEmailAddress GetAccountEmailAddress()
	{
		if (!AcountEmailAddressID.HasValue)
		{
			return null;
		}
		return AccountEmailAddress.MustGet(AcountEmailAddressID.Value);
	}

	public void Invalidate()
	{
		IsValid = false;
		Save();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.GUID = Guid.NewGuid();
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static AccountSecurityTicket CreateNew(Account account, AccountEmailAddress accountEmailAddress, AccountPasswordHash accountPasswordHash)
	{
		AccountSecurityTicket entity = new AccountSecurityTicket();
		entity.Account = account;
		entity.AccountEmailAddress = accountEmailAddress;
		if (accountPasswordHash != null)
		{
			entity.AccountPasswordHashID = Convert.ToInt32(accountPasswordHash.ID);
		}
		else
		{
			entity.AccountPasswordHashID = null;
		}
		entity.IsValid = true;
		entity.Save();
		return entity;
	}

	public static AccountSecurityTicket Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountSecurityTicketDAL, AccountSecurityTicket>(EntityCacheInfo, id, () => AccountSecurityTicketDAL.Get(id));
	}

	public static AccountSecurityTicket Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AccountSecurityTicket Get(string guid)
	{
		if (guid.Trim().Length == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, AccountSecurityTicketDAL, AccountSecurityTicket>(EntityCacheInfo, $"GUID:{guid}", () => AccountSecurityTicketDAL.Get(guid));
	}

	public static int GetTotalNumberOfValidAccountSecurityTickets(long accountId)
	{
		string countId = $"GetTotalNumberOfValidAccountSecurityTickets_AccountID:{accountId}";
		string cachedStateQualifier = $"AccountID:{accountId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), countId, () => AccountSecurityTicketDAL.GetTotalNumberOfValidAccountSecurityTickets(accountId));
	}

	public static ICollection<AccountSecurityTicket> GetValidAccountSecurityTicketsPaged(long accountId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetValidAccountSecurityTicketsPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		string cachedStateQualifier = $"AccountID:{accountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, cachedStateQualifier), collectionId, () => AccountSecurityTicketDAL.GetValidAccountSecurityTicketIDsPaged(accountId, startRowIndex + 1, maximumRows), Get);
	}

	public static void InvalidateAllAccountSecurityTickets(Account account)
	{
		int totalNumberOfValidAccountSecurityTickets = GetTotalNumberOfValidAccountSecurityTickets(account.ID);
		foreach (AccountSecurityTicket item in GetValidAccountSecurityTicketsPaged(account.ID, 0, totalNumberOfValidAccountSecurityTickets))
		{
			item.IsValid = false;
			item.Save();
		}
	}

	public static void InvalidateNewerAccountSecurityTickets(AccountSecurityTicket oldestValidTicket)
	{
		Account account = oldestValidTicket.GetAccount();
		foreach (AccountSecurityTicket accountSecurityTicket in GetValidAccountSecurityTicketsPaged(maximumRows: GetTotalNumberOfValidAccountSecurityTickets(account.ID), accountId: account.ID, startRowIndex: 0))
		{
			if (accountSecurityTicket.ID == oldestValidTicket.ID)
			{
				break;
			}
			accountSecurityTicket.IsValid = false;
			accountSecurityTicket.Save();
		}
	}

	public void Construct(AccountSecurityTicketDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"GUID:{GUID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken("AccountID:" + AccountID);
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
