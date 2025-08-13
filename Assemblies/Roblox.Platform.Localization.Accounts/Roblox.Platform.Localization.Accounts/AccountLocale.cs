using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountLocale : IRobloxEntity<long, AccountLocaleDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountLocaleDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountLocale).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	internal int ObservedLocaleID
	{
		get
		{
			return _EntityDAL.ObservedLocaleID;
		}
		set
		{
			_EntityDAL.ObservedLocaleID = value;
		}
	}

	internal int? SupportedLocaleID
	{
		get
		{
			return _EntityDAL.SupportedLocaleID;
		}
		set
		{
			_EntityDAL.SupportedLocaleID = value;
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

	public AccountLocale()
	{
		_EntityDAL = new AccountLocaleDAL();
	}

	public AccountLocale(AccountLocaleDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntityWithRemoteCache(this, _EntityDAL.Delete);
	}

	internal void Save()
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

	internal static AccountLocale Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountLocaleDAL, AccountLocale>(EntityCacheInfo, id, () => AccountLocaleDAL.Get(id));
	}

	private static ICollection<AccountLocale> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountLocaleDAL, AccountLocale>(ids, EntityCacheInfo, AccountLocaleDAL.MultiGet);
	}

	public static AccountLocale GetByAccountID(long accountId)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, AccountLocaleDAL, AccountLocale>(EntityCacheInfo, GetLookupCacheKeysByAccountID(accountId), () => AccountLocaleDAL.GetAccountLocaleByAccountID(accountId), Get);
	}

	public static AccountLocale Create(long accountId, int observedLocaleId, int? supportedLocaleId = null)
	{
		AccountLocale accountLocale = new AccountLocale();
		accountLocale.AccountID = accountId;
		accountLocale.ObservedLocaleID = observedLocaleId;
		accountLocale.SupportedLocaleID = supportedLocaleId;
		accountLocale.Save();
		return accountLocale;
	}

	public void Construct(AccountLocaleDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByAccountID(AccountID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByAccountID(long accountId)
	{
		return $"AccountID:{accountId}";
	}
}
