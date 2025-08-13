using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountCountry : IRobloxEntity<long, AccountCountryDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountCountryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountCountry).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AccountId
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

	internal int? CountryId
	{
		get
		{
			return _EntityDAL.CountryID;
		}
		set
		{
			_EntityDAL.CountryID = value;
		}
	}

	internal bool IsVerified
	{
		get
		{
			return _EntityDAL.IsVerified;
		}
		set
		{
			_EntityDAL.IsVerified = value;
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

	public AccountCountry()
	{
		_EntityDAL = new AccountCountryDAL();
	}

	public AccountCountry(AccountCountryDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
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

	public static AccountCountry Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountCountryDAL, AccountCountry>(EntityCacheInfo, id, () => AccountCountryDAL.Get(id));
	}

	public static ICollection<AccountCountry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountCountryDAL, AccountCountry>(ids, EntityCacheInfo, AccountCountryDAL.MultiGet);
	}

	public static AccountCountry GetByAccountID(long accountId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, AccountCountryDAL, AccountCountry>(EntityCacheInfo, GetLookupCacheKeyByAccountId(accountId), () => AccountCountryDAL.GetAccountCountryByAccountID(accountId), Get);
	}

	public static AccountCountry GetOrCreate(long accountId, out bool entityWasCreated)
	{
		bool created = false;
		AccountCountry orCreateEntityWithRemoteCache = EntityHelper.GetOrCreateEntityWithRemoteCache<long, AccountCountry>(EntityCacheInfo, GetLookupCacheKeyByAccountId(accountId), () => DoGetOrCreate(accountId, out created), Get);
		entityWasCreated = created;
		return orCreateEntityWithRemoteCache;
	}

	public void Construct(AccountCountryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeyByAccountId(AccountId);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static AccountCountry DoGetOrCreate(long accountId, out bool entityWasCreated)
	{
		bool createdNewEntity = false;
		AccountCountry result = EntityHelper.DoGetOrCreate<long, AccountCountryDAL, AccountCountry>(delegate
		{
			EntityHelper.GetOrCreateDALWrapper<AccountCountryDAL> orCreateAccountCountry = AccountCountryDAL.GetOrCreateAccountCountry(accountId);
			createdNewEntity = orCreateAccountCountry.CreatedNewEntity;
			return orCreateAccountCountry;
		});
		entityWasCreated = createdNewEntity;
		return result;
	}

	private static string GetLookupCacheKeyByAccountId(long accountId)
	{
		return $"AccountID:{accountId}";
	}
}
