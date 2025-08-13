using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntriesMetaData : IRobloxEntity<long, UsersAuditEntriesMetaDataDAL>, ICacheableObject<long>, ICacheableObject
{
	private UsersAuditEntriesMetaDataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UsersAuditEntriesMetaData).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

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

	internal byte UsersAuditEntriesMetaDataTypeID
	{
		get
		{
			return _EntityDAL.UsersAuditEntriesMetaDataTypeID;
		}
		set
		{
			_EntityDAL.UsersAuditEntriesMetaDataTypeID = value;
		}
	}

	internal Guid UsersAuditEntriesPublicID
	{
		get
		{
			return _EntityDAL.UsersAuditEntriesPublicID;
		}
		set
		{
			_EntityDAL.UsersAuditEntriesPublicID = value;
		}
	}

	internal long ActorUserID
	{
		get
		{
			return _EntityDAL.ActorUserID;
		}
		set
		{
			_EntityDAL.ActorUserID = value;
		}
	}

	internal bool IsLegacyValue
	{
		get
		{
			return _EntityDAL.IsLegacyValue;
		}
		set
		{
			_EntityDAL.IsLegacyValue = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public UsersAuditEntriesMetaData()
	{
		_EntityDAL = new UsersAuditEntriesMetaDataDAL();
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

	internal static UsersAuditEntriesMetaData Get(long id)
	{
		return EntityHelper.GetEntity<long, UsersAuditEntriesMetaDataDAL, UsersAuditEntriesMetaData>(EntityCacheInfo, id, () => UsersAuditEntriesMetaDataDAL.Get(id));
	}

	private static ICollection<UsersAuditEntriesMetaData> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UsersAuditEntriesMetaDataDAL, UsersAuditEntriesMetaData>(ids, EntityCacheInfo, UsersAuditEntriesMetaDataDAL.MultiGet);
	}

	internal static ICollection<UsersAuditEntriesMetaData> GetUsersAuditEntriesMetaDataByUserIDAndUsersAuditEntriesMetaDataTypeID(long userId, byte usersAuditEntriesMetaDataTypeId, int count, long exclusiveStartUsersAuditEntriesMetaDataId)
	{
		string collectionId = $"GetUsersAuditEntriesMetaDataByUserIDAndUsersAuditEntriesMetaDataTypeID_UserID:{userId}_UsersAuditEntriesMetaDataTypeID:{usersAuditEntriesMetaDataTypeId}_Count:{count}_ExclusiveStartUsersAuditEntriesMetaDataID:{exclusiveStartUsersAuditEntriesMetaDataId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserIDUsersAuditEntriesMetaDataTypeID(userId, usersAuditEntriesMetaDataTypeId)), collectionId, () => UsersAuditEntriesMetaDataDAL.GetUsersAuditEntriesMetaDataIDsByUserIDAndUsersAuditEntriesMetaDataTypeID(userId, usersAuditEntriesMetaDataTypeId, count, exclusiveStartUsersAuditEntriesMetaDataId), MultiGet);
	}

	public void Construct(UsersAuditEntriesMetaDataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByUserIDUsersAuditEntriesMetaDataTypeID(UserID, UsersAuditEntriesMetaDataTypeID));
	}

	private static string GetLookupCacheKeysByPublicID(Guid publicId)
	{
		return $"PublicID:{publicId}";
	}

	private static string GetLookupCacheKeysByUserIDUsersAuditEntriesMetaDataTypeID(long userId, byte usersAuditEntriesMetaDataTypeId)
	{
		return $"UserID:{userId}_UsersAuditEntriesMetaDataTypeID:{usersAuditEntriesMetaDataTypeId}";
	}
}
