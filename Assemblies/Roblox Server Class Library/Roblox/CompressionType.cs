using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

public class CompressionType : IRobloxEntity<byte, CompressionTypeDAL>, ICacheableObject<byte>, ICacheableObject
{
	private CompressionTypeDAL _EntityDAL;

	public static readonly CompressionType GZIP;

	public static readonly CompressionType None;

	public static CacheInfo EntityCacheInfo;

	public byte ID => _EntityDAL.ID;

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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public CompressionType()
	{
		_EntityDAL = new CompressionTypeDAL();
	}

	static CompressionType()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.CompressionType", isNullCacheable: true);
		GZIP = Get("gzip");
		None = Get("none");
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

	public static CompressionType CreateNew(string value)
	{
		CompressionType compressionType = new CompressionType();
		compressionType.Value = value;
		compressionType.Save();
		return compressionType;
	}

	public static CompressionType Get(byte id)
	{
		return EntityHelper.GetEntity<byte, CompressionTypeDAL, CompressionType>(EntityCacheInfo, id, () => CompressionTypeDAL.Get(id));
	}

	public static CompressionType Get(string value)
	{
		return EntityHelper.GetEntityByLookup<byte, CompressionTypeDAL, CompressionType>(EntityCacheInfo, $"Value:{value}", () => CompressionTypeDAL.Get(value));
	}

	public void Construct(CompressionTypeDAL dal)
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
