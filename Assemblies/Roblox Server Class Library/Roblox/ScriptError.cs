using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

public class ScriptError : IEquatable<ScriptError>, IRobloxEntity<int, ScriptErrorDAL>, ICacheableObject<int>, ICacheableObject
{
	private ScriptErrorDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "ScriptError", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string ErrorString
	{
		get
		{
			return _EntityDAL.ErrorString;
		}
		set
		{
			_EntityDAL.ErrorString = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public ScriptError()
	{
		_EntityDAL = new ScriptErrorDAL();
	}

	private static ScriptError DoGet(string errorString)
	{
		return EntityHelper.DoGetByLookup<int, ScriptErrorDAL, ScriptError>(() => ScriptErrorDAL.Get(errorString), $"ErrorString:{errorString}");
	}

	private static ScriptError DoGet(int id)
	{
		return EntityHelper.DoGet<int, ScriptErrorDAL, ScriptError>(() => ScriptErrorDAL.Get(id), id);
	}

	public static ScriptError Get(string errorString)
	{
		return EntityHelper.GetEntityByLookupOld<int, ScriptError>(EntityCacheInfo, $"ErrorString:{errorString}", () => DoGet(errorString));
	}

	public static ScriptError Get(int id)
	{
		return EntityHelper.GetEntityByLookupOld<int, ScriptError>(EntityCacheInfo, id.ToString(), () => DoGet(id));
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		});
	}

	public bool Equals(ScriptError other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(ScriptErrorDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"ErrorString:{ErrorString}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
