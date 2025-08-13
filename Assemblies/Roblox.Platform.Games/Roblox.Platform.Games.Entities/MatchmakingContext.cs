using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class MatchmakingContext : IRobloxEntity<int, MatchmakingContextDAL>, ICacheableObject<int>, ICacheableObject
{
	private MatchmakingContextDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(MatchmakingContext).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			_EntityDAL.Value = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public MatchmakingContext()
	{
		_EntityDAL = new MatchmakingContextDAL();
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
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static MatchmakingContext Get(int id)
	{
		return EntityHelper.GetEntity<int, MatchmakingContextDAL, MatchmakingContext>(EntityCacheInfo, id, () => MatchmakingContextDAL.Get(id));
	}

	internal static ICollection<MatchmakingContext> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, MatchmakingContextDAL, MatchmakingContext>(ids, EntityCacheInfo, MatchmakingContextDAL.MultiGet);
	}

	internal static MatchmakingContext GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, MatchmakingContext>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	private static MatchmakingContext DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, MatchmakingContextDAL, MatchmakingContext>(() => MatchmakingContextDAL.GetOrCreateMatchmakingContext(value));
	}

	internal static MatchmakingContext GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, MatchmakingContextDAL, MatchmakingContext>(EntityCacheInfo, $"Value:{value}", () => MatchmakingContextDAL.GetMatchmakingContextByValue(value));
	}

	public void Construct(MatchmakingContextDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Value:{Value}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
