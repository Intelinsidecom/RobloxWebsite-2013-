using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Moderation;

public class ContextUrl : IRobloxEntity<long, ContextUrlDAL>, ICacheableObject<long>, ICacheableObject
{
	private ContextUrlDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ContextUrl", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public string Value
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ContextUrl()
	{
		_EntityDAL = new ContextUrlDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
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

	private static ContextUrl DoGet(long id)
	{
		return EntityHelper.DoGet<long, ContextUrlDAL, ContextUrl>(() => ContextUrlDAL.Get(id), id);
	}

	private static ContextUrl DoGet(string value)
	{
		return EntityHelper.DoGetByLookup<long, ContextUrlDAL, ContextUrl>(() => ContextUrlDAL.Get(value), value);
	}

	private static ContextUrl DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<long, ContextUrlDAL, ContextUrl>(() => ContextUrlDAL.GetOrCreate(value));
	}

	public static ContextUrl CreateNew(string value)
	{
		ContextUrl contextUrl = new ContextUrl();
		contextUrl.Value = value;
		contextUrl.Save();
		return contextUrl;
	}

	public static ContextUrl Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static ContextUrl Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static ContextUrl Get(string value)
	{
		return EntityHelper.GetEntityByLookupOld<long, ContextUrl>(EntityCacheInfo, value, () => DoGet(value));
	}

	public static ContextUrl GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<long, ContextUrl>(EntityCacheInfo, value, () => DoGetOrCreate(value));
	}

	public void Construct(ContextUrlDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Value;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
