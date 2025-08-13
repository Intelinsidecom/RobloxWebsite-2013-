using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingsAuditEntry : IRobloxEntity<long, TwoStepVerificationSettingsAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject, IRobloxEntity<Guid, TwoStepVerificationSettingsAuditEntryDAL>, ICacheableObject<Guid>
{
	private TwoStepVerificationSettingsAuditEntryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(TwoStepVerificationSettingsAuditEntry).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal Guid PublicID
	{
		get
		{
			return _EntityDAL.PublicID;
		}
		set
		{
			_EntityDAL.PublicID = value;
		}
	}

	internal long Audit_ID
	{
		get
		{
			return _EntityDAL.Audit_ID;
		}
		set
		{
			_EntityDAL.Audit_ID = value;
		}
	}

	internal long Audit_UserID
	{
		get
		{
			return _EntityDAL.Audit_UserID;
		}
		set
		{
			_EntityDAL.Audit_UserID = value;
		}
	}

	internal bool Audit_IsEnabled
	{
		get
		{
			return _EntityDAL.Audit_IsEnabled;
		}
		set
		{
			_EntityDAL.Audit_IsEnabled = value;
		}
	}

	internal byte? Audit_TwoStepVerificationMediaTypeID
	{
		get
		{
			return _EntityDAL.Audit_TwoStepVerificationMediaTypeID;
		}
		set
		{
			_EntityDAL.Audit_TwoStepVerificationMediaTypeID = value;
		}
	}

	internal DateTime Audit_Created
	{
		get
		{
			return _EntityDAL.Audit_Created;
		}
		set
		{
			_EntityDAL.Audit_Created = value;
		}
	}

	internal DateTime Audit_Updated
	{
		get
		{
			return _EntityDAL.Audit_Updated;
		}
		set
		{
			_EntityDAL.Audit_Updated = value;
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

	Guid ICacheableObject<Guid>.ID => PublicID;

	public TwoStepVerificationSettingsAuditEntry()
	{
		_EntityDAL = new TwoStepVerificationSettingsAuditEntryDAL();
	}

	public TwoStepVerificationSettingsAuditEntry(TwoStepVerificationSettingsAuditEntryDAL entityDAL)
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
			_EntityDAL.Update();
		});
	}

	internal static TwoStepVerificationSettingsAuditEntry Get(long id)
	{
		return EntityHelper.GetEntity<long, TwoStepVerificationSettingsAuditEntryDAL, TwoStepVerificationSettingsAuditEntry>(EntityCacheInfo, id, () => TwoStepVerificationSettingsAuditEntryDAL.Get(id));
	}

	private static ICollection<TwoStepVerificationSettingsAuditEntry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, TwoStepVerificationSettingsAuditEntryDAL, TwoStepVerificationSettingsAuditEntry>(ids, EntityCacheInfo, TwoStepVerificationSettingsAuditEntryDAL.MultiGet);
	}

	public static TwoStepVerificationSettingsAuditEntry GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, TwoStepVerificationSettingsAuditEntryDAL, TwoStepVerificationSettingsAuditEntry>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => TwoStepVerificationSettingsAuditEntryDAL.GetTwoStepVerificationSettingsAuditEntryByPublicID(publicId));
	}

	public void Construct(TwoStepVerificationSettingsAuditEntryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPublicID(PublicID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
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
		return $"PublicID:{publicId}";
	}
}
