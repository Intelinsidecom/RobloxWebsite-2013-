using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Economy;

public class CreatorType : IRobloxEntity<int, CreatorTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private CreatorTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

	public int ID => _EntityDAL.ID;

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

	static CreatorType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), typeof(CreatorType).ToString(), isNullCacheable: true);
	}

	public CreatorType()
	{
		_EntityDAL = new CreatorTypeDAL();
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

	private static CreatorType CreateNew(string value)
	{
		CreatorType creatorType = new CreatorType();
		creatorType.Value = value;
		creatorType.Save();
		return creatorType;
	}

	public static CreatorType Get(int id)
	{
		return EntityHelper.GetEntity<int, CreatorTypeDAL, CreatorType>(EntityCacheInfo, id, () => CreatorTypeDAL.Get(id));
	}

	public static CreatorType GetByValue(string value)
	{
		return EntityHelper.GetEntityByLookup<int, CreatorTypeDAL, CreatorType>(EntityCacheInfo, $"Value:{value}", () => CreatorTypeDAL.GetByValue(value));
	}

	public static CreatorType GetOrCreate(string value)
	{
		return EntityHelper.GetOrCreateEntity<int, CreatorType>(EntityCacheInfo, $"Value:{value}", () => DoGetOrCreate(value));
	}

	private static CreatorType DoGetOrCreate(string value)
	{
		return EntityHelper.DoGetOrCreate<int, CreatorTypeDAL, CreatorType>(() => CreatorTypeDAL.GetOrCreate(value));
	}

	public void Construct(CreatorTypeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Value:{Value}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
