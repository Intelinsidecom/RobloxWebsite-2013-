using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Marketing.DAL;

namespace Roblox.Marketing.BLL;

internal class AccountBrowserTracker : IRobloxEntity<long, AccountBrowserTrackerDAL>, ICacheableObject<long>, ICacheableObject
{
	private AccountBrowserTrackerDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountBrowserTracker).ToString(), isNullCacheable: true);

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

	internal long BrowserTrackerID
	{
		get
		{
			return _EntityDAL.BrowserTrackerID;
		}
		set
		{
			_EntityDAL.BrowserTrackerID = value;
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

	public AccountBrowserTracker()
	{
		_EntityDAL = new AccountBrowserTrackerDAL();
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

	internal static AccountBrowserTracker Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountBrowserTrackerDAL, AccountBrowserTracker>(EntityCacheInfo, id, () => AccountBrowserTrackerDAL.Get(id));
	}

	internal static ICollection<AccountBrowserTracker> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountBrowserTrackerDAL, AccountBrowserTracker>(ids, EntityCacheInfo, AccountBrowserTrackerDAL.MultiGet);
	}

	private static AccountBrowserTracker DoGetOrCreate(long accountId, long browserTrackerId)
	{
		return EntityHelper.DoGetOrCreate<long, AccountBrowserTrackerDAL, AccountBrowserTracker>(() => AccountBrowserTrackerDAL.GetOrCreate(accountId, browserTrackerId));
	}

	internal static AccountBrowserTracker GetOrCreate(long accountId, long browserTrackerId)
	{
		return EntityHelper.GetOrCreateEntity<long, AccountBrowserTracker>(EntityCacheInfo, GetLookupCacheKeysByAccountIDBrowserTrackerID(accountId, browserTrackerId), () => DoGetOrCreate(accountId, browserTrackerId));
	}

	internal static AccountBrowserTracker GetByAccountIDAndBrowserTrackerID(long accountId, long browserTrackerId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountBrowserTrackerDAL, AccountBrowserTracker>(EntityCacheInfo, GetLookupCacheKeysByAccountIDBrowserTrackerID(accountId, browserTrackerId), () => AccountBrowserTrackerDAL.GetByAccountIDAndBrowserTrackerID(accountId, browserTrackerId));
	}

	public void Construct(AccountBrowserTrackerDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByAccountIDBrowserTrackerID(AccountID, BrowserTrackerID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	private static string GetLookupCacheKeysByAccountIDBrowserTrackerID(long accountId, long browserTrackerId)
	{
		return $"AccountID:{accountId}_BrowserTrackerID:{browserTrackerId}";
	}
}
