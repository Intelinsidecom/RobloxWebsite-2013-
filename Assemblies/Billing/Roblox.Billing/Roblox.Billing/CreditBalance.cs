using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class CreditBalance : IRobloxEntity<int, CreditBalanceDAL>, ICacheableObject<int>, ICacheableObject
{
	private CreditBalanceDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.CreditBalance", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	public decimal Balance
	{
		get
		{
			return _EntityDAL.Balance;
		}
		set
		{
			_EntityDAL.Balance = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	public CreditBalance()
	{
		_EntityDAL = new CreditBalanceDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public static CreditBalance CreateNew(long accountid, decimal balance)
	{
		CreditBalance creditBalance = new CreditBalance();
		creditBalance.AccountID = accountid;
		creditBalance.Balance = balance;
		creditBalance.Save();
		return creditBalance;
	}

	public static CreditBalance Get(int id)
	{
		return EntityHelper.GetEntity<int, CreditBalanceDAL, CreditBalance>(EntityCacheInfo, id, () => CreditBalanceDAL.Get(id));
	}

	public static CreditBalance GetByAccountID(long accountId)
	{
		return EntityHelper.GetEntityByLookup<int, CreditBalanceDAL, CreditBalance>(EntityCacheInfo, $"AccountID:{accountId}", () => CreditBalanceDAL.GetByAccountID(accountId));
	}

	public static CreditBalance GetOrCreate(long accountid)
	{
		return EntityHelper.GetOrCreateEntity<int, CreditBalance>(EntityCacheInfo, $"AccountID:{accountid}", () => DoGetOrCreate(accountid));
	}

	private static CreditBalance DoGetOrCreate(long accountid)
	{
		return EntityHelper.DoGetOrCreate<int, CreditBalanceDAL, CreditBalance>(() => CreditBalanceDAL.GetOrCreate(accountid));
	}

	public void Credit(decimal amount)
	{
		if (!(amount == 0m))
		{
			_EntityDAL.Credit(amount);
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
	}

	public bool TryDebit(decimal amount)
	{
		bool num = _EntityDAL.TryDebit(amount);
		if (num)
		{
			CacheManager.ProcessEntityChange(this, StateChangeEventType.Modification);
		}
		return num;
	}

	[Obsolete("Use overloaded long")]
	public static bool UserHasCredit(User user)
	{
		if (user != null)
		{
			CreditBalance cb = GetByAccountID(user.AccountID);
			if (cb != null && cb.Balance > 0.0m)
			{
				return true;
			}
		}
		return false;
	}

	[Obsolete("Use overloaded long")]
	public static string GetBalance(User user)
	{
		decimal balance = default(decimal);
		if (user != null)
		{
			CreditBalance cb = GetByAccountID(user.AccountID);
			if (cb != null)
			{
				balance = cb.Balance;
			}
		}
		return $"{balance:c}";
	}

	public static bool UserHasCredit(long accountId)
	{
		if (accountId == 0L)
		{
			return false;
		}
		CreditBalance cb = GetByAccountID(accountId);
		if (cb != null && cb.Balance > 0.0m)
		{
			return true;
		}
		return false;
	}

	public static string GetBalance(long accountId)
	{
		decimal balance = default(decimal);
		if (accountId > 0)
		{
			CreditBalance cb = GetByAccountID(accountId);
			if (cb != null)
			{
				balance = cb.Balance;
			}
		}
		return $"{balance:c}";
	}

	public void Construct(CreditBalanceDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AccountID:{AccountID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
