using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

public class AccountFeatureSet : IEquatable<AccountFeatureSet>, IRobloxEntity<long, AccountFeatureSetDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountFeatureSetDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountFeatureSet", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public long AccountID => _EntityDAL.AccountID;

	public bool CanCreateContent
	{
		get
		{
			return _EntityDAL.CanCreateContent;
		}
		set
		{
			_EntityDAL.CanCreateContent = value;
		}
	}

	public bool CanSellContent
	{
		get
		{
			return _EntityDAL.CanSellContent;
		}
		set
		{
			_EntityDAL.CanSellContent = value;
		}
	}

	public byte ShowcaseAllotment
	{
		get
		{
			return _EntityDAL.ShowcaseAllotment;
		}
		set
		{
			_EntityDAL.ShowcaseAllotment = value;
		}
	}

	public bool SuppressAds
	{
		get
		{
			return _EntityDAL.SuppressAds;
		}
		set
		{
			_EntityDAL.SuppressAds = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountFeatureSet()
	{
		_EntityDAL = new AccountFeatureSetDAL();
	}

	public AccountFeatureSet(AccountFeatureSetDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal static AccountFeatureSet Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountFeatureSetDAL, AccountFeatureSet>(EntityCacheInfo, id, () => AccountFeatureSetDAL.Get(id));
	}

	public static AccountFeatureSet GetByAccountId(long accountId)
	{
		return EntityHelper.GetEntity<long, AccountFeatureSetDAL, AccountFeatureSet>(EntityCacheInfo, accountId, () => AccountFeatureSetDAL.GetByAccountId(accountId));
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

	private static AccountFeatureSet DoGetOrCreate(long accountId)
	{
		return EntityHelper.DoGetOrCreate<long, AccountFeatureSetDAL, AccountFeatureSet>(() => AccountFeatureSetDAL.GetOrCreate(accountId));
	}

	public static AccountFeatureSet GetOrCreate(long accountId)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, AccountFeatureSet>(EntityCacheInfo, $"AccountID:{accountId}", () => DoGetOrCreate(accountId), Get);
	}

	public bool Equals(AccountFeatureSet other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(AccountFeatureSetDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"AccountID:{AccountID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
