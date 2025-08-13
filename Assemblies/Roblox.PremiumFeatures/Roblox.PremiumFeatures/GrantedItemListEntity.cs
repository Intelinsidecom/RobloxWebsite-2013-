using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemListEntity : IRobloxEntity<long, GrantedItemListDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GrantedItemListDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(GrantedItemListEntity).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	public GrantedItemListEntity()
	{
		_EntityDAL = new GrantedItemListDAL();
	}

	public GrantedItemListEntity(GrantedItemListDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.UtcNow;
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.UtcNow;
			_EntityDAL.Update();
		});
	}

	internal static GrantedItemListEntity Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedItemListDAL, GrantedItemListEntity>(EntityCacheInfo, id, () => GrantedItemListDAL.Get(id));
	}

	private static ICollection<GrantedItemListEntity> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, GrantedItemListDAL, GrantedItemListEntity>(ids, EntityCacheInfo, GrantedItemListDAL.MultiGet);
	}

	public void Construct(GrantedItemListDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByID(long id)
	{
		return $"ID:{id}";
	}
}
