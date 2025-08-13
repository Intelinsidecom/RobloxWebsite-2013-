using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class Filter : IRobloxEntity<int, FilterDAL>, ICacheableObject<int>, ICacheableObject
{
	private FilterDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Filter", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	internal string Name
	{
		get
		{
			return _EntityDAL.Name;
		}
		set
		{
			_EntityDAL.Name = value;
		}
	}

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

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Filter()
	{
		_EntityDAL = new FilterDAL();
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

	private static Filter DoGetOrCreate(string name, string value)
	{
		return EntityHelper.DoGetOrCreate<int, FilterDAL, Filter>(() => FilterDAL.GetOrCreate(name, value));
	}

	internal static Filter Get(int id)
	{
		return EntityHelper.GetEntity<int, FilterDAL, Filter>(EntityCacheInfo, id, () => FilterDAL.Get(id));
	}

	internal static Filter Get(int? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static Filter GetOrCreate(string name, string value)
	{
		return EntityHelper.GetOrCreateEntity<int, Filter>(EntityCacheInfo, $"Name:{name}_Value:{value}", () => DoGetOrCreate(name, value));
	}

	public void Construct(FilterDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Name:{Name}_Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
