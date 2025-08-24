using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerUserAccess : IRobloxEntity<long, PrivateServerUserAccessDAL>, ICacheableObject<long>, ICacheableObject
{
	private PrivateServerUserAccessDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(PrivateServerUserAccess).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PrivateServerID
	{
		get
		{
			return _EntityDAL.PrivateServerID;
		}
		set
		{
			_EntityDAL.PrivateServerID = value;
		}
	}

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

	internal long UserID
	{
		get
		{
			return _EntityDAL.UserID;
		}
		set
		{
			_EntityDAL.UserID = value;
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

	public PrivateServerUserAccess()
	{
		_EntityDAL = new PrivateServerUserAccessDAL();
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

	internal static PrivateServerUserAccess CreateNew(long privateServerId, long universeId, long userId)
	{
		PrivateServerUserAccess privateServerUserAccess = new PrivateServerUserAccess();
		privateServerUserAccess.PrivateServerID = privateServerId;
		privateServerUserAccess.UniverseID = universeId;
		privateServerUserAccess.UserID = userId;
		privateServerUserAccess.Save();
		return privateServerUserAccess;
	}

	internal static PrivateServerUserAccess Get(long id)
	{
		return EntityHelper.GetEntity<long, PrivateServerUserAccessDAL, PrivateServerUserAccess>(EntityCacheInfo, id, () => PrivateServerUserAccessDAL.Get(id));
	}

	internal static ICollection<PrivateServerUserAccess> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, PrivateServerUserAccessDAL, PrivateServerUserAccess>(ids, EntityCacheInfo, PrivateServerUserAccessDAL.MultiGet);
	}

	internal static PrivateServerUserAccess GetPrivateServerUserAccessByPrivateServerIDAndUserID(long privateServerId, long userId)
	{
		return EntityHelper.GetEntityByLookup<long, PrivateServerUserAccessDAL, PrivateServerUserAccess>(EntityCacheInfo, $"PrivateServerID:{privateServerId}_UserID:{userId}", () => PrivateServerUserAccessDAL.GetPrivateServerUserAccessByPrivateServerIDAndUserID(privateServerId, userId));
	}

	internal static ICollection<PrivateServerUserAccess> GetPrivateServerUserAccessesByPrivateServerIdPaged(long privateServerId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPrivateServerUserAccessesByPrivateServerIdPaged_PrivateServerID:{privateServerId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerId}"), collectionId, () => PrivateServerUserAccessDAL.GetPrivateServerUserAccessIDsByPrivateServerIDPaged(privateServerId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<PrivateServerUserAccess> GetPrivateServerUserAccessesByUserIdPaged(long userId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPrivateServerUserAccessesByUserIdPaged_UserID:{userId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}"), collectionId, () => PrivateServerUserAccessDAL.GetPrivateServerUserAccessIDsByUserIDPaged(userId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<PrivateServerUserAccess> GetPrivateServerUserAccessesByUserIdUniverseIdPaged(long userId, long universeId, long startRowIndex, long maximumRows)
	{
		string collectionId = $"GetPrivateServerUserAccessesByUserIdUniverseIdPaged_UserID:{userId}_UniverseID:{universeId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}_UniverseID:{universeId}"), collectionId, () => PrivateServerUserAccessDAL.GetPrivateServerUserAccessIDsByUserIDAndUniverseIDPaged(userId, universeId, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByPrivateServerId(long privateServerId)
	{
		string countId = $"GetTotalNumberOfPrivateServerUserAccessesByPrivateServerId_PrivateServerID:{privateServerId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"PrivateServerID:{privateServerId}"), countId, () => PrivateServerUserAccessDAL.GetTotalNumberOfPrivateServerUserAccessesByPrivateServerID(privateServerId));
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByUserId(long userId)
	{
		string countId = $"GetTotalNumberOfPrivateServerUserAccessesByUserId_UserID:{userId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}"), countId, () => PrivateServerUserAccessDAL.GetTotalNumberOfPrivateServerUserAccessesByUserID(userId));
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByUserIdAndUniverseId(long userId, long universeId)
	{
		string countId = $"GetTotalNumberOfPrivateServerUserAccessesByUserIdAndUniverseId_UserID:{userId}_UniverseID:{universeId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy($"UserID:{userId}_UniverseID:{universeId}"), countId, () => PrivateServerUserAccessDAL.GetTotalNumberOfPrivateServerUserAccessesByUserIDAndUniverseID(userId, universeId));
	}

	public void Construct(PrivateServerUserAccessDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"PrivateServerID:{PrivateServerID}_UserID:{UserID}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"PrivateServerID:{PrivateServerID}");
		yield return new StateToken($"UserID:{UserID}");
		yield return new StateToken($"UserID:{UserID}_UniverseID:{UniverseID}");
	}
}
