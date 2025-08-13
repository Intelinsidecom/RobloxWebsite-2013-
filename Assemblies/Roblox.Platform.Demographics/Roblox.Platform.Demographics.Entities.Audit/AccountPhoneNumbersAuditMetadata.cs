using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditMetadata : IRobloxEntity<long, AccountPhoneNumbersAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountPhoneNumbersAuditMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPhoneNumbersAuditMetadata).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AccountPhoneNumbersAuditEntriesPublicID
	{
		get
		{
			return _EntityDAL.AccountPhoneNumbersAuditEntriesPublicID;
		}
		set
		{
			_EntityDAL.AccountPhoneNumbersAuditEntriesPublicID = value;
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

	internal long? ActorUserID
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

	internal byte AccountPhoneNumbersChangeTypeID
	{
		get
		{
			return _EntityDAL.AccountPhoneNumbersChangeTypeID;
		}
		set
		{
			_EntityDAL.AccountPhoneNumbersChangeTypeID = value;
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

	public AccountPhoneNumbersAuditMetadata()
	{
		_EntityDAL = new AccountPhoneNumbersAuditMetadataDAL();
	}

	public AccountPhoneNumbersAuditMetadata(AccountPhoneNumbersAuditMetadataDAL entityDAL)
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
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static AccountPhoneNumbersAuditMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountPhoneNumbersAuditMetadataDAL, AccountPhoneNumbersAuditMetadata>(EntityCacheInfo, id, () => AccountPhoneNumbersAuditMetadataDAL.Get(id));
	}

	private static ICollection<AccountPhoneNumbersAuditMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountPhoneNumbersAuditMetadataDAL, AccountPhoneNumbersAuditMetadata>(ids, EntityCacheInfo, AccountPhoneNumbersAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AccountPhoneNumbersAuditMetadata> GetAccountPhoneNumbersAuditMetadataByUserIDAndAccountPhoneNumbersChangeTypeID(long userId, byte accountPhoneNumbersChangeTypeId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		string collectionId = $"GetAccountPhoneNumbersAuditMetadataByUserIDAndAccountPhoneNumbersChangeTypeID_UserID:{userId}_AccountPhoneNumbersChangeTypeID:{accountPhoneNumbersChangeTypeId}_Count:{count}_ExclusiveStartAccountPhoneNumbersAuditMetadataID:{exclusiveStartAccountPhoneNumbersAuditMetadataId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserIDAccountPhoneNumbersChangeTypeID(userId, accountPhoneNumbersChangeTypeId)), collectionId, () => AccountPhoneNumbersAuditMetadataDAL.GetAccountPhoneNumbersAuditMetadataIDsByUserIDAndAccountPhoneNumbersChangeTypeID(userId, accountPhoneNumbersChangeTypeId, count, exclusiveStartAccountPhoneNumbersAuditMetadataId), MultiGet);
	}

	internal static ICollection<AccountPhoneNumbersAuditMetadata> GetAccountPhoneNumbersAuditMetadataByUserID(long userId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		string collectionId = $"GetAccountPhoneNumbersAuditMetadataByUserID_UserID:{userId}_Count:{count}_ExclusiveStartAccountPhoneNumbersAuditMetadataID:{exclusiveStartAccountPhoneNumbersAuditMetadataId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserID(userId)), collectionId, () => AccountPhoneNumbersAuditMetadataDAL.GetAccountPhoneNumbersAuditMetadataIDsByUserID(userId, count, exclusiveStartAccountPhoneNumbersAuditMetadataId), MultiGet);
	}

	public void Construct(AccountPhoneNumbersAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByUserIDAccountPhoneNumbersChangeTypeID(UserID, AccountPhoneNumbersChangeTypeID));
		yield return new StateToken(GetLookupCacheKeysByUserID(UserID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByUserIDAccountPhoneNumbersChangeTypeID(long userId, byte accountPhoneNumbersChangeTypeId)
	{
		return $"UserID:{userId}_AccountPhoneNumbersChangeTypeID:{accountPhoneNumbersChangeTypeId}";
	}

	private static string GetLookupCacheKeysByUserID(long userId)
	{
		return $"UserID:{userId}";
	}
}
