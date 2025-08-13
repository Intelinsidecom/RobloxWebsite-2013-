using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

public class FeedType : IRobloxEntity<int, FeedTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private FeedTypeDAL _EntityDAL;

	private static readonly LazyWithRetry<FeedType> _StatusLazy = LazyGetter("status");

	private static readonly LazyWithRetry<FeedType> _GroupLazy = LazyGetter("group");

	private static readonly LazyWithRetry<FeedType> _NewPlaceLazy = LazyGetter("newplace");

	private static readonly LazyWithRetry<FeedType> _BoughtItemLazy = LazyGetter("boughtitem");

	private static readonly LazyWithRetry<FeedType> _PlaceLazy = LazyGetter("place");

	private static readonly LazyWithRetry<FeedType> _CharacterLazy = LazyGetter("character");

	private static readonly LazyWithRetry<FeedType> _PlayGameLazy = LazyGetter("playgame");

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "FeedType", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string Type
	{
		get
		{
			return _EntityDAL.FeedType;
		}
		set
		{
			_EntityDAL.FeedType = value;
		}
	}

	public int Lifetime
	{
		get
		{
			return _EntityDAL.Lifetime;
		}
		set
		{
			_EntityDAL.Lifetime = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _EntityDAL.Enabled;
		}
		set
		{
			_EntityDAL.Enabled = value;
		}
	}

	public static FeedType Status => _StatusLazy.Value;

	public static FeedType Group => _GroupLazy.Value;

	public static FeedType NewPlace => _NewPlaceLazy.Value;

	public static FeedType BoughtItem => _BoughtItemLazy.Value;

	public static FeedType Place => _PlaceLazy.Value;

	public static FeedType Character => _CharacterLazy.Value;

	public static FeedType PlayGame => _PlayGameLazy.Value;

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<FeedType> LazyGetter(string value)
	{
		return new LazyWithRetry<FeedType>(() => Get(value));
	}

	public FeedType()
	{
		_EntityDAL = new FeedTypeDAL();
	}

	public static int GetGlobalLifetime()
	{
		return Status.Lifetime;
	}

	private static FeedType DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<int, FeedTypeDAL, FeedType>(() => FeedTypeDAL.Get(value), null);
	}

	public static FeedType Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<int, FeedType>(EntityCacheInfo, $"FeedType:{value}", () => DoGet(value));
	}

	private void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Update();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	public void Construct(FeedTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add($"FeedType:{Type}");
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
