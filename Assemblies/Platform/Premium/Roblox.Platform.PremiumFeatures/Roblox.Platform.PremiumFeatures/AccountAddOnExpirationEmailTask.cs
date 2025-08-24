using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AccountAddOnExpirationEmailTask : IRobloxEntity<long, AccountAddOnExpirationEmailTaskDAL>, ICacheableObject<long>, ICacheableObject
{
	private AccountAddOnExpirationEmailTaskDAL _entityDal;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.PremiumFeatures.AccountAddOnExpirationEmailTask", isNullCacheable: true);

	public long ID => _entityDal.ID;

	public int AccountAddOnID
	{
		get
		{
			return _entityDal.AccountAddOnID;
		}
		set
		{
			_entityDal.AccountAddOnID = value;
		}
	}

	public DateTime? EmailSent
	{
		get
		{
			return _entityDal.EmailSent;
		}
		set
		{
			_entityDal.EmailSent = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _entityDal.Created;
		}
		set
		{
			_entityDal.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _entityDal.Updated;
		}
		set
		{
			_entityDal.Updated = value;
		}
	}

	public DateTime LastExpiration
	{
		get
		{
			return _entityDal.LastExpiration;
		}
		set
		{
			_entityDal.LastExpiration = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountAddOnExpirationEmailTask()
	{
		_entityDal = new AccountAddOnExpirationEmailTaskDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_entityDal.Created = DateTime.Now;
			_entityDal.Updated = Created;
			_entityDal.Insert();
		}, delegate
		{
			_entityDal.Updated = DateTime.Now;
			_entityDal.Update();
		});
	}

	public static AccountAddOnExpirationEmailTask CreateNew(int accountaddonid, DateTime? emailsent, DateTime lastExpiration)
	{
		AccountAddOnExpirationEmailTask accountAddOnExpirationEmailTask = new AccountAddOnExpirationEmailTask();
		accountAddOnExpirationEmailTask.AccountAddOnID = accountaddonid;
		accountAddOnExpirationEmailTask.EmailSent = emailsent;
		accountAddOnExpirationEmailTask.LastExpiration = lastExpiration;
		accountAddOnExpirationEmailTask.Save();
		return accountAddOnExpirationEmailTask;
	}

	internal static AccountAddOnExpirationEmailTask Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountAddOnExpirationEmailTaskDAL, AccountAddOnExpirationEmailTask>(EntityCacheInfo, id, () => AccountAddOnExpirationEmailTaskDAL.Get(id));
	}

	public static AccountAddOnExpirationEmailTask GetAccountAddOnExpirationEmailTaskByAccountAddOnID(int accountAddOnId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountAddOnExpirationEmailTaskDAL, AccountAddOnExpirationEmailTask>(EntityCacheInfo, $"AccountAddOnId:{accountAddOnId}", () => AccountAddOnExpirationEmailTaskDAL.GetAccountAddOnExpirationEmailTaskByAccountAddOnID(accountAddOnId));
	}

	public void Construct(AccountAddOnExpirationEmailTaskDAL dal)
	{
		_entityDal = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"AccountAddOnId:{AccountAddOnID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
