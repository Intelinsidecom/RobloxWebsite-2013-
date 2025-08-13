using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditMetadataCAL : IRobloxEntity<long, AccountPinHashesAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountPinHashesAuditMetadataDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPinHashesAuditMetadataCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AccountPinHashesAuditPublicID
	{
		get
		{
			return _EntityDAL.AccountPinHashesAuditPublicID;
		}
		set
		{
			_EntityDAL.AccountPinHashesAuditPublicID = value;
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

	internal byte AccountPinChangeTypeID
	{
		get
		{
			return _EntityDAL.AccountPinChangeTypeID;
		}
		set
		{
			_EntityDAL.AccountPinChangeTypeID = value;
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

	public AccountPinHashesAuditMetadataCAL()
	{
		_EntityDAL = new AccountPinHashesAuditMetadataDAL();
	}

	public AccountPinHashesAuditMetadataCAL(AccountPinHashesAuditMetadataDAL entityDAL)
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

	internal static AccountPinHashesAuditMetadataCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountPinHashesAuditMetadataDAL, AccountPinHashesAuditMetadataCAL>(EntityCacheInfo, id, () => AccountPinHashesAuditMetadataDAL.Get(id));
	}

	internal static ICollection<AccountPinHashesAuditMetadataCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountPinHashesAuditMetadataDAL, AccountPinHashesAuditMetadataCAL>(ids, EntityCacheInfo, AccountPinHashesAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AccountPinHashesAuditMetadataCAL> GetAccountPinHashesAuditMetadataByUserIDAndAccountPinChangeTypeID(long userId, byte accountPinChangeTypeId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountPinHashesAuditMetadataByUserIDAndAccountPinChangeTypeID_UserID:{userId}_AccountPinChangeTypeID:{accountPinChangeTypeId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserIDAccountPinChangeTypeID(userId, accountPinChangeTypeId)), collectionId, () => AccountPinHashesAuditMetadataDAL.GetAccountPinHashesAuditMetadataIDsByUserIDAndAccountPinChangeTypeID(userId, accountPinChangeTypeId, count, exclusiveStartId), MultiGet);
	}

	internal static ICollection<AccountPinHashesAuditMetadataCAL> GetAccountPinHashesAuditMetadataByUserID(long userId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountPinHashesAuditMetadataByUserID_UserID:{userId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByUserID(userId)), collectionId, () => AccountPinHashesAuditMetadataDAL.GetAccountPinHashesAuditMetadataIDsByUserID(userId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AccountPinHashesAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByUserIDAccountPinChangeTypeID(UserID, AccountPinChangeTypeID));
		yield return new StateToken(GetLookupCacheKeysByUserID(UserID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByUserIDAccountPinChangeTypeID(long userId, byte accountPinChangeTypeId)
	{
		return $"UserID:{userId}_AccountPinChangeTypeID:{accountPinChangeTypeId}";
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByUserID(long userId)
	{
		return $"UserID:{userId}";
	}
}
