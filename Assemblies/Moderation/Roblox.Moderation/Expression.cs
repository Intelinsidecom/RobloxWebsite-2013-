using System;
using System.Collections.Generic;
using System.Text;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class Expression : IRobloxEntity<long, ExpressionDAL>, ICacheableObject<long>, ICacheableObject
{
	private ExpressionDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Expression", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public string Hash => _EntityDAL.Hash;

	public string HashUnicode
	{
		get
		{
			return _EntityDAL.HashUnicode;
		}
		set
		{
			if (value != null && value.Length > 32)
			{
				throw new ArgumentException("Expression Hash is not a base 64 string of 32 characters", "value");
			}
			_EntityDAL.HashUnicode = value;
		}
	}

	public string Value
	{
		get
		{
			return _EntityDAL.Value;
		}
		set
		{
			value = value.TrimEnd();
			_EntityDAL.Value = value;
			_EntityDAL.Hash = OldHashValue(value);
			_EntityDAL.HashUnicode = HashValue(value);
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Expression()
	{
		_EntityDAL = new ExpressionDAL();
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

	private static Expression DoGet(long id)
	{
		return EntityHelper.DoGet<long, ExpressionDAL, Expression>(() => ExpressionDAL.Get(id), id);
	}

	private static Expression DoGet(string hash)
	{
		if (Settings.Default.IsGetByHashUnicodeEnabled)
		{
			return EntityHelper.DoGetByLookup<long, ExpressionDAL, Expression>(() => ExpressionDAL.GetByHashUnicode(hash), hash);
		}
		return EntityHelper.DoGetByLookup<long, ExpressionDAL, Expression>(() => ExpressionDAL.Get(hash), hash);
	}

	private static Expression DoGetOrCreate(string oldHash, string hash, string value)
	{
		if (Settings.Default.IsGetByHashUnicodeEnabled)
		{
			return EntityHelper.DoGetOrCreate<long, ExpressionDAL, Expression>(() => ExpressionDAL.GetOrCreateByHashUnicode(hash, value));
		}
		return EntityHelper.DoGetOrCreate<long, ExpressionDAL, Expression>(() => ExpressionDAL.GetOrCreate(oldHash, hash, value));
	}

	public static Expression CreateNew(string value)
	{
		Expression expression = new Expression();
		expression.Value = value;
		expression.Save();
		return expression;
	}

	public static Expression Get(long id)
	{
		return EntityHelper.GetEntityOld(EntityCacheInfo, id, () => DoGet(id));
	}

	public static Expression Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static Expression Get(string value)
	{
		string hash = (Settings.Default.IsGetByHashUnicodeEnabled ? HashValue(value) : OldHashValue(value));
		return EntityHelper.GetEntityByLookupOld<long, Expression>(EntityCacheInfo, hash, () => DoGet(hash));
	}

	public static Expression GetOrCreate(string value)
	{
		string oldHash = OldHashValue(value);
		string hash = HashValue(value);
		string lookupHash = (Settings.Default.IsGetByHashUnicodeEnabled ? hash : oldHash);
		return EntityHelper.GetOrCreateEntity<long, Expression>(EntityCacheInfo, lookupHash, () => DoGetOrCreate(oldHash, hash, value));
	}

	public static string OldHashValue(string value)
	{
		value = value.TrimEnd();
		return HashFunctions.ComputeHashString(value.GetBytes());
	}

	public static string HashValue(string value)
	{
		value = value.TrimEnd();
		UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
		return HashFunctions.ComputeHashString(value.GetBytes(unicodeEncoding));
	}

	public void Construct(ExpressionDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		ICollection<string> idLookups = new List<string>();
		if (_EntityDAL != null)
		{
			idLookups.Add(Settings.Default.IsGetByHashUnicodeEnabled ? HashUnicode : Hash);
		}
		return idLookups;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
