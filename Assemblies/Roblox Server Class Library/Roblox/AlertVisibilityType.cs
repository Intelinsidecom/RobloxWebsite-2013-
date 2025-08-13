using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class AlertVisibilityType : IRobloxEntity<int, AlertVisibilityTypeDAL>, ICacheableObject<int>, ICacheableObject
{
	private AlertVisibilityTypeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.AlertVisibilityType", isNullCacheable: true);

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

	public DateTime Created
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

	public DateTime Updated
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

	public static AlertVisibilityType All => Get("All");

	public static AlertVisibilityType AuthenticatedUsers => Get("AuthenticatedUsers");

	public static AlertVisibilityType NonAuthenticatedUsers => Get("NonAuthenticatedUsers");

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AlertVisibilityType()
	{
		_EntityDAL = new AlertVisibilityTypeDAL();
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

	public static AlertVisibilityType CreateNew(string value)
	{
		AlertVisibilityType alertVisibilityType = new AlertVisibilityType();
		alertVisibilityType.Value = value;
		alertVisibilityType.Save();
		return alertVisibilityType;
	}

	public static AlertVisibilityType Get(int id)
	{
		return EntityHelper.GetEntity<int, AlertVisibilityTypeDAL, AlertVisibilityType>(EntityCacheInfo, id, () => AlertVisibilityTypeDAL.Get(id));
	}

	public static AlertVisibilityType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<int, AlertVisibilityTypeDAL, AlertVisibilityType>(EntityCacheInfo, $"Value:{value}", () => AlertVisibilityTypeDAL.Get(value));
	}

	public void Construct(AlertVisibilityTypeDAL dal)
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
