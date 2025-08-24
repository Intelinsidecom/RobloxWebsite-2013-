using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemEntity : IRobloxEntity<long, GrantedItemDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private GrantedItemDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(GrantedItemEntity).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long GrantedItemListID
	{
		get
		{
			return _EntityDAL.GrantedItemListID;
		}
		set
		{
			_EntityDAL.GrantedItemListID = value;
		}
	}

	internal long GrantedItemTargetID
	{
		get
		{
			return _EntityDAL.GrantedItemTargetID;
		}
		set
		{
			_EntityDAL.GrantedItemTargetID = value;
		}
	}

	internal byte GrantedItemTypeID
	{
		get
		{
			return _EntityDAL.GrantedItemTypeID;
		}
		set
		{
			_EntityDAL.GrantedItemTypeID = value;
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

	public GrantedItemEntity()
	{
		_EntityDAL = new GrantedItemDAL();
	}

	public GrantedItemEntity(GrantedItemDAL entityDAL)
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

	internal static GrantedItemEntity Get(long id)
	{
		return EntityHelper.GetEntity<long, GrantedItemDAL, GrantedItemEntity>(EntityCacheInfo, id, () => GrantedItemDAL.Get(id));
	}

	private static ICollection<GrantedItemEntity> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, GrantedItemDAL, GrantedItemEntity>(ids, EntityCacheInfo, GrantedItemDAL.MultiGet);
	}

	internal static ICollection<GrantedItemEntity> GetGrantedItemsByGrantedItemListID(long grantedItemListId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetGrantedItemsByGrantedItemListID_GrantedItemListID:{grantedItemListId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetCacheQualifierByGrantedItemListID(grantedItemListId)), collectionId, () => GrantedItemDAL.GetGrantedItemIDsByGrantedItemListID(grantedItemListId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(GrantedItemDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetCacheQualifierByGrantedItemListID(GrantedItemListID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetCacheQualifierByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetCacheQualifierByGrantedItemListID(long grantedItemListId)
	{
		return $"GrantedItemListID:{grantedItemListId}";
	}
}
