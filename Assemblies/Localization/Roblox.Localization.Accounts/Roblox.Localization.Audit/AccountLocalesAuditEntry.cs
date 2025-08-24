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
internal class AccountLocalesAuditEntry : IRobloxEntity<long, AccountLocalesAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRobloxEntity<Guid, AccountLocalesAuditEntryDAL>, ICacheableObject<Guid>
{
	private AccountLocalesAuditEntryDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountLocalesAuditEntry).ToString(), isNullCacheable: true);

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

	internal int AuditObservedLocaleId
	{
		get
		{
			return _EntityDAL.AuditObservedLocaleId;
		}
		set
		{
			_EntityDAL.AuditObservedLocaleId = value;
		}
	}

	internal int? AuditSupportedLocaleId
	{
		get
		{
			return _EntityDAL.AuditSupportedLocaleId;
		}
		set
		{
			_EntityDAL.AuditSupportedLocaleId = value;
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

	public AccountLocalesAuditEntry()
	{
		_EntityDAL = new AccountLocalesAuditEntryDAL();
	}

	public AccountLocalesAuditEntry(AccountLocalesAuditEntryDAL entityDAL)
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

	internal static AccountLocalesAuditEntry Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountLocalesAuditEntryDAL, AccountLocalesAuditEntry>(EntityCacheInfo, id, () => AccountLocalesAuditEntryDAL.Get(id));
	}

	internal static ICollection<AccountLocalesAuditEntry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountLocalesAuditEntryDAL, AccountLocalesAuditEntry>(ids, EntityCacheInfo, AccountLocalesAuditEntryDAL.MultiGet);
	}

	internal static ICollection<AccountLocalesAuditEntry> GetAccountLocalesAuditEntriesByAuditId(long auditId, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountLocalesAuditEntriesByAudit-ID_Audit-ID:{auditId}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAuditId(auditId)), collectionId, () => AccountLocalesAuditEntryDAL.GetAccountLocalesAuditEntryIdsByAuditId(auditId, count, exclusiveStartId), MultiGet);
	}

	public static AccountLocalesAuditEntry GetByPublicId(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountLocalesAuditEntryDAL, AccountLocalesAuditEntry>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AccountLocalesAuditEntryDAL.GetAccountLocalesAuditEntryByPublicId(publicId));
	}

	public static IEnumerable<AccountLocalesAuditEntry> SingleGetByPublicIds(IEnumerable<Guid> publicIds)
	{
		return publicIds.Select(GetByPublicId);
	}

	public void Construct(AccountLocalesAuditEntryDAL dal)
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

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByPublicID(Guid publicId)
	{
		return $"PublicId:{publicId}";
	}

	private static string GetLookupCacheKeysByAuditId(long auditId)
	{
		return $"AuditId:{auditId}";
	}
}
