using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

internal class StaticFile : IRobloxEntity<int, StaticFileDAL>, ICacheableObject<int>, ICacheableObject
{
	private StaticFileDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.StaticFile", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public string FileName
	{
		get
		{
			return _EntityDAL.FileName;
		}
		set
		{
			_EntityDAL.FileName = value;
		}
	}

	public string Hash
	{
		get
		{
			return _EntityDAL.Hash;
		}
		set
		{
			_EntityDAL.Hash = value;
		}
	}

	public byte CompressionTypeID
	{
		get
		{
			return _EntityDAL.CompressionTypeID;
		}
		set
		{
			_EntityDAL.CompressionTypeID = value;
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

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public StaticFile()
	{
		_EntityDAL = new StaticFileDAL();
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

	public static StaticFile CreateNew(string filename, string hash, byte compressiontypeID)
	{
		StaticFile staticFile = new StaticFile();
		staticFile.FileName = filename;
		staticFile.Hash = hash;
		staticFile.CompressionTypeID = compressiontypeID;
		staticFile.Save();
		return staticFile;
	}

	public static StaticFile Get(int id)
	{
		return EntityHelper.GetEntity<int, StaticFileDAL, StaticFile>(EntityCacheInfo, id, () => StaticFileDAL.Get(id));
	}

	public static StaticFile GetStaticFileByFileNameAndCompressionType(string fileName, byte compressiontypeID)
	{
		return EntityHelper.GetEntityByLookup<int, StaticFileDAL, StaticFile>(EntityCacheInfo, $"FileName:{fileName}_CompressionType:{compressiontypeID}", () => StaticFileDAL.GetStaticFileByFileNameAndCompressionType(fileName, compressiontypeID));
	}

	public void Construct(StaticFileDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"FileName:{FileName}_CompressionType:{CompressionTypeID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
