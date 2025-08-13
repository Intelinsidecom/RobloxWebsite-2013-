using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditMetadataCAL : IRobloxEntity<long, AccountsAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountsAuditMetadataDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountsAuditMetadataCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AccountsAuditEntriesPublicID
	{
		get
		{
			return _EntityDAL.AccountsAuditEntriesPublicID;
		}
		set
		{
			_EntityDAL.AccountsAuditEntriesPublicID = value;
		}
	}

	internal byte AccountsChangeTypeID
	{
		get
		{
			return _EntityDAL.AccountsChangeTypeID;
		}
		set
		{
			_EntityDAL.AccountsChangeTypeID = value;
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

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountsAuditMetadataCAL()
	{
		_EntityDAL = new AccountsAuditMetadataDAL();
	}

	public AccountsAuditMetadataCAL(AccountsAuditMetadataDAL entityDAL)
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

	internal static AccountsAuditMetadataCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountsAuditMetadataDAL, AccountsAuditMetadataCAL>(EntityCacheInfo, id, () => AccountsAuditMetadataDAL.Get(id));
	}

	internal static ICollection<AccountsAuditMetadataCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountsAuditMetadataDAL, AccountsAuditMetadataCAL>(ids, EntityCacheInfo, AccountsAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AccountsAuditMetadataCAL> GetAccountsAuditMetadataByAccountsChangeTypeIDAndUserID(byte accountsChangeTypeId, long userId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountsAuditMetadataByAccountsChangeTypeIDAndUserID_AccountsChangeTypeID:{accountsChangeTypeId}_UserID:{userId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountsChangeTypeIDUserID(accountsChangeTypeId, userId)), collectionId, () => AccountsAuditMetadataDAL.GetAccountsAuditMetadataIDsByAccountsChangeTypeIDAndUserID(accountsChangeTypeId, userId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AccountsAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountsChangeTypeIDUserID(AccountsChangeTypeID, UserID));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountsChangeTypeIDUserID(byte accountsChangeTypeId, long userId)
	{
		return $"AccountsChangeTypeID:{accountsChangeTypeId}_UserID:{userId}";
	}
}
