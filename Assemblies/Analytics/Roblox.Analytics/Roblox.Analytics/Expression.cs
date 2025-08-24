using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Analytics;

public class Expression : IRobloxEntity<long, ExpressionDAL>, ICacheableObject<long>, ICacheableObject
{
	private ExpressionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Analytics.Expression", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal string Hash => _EntityDAL.Hash;

	internal string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			value = value.TrimEnd();
			_EntityDAL.Value = value;
			_EntityDAL.Hash = HashFunctions.ComputeHashString(value.GetBytes());
		}
	}

	internal DateTime Created => _EntityDAL.Created;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Expression()
	{
		_EntityDAL = new ExpressionDAL();
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

	private static Expression DoGetOrCreate(string hash, string value)
	{
		return EntityHelper.DoGetOrCreate<long, ExpressionDAL, Expression>(() => ExpressionDAL.GetOrCreate(hash, value));
	}

	internal static Expression Get(long id)
	{
		return EntityHelper.GetEntity<long, ExpressionDAL, Expression>(EntityCacheInfo, id, () => ExpressionDAL.Get(id));
	}

	internal static Expression Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	internal static Expression GetOrCreate(string value)
	{
		if (value == null)
		{
			value = "";
		}
		else
		{
			value = value.TrimEnd();
		}
		string hash = HashFunctions.ComputeHashString(value.GetBytes());
		return EntityHelper.GetOrCreateEntity<long, Expression>(EntityCacheInfo, hash, () => DoGetOrCreate(hash, value));
	}

	public void Construct(ExpressionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return Hash;
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
