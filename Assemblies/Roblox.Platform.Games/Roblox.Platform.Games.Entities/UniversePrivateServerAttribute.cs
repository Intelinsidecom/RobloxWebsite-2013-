using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class UniversePrivateServerAttribute : IRobloxEntity<long, UniversePrivateServerAttributeDAL>, ICacheableObject<long>, ICacheableObject
{
	private UniversePrivateServerAttributeDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UniversePrivateServerAttribute).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long UniverseID
	{
		get
		{
			return _EntityDAL.UniverseID;
		}
		set
		{
			_EntityDAL.UniverseID = value;
		}
	}

	internal bool AllowPrivateServers
	{
		get
		{
			return _EntityDAL.AllowPrivateServers;
		}
		set
		{
			_EntityDAL.AllowPrivateServers = value;
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

	public UniversePrivateServerAttribute()
	{
		_EntityDAL = new UniversePrivateServerAttributeDAL();
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

	internal static UniversePrivateServerAttribute Get(long id)
	{
		return EntityHelper.GetEntity<long, UniversePrivateServerAttributeDAL, UniversePrivateServerAttribute>(EntityCacheInfo, id, () => UniversePrivateServerAttributeDAL.Get(id));
	}

	internal static ICollection<UniversePrivateServerAttribute> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UniversePrivateServerAttributeDAL, UniversePrivateServerAttribute>(ids, EntityCacheInfo, UniversePrivateServerAttributeDAL.MultiGet);
	}

	public static UniversePrivateServerAttribute GetByUniverseID(long universeID)
	{
		return EntityHelper.GetEntityByLookup<long, UniversePrivateServerAttributeDAL, UniversePrivateServerAttribute>(EntityCacheInfo, $"UniverseID:{universeID}", () => UniversePrivateServerAttributeDAL.GetUniversePrivateServerAttributeByUniverseID(universeID));
	}

	public void Construct(UniversePrivateServerAttributeDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"UniverseID:{UniverseID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
