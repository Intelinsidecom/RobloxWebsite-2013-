using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadata : IRobloxEntity<long, AccountLocalesAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject
{
	private AccountLocalesAuditMetadataDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountLocalesAuditMetadata).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AccountLocalesAuditEntryPublicId
	{
		get
		{
			return _EntityDAL.AccountLocalesAuditEntryPublicId;
		}
		set
		{
			_EntityDAL.AccountLocalesAuditEntryPublicId = value;
		}
	}

	internal long AccountLocalesAuditEntryAuditId
	{
		get
		{
			return _EntityDAL.AccountLocalesAuditEntryAuditId;
		}
		set
		{
			_EntityDAL.AccountLocalesAuditEntryAuditId = value;
		}
	}

	internal byte AccountLocalesAuditMetadataTypeId
	{
		get
		{
			return _EntityDAL.AccountLocalesAuditMetadataTypeId;
		}
		set
		{
			_EntityDAL.AccountLocalesAuditMetadataTypeId = value;
		}
	}

	internal byte ChangeAgentTypeId
	{
		get
		{
			return _EntityDAL.ChangeAgentTypeId;
		}
		set
		{
			_EntityDAL.ChangeAgentTypeId = value;
		}
	}

	internal long? ChangeAgentTargetId
	{
		get
		{
			return _EntityDAL.ChangeAgentTargetId;
		}
		set
		{
			_EntityDAL.ChangeAgentTargetId = value;
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

	public AccountLocalesAuditMetadata()
	{
		_EntityDAL = new AccountLocalesAuditMetadataDAL();
	}

	public AccountLocalesAuditMetadata(AccountLocalesAuditMetadataDAL entityDAL)
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
		});
	}

	internal static AccountLocalesAuditMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountLocalesAuditMetadataDAL, AccountLocalesAuditMetadata>(EntityCacheInfo, id, () => AccountLocalesAuditMetadataDAL.Get(id));
	}

	private static ICollection<AccountLocalesAuditMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountLocalesAuditMetadataDAL, AccountLocalesAuditMetadata>(ids, EntityCacheInfo, AccountLocalesAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AccountLocalesAuditMetadata> GetAccountLocalesAuditMetadataByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeId(long accountLocalesAuditEntryAuditId, byte accountLocalesAuditMetadataTypeId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountLocalesAuditMetadataByAccountLocalesAuditEntryAudit-IDAndAccountLocalesAuditMetadataTypeID_AccountLocalesAuditEntryAudit-ID:{accountLocalesAuditEntryAuditId}_AccountLocalesAuditMetadataTypeID:{accountLocalesAuditMetadataTypeId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountLocalesAuditEntryAuditIdAccountLocalesAuditMetadataTypeId(accountLocalesAuditEntryAuditId, accountLocalesAuditMetadataTypeId)), collectionId, () => AccountLocalesAuditMetadataDAL.GetAccountLocalesAuditMetadataIdsByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeId(accountLocalesAuditEntryAuditId, accountLocalesAuditMetadataTypeId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AccountLocalesAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountLocalesAuditEntryAuditIdAccountLocalesAuditMetadataTypeId(AccountLocalesAuditEntryAuditId, AccountLocalesAuditMetadataTypeId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountLocalesAuditEntryAuditIdAccountLocalesAuditMetadataTypeId(long accountLocalesAuditEntryAuditId, byte accountLocalesAuditMetadataTypeId)
	{
		return $"AccountLocalesAuditEntryAudit-ID:{accountLocalesAuditEntryAuditId}_AccountLocalesAuditMetadataTypeID:{accountLocalesAuditMetadataTypeId}";
	}
}
