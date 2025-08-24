using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditEntry : IRobloxEntity<long, AccountCountriesAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRobloxEntity<Guid, AccountCountriesAuditEntryDAL>, ICacheableObject<Guid>
{
	private AccountCountriesAuditEntryDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountCountriesAuditEntry).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	Guid ICacheableObject<Guid>.ID => PublicId;

	internal Guid PublicId
	{
		get
		{
			return _EntityDAL.PublicId;
		}
		set
		{
			_EntityDAL.PublicId = value;
		}
	}

	internal long AuditId
	{
		get
		{
			return _EntityDAL.AuditId;
		}
		set
		{
			_EntityDAL.AuditId = value;
		}
	}

	internal long AuditAccountId
	{
		get
		{
			return _EntityDAL.AuditAccountId;
		}
		set
		{
			_EntityDAL.AuditAccountId = value;
		}
	}

	internal int? AuditCountryId
	{
		get
		{
			return _EntityDAL.AuditCountryId;
		}
		set
		{
			_EntityDAL.AuditCountryId = value;
		}
	}

	internal bool AuditIsVerified
	{
		get
		{
			return _EntityDAL.AuditIsVerified;
		}
		set
		{
			_EntityDAL.AuditIsVerified = value;
		}
	}

	internal DateTime AuditCreated
	{
		get
		{
			return _EntityDAL.AuditCreated;
		}
		set
		{
			_EntityDAL.AuditCreated = value;
		}
	}

	internal DateTime AuditUpdated
	{
		get
		{
			return _EntityDAL.AuditUpdated;
		}
		set
		{
			_EntityDAL.AuditUpdated = value;
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

	public AccountCountriesAuditEntry()
	{
		_EntityDAL = new AccountCountriesAuditEntryDAL();
	}

	public AccountCountriesAuditEntry(AccountCountriesAuditEntryDAL entityDAL)
	{
		_EntityDAL = entityDAL;
	}

	internal void Delete()
	{
		EntityHelper.DeleteEntity<long>(this, _EntityDAL.Delete);
	}

	internal void Save()
	{
		EntityHelper.SaveEntity<long>(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Insert();
		}, delegate
		{
		});
	}

	internal static AccountCountriesAuditEntry Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountCountriesAuditEntryDAL, AccountCountriesAuditEntry>(EntityCacheInfo, id, () => AccountCountriesAuditEntryDAL.Get(id));
	}

	internal static ICollection<AccountCountriesAuditEntry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountCountriesAuditEntryDAL, AccountCountriesAuditEntry>(ids, EntityCacheInfo, AccountCountriesAuditEntryDAL.MultiGet);
	}

	internal static ICollection<AccountCountriesAuditEntry> GetAccountCountriesAuditEntriesByAuditId(long auditId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountCountriesAuditEntriesByAudit-ID_Audit-ID:{auditId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAuditId(auditId)), collectionId, () => AccountCountriesAuditEntryDAL.GetAccountCountriesAuditEntryIDsByAuditId(auditId, count, exclusiveStartId), MultiGet);
	}

	public static AccountCountriesAuditEntry GetByPublicId(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountCountriesAuditEntryDAL, AccountCountriesAuditEntry>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AccountCountriesAuditEntryDAL.GetAccountCountriesAuditEntryByPublicId(publicId));
	}

	public static IEnumerable<AccountCountriesAuditEntry> SingleGetByPublicIds(IEnumerable<Guid> publicIds)
	{
		return publicIds.Select(GetByPublicId);
	}

	public void Construct(AccountCountriesAuditEntryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPublicID(PublicId);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAuditId(AuditId));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByAuditId(long auditId)
	{
		return $"Audit-ID:{auditId}";
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByPublicID(Guid publicId)
	{
		return $"PublicID:{publicId}";
	}
}
