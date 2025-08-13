using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox;

internal class File : IRobloxEntity<long, FileDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private static readonly byte[] _EmptyByteArray = new byte[0];

	private static readonly ISet<short> _EmptySet = new HashSet<short>();

	private FileDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(File).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal string MD5Hash
	{
		get
		{
			return _EntityDAL.MD5Hash;
		}
		set
		{
			_EntityDAL.MD5Hash = value;
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

	internal DateTime? Updated
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

	internal byte[] Locations
	{
		get
		{
			return _EntityDAL.Locations;
		}
		set
		{
			_EntityDAL.Locations = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	internal ISet<short> GetLocationIds()
	{
		if (Locations == null || Locations.Length == 0)
		{
			return _EmptySet;
		}
		return new HashSet<short>(Locations.ToListShort());
	}

	internal void SetLocationIds(ISet<short> locations)
	{
		if (locations == null || locations.Count == 0)
		{
			Locations = _EmptyByteArray;
		}
		else
		{
			Locations = locations.ToBinary();
		}
	}

	internal void AddLocationId(short locationId)
	{
		HashSet<short> newLocationIds = new HashSet<short>(GetLocationIds()) { locationId };
		SetLocationIds(newLocationIds);
	}

	internal void RemoveLocationId(short locationId)
	{
		HashSet<short> newLocationIds = new HashSet<short>(GetLocationIds());
		newLocationIds.Remove(locationId);
		SetLocationIds(newLocationIds);
	}

	public File()
	{
		_EntityDAL = new FileDAL();
	}

	public File(FileDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Save()
	{
		EntityHelper.SaveEntityWithRemoteCache(this, delegate
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

	internal static File Get(long id)
	{
		return EntityHelper.GetEntity<long, FileDAL, File>(EntityCacheInfo, id, () => FileDAL.Get(id));
	}

	internal static ICollection<File> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, FileDAL, File>(ids, EntityCacheInfo, FileDAL.MultiGet);
	}

	internal static File GetByMD5Hash(string md5Hash)
	{
		return EntityHelper.GetEntityByLookupWithRemoteCache<long, FileDAL, File>(EntityCacheInfo, $"MD5Hash:{md5Hash}", () => FileDAL.GetFileByMD5Hash(md5Hash), Get);
	}

	internal static File GetOrCreate(string md5Hash)
	{
		return EntityHelper.GetOrCreateEntityWithRemoteCache<long, File>(EntityCacheInfo, $"MD5Hash:{md5Hash}", () => DoGetOrCreate(md5Hash), Get);
	}

	private static File DoGetOrCreate(string mD5Hash)
	{
		return EntityHelper.DoGetOrCreate<long, FileDAL, File>(() => FileDAL.GetOrCreateFile(mD5Hash));
	}

	public void Construct(FileDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"MD5Hash:{MD5Hash}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
