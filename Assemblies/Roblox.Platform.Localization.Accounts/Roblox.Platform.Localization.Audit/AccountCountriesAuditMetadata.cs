using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditMetadata : IRobloxEntity<long, AccountCountriesAuditMetadataDAL>, ICacheableObject<long>, ICacheableObject
{
	private AccountCountriesAuditMetadataDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountCountriesAuditMetadata).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid AccountCountriesAuditEntryPublicId
	{
		get
		{
			return _EntityDAL.AccountCountriesAuditEntryPublicId;
		}
		set
		{
			_EntityDAL.AccountCountriesAuditEntryPublicId = value;
		}
	}

	internal long AccountCountriesAuditEntryAuditId
	{
		get
		{
			return _EntityDAL.AccountCountriesAuditEntryAuditId;
		}
		set
		{
			_EntityDAL.AccountCountriesAuditEntryAuditId = value;
		}
	}

	internal byte AccountCountriesAuditMetadataTypeId
	{
		get
		{
			return _EntityDAL.AccountCountriesAuditMetadataTypeId;
		}
		set
		{
			_EntityDAL.AccountCountriesAuditMetadataTypeId = value;
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

	public AccountCountriesAuditMetadata()
	{
		_EntityDAL = new AccountCountriesAuditMetadataDAL();
	}

	public AccountCountriesAuditMetadata(AccountCountriesAuditMetadataDAL entityDAL)
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

	internal static AccountCountriesAuditMetadata Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountCountriesAuditMetadataDAL, AccountCountriesAuditMetadata>(EntityCacheInfo, id, () => AccountCountriesAuditMetadataDAL.Get(id));
	}

	internal static ICollection<AccountCountriesAuditMetadata> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountCountriesAuditMetadataDAL, AccountCountriesAuditMetadata>(ids, EntityCacheInfo, AccountCountriesAuditMetadataDAL.MultiGet);
	}

	internal static ICollection<AccountCountriesAuditMetadata> GetAccountCountriesAuditMetadataByAuditEntryAuditIdAndMetadataTypeId(long accountCountriesAuditEntryAuditId, byte accountCountriesAuditMetadataTypeId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountCountriesAuditMetadataByAccountCountriesAuditEntryAudit-IDAndAccountCountriesAuditMetadataTypeID_AccountCountriesAuditEntryAudit-ID:{accountCountriesAuditEntryAuditId}_AccountCountriesAuditMetadataTypeID:{accountCountriesAuditMetadataTypeId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountCountriesAuditEntryAuditIdAccountCountriesAuditMetadataTypeId(accountCountriesAuditEntryAuditId, accountCountriesAuditMetadataTypeId)), collectionId, () => AccountCountriesAuditMetadataDAL.GetAccountCountriesAuditMetadataIDsByAuditIDAndMetadataTypeID(accountCountriesAuditEntryAuditId, accountCountriesAuditMetadataTypeId, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AccountCountriesAuditMetadataDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountCountriesAuditEntryAuditIdAccountCountriesAuditMetadataTypeId(AccountCountriesAuditEntryAuditId, AccountCountriesAuditMetadataTypeId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountCountriesAuditEntryAuditIdAccountCountriesAuditMetadataTypeId(long accountCountriesAuditEntryAuditId, byte accountCountriesAuditMetadataTypeId)
	{
		return $"AccountCountriesAuditEntryAudit-ID:{accountCountriesAuditEntryAuditId}_AccountCountriesAuditMetadataTypeID:{accountCountriesAuditMetadataTypeId}";
	}
}
