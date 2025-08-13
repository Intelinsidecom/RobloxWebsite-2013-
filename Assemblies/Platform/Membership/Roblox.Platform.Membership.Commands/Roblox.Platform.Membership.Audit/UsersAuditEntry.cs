using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntry : IRobloxEntity<long, UsersAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRobloxEntity<Guid, UsersAuditEntryDAL>, ICacheableObject<Guid>
{
	private UsersAuditEntryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(UsersAuditEntry).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	Guid ICacheableObject<Guid>.ID => PublicID;

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

	internal long Audit_AccountID
	{
		get
		{
			return _EntityDAL.Audit_AccountID;
		}
		set
		{
			_EntityDAL.Audit_AccountID = value;
		}
	}

	internal byte? Audit_AgeBracket
	{
		get
		{
			return _EntityDAL.Audit_AgeBracket;
		}
		set
		{
			_EntityDAL.Audit_AgeBracket = value;
		}
	}

	internal DateTime? Audit_BirthDate
	{
		get
		{
			return _EntityDAL.Audit_BirthDate;
		}
		set
		{
			_EntityDAL.Audit_BirthDate = value;
		}
	}

	internal byte? Audit_GenderTypeID
	{
		get
		{
			return _EntityDAL.Audit_GenderTypeID;
		}
		set
		{
			_EntityDAL.Audit_GenderTypeID = value;
		}
	}

	internal bool Audit_UseSuperSafeConversationMode
	{
		get
		{
			return _EntityDAL.Audit_UseSuperSafeConversationMode;
		}
		set
		{
			_EntityDAL.Audit_UseSuperSafeConversationMode = value;
		}
	}

	internal bool Audit_UseSuperSafePrivacyMode
	{
		get
		{
			return _EntityDAL.Audit_UseSuperSafePrivacyMode;
		}
		set
		{
			_EntityDAL.Audit_UseSuperSafePrivacyMode = value;
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

	internal DateTime? Audit_Updated
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

	public UsersAuditEntry()
	{
		_EntityDAL = new UsersAuditEntryDAL();
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
			_EntityDAL.PublicID = Guid.NewGuid();
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static UsersAuditEntry Get(long id)
	{
		return EntityHelper.GetEntity<long, UsersAuditEntryDAL, UsersAuditEntry>(EntityCacheInfo, id, () => UsersAuditEntryDAL.Get(id));
	}

	private static ICollection<UsersAuditEntry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, UsersAuditEntryDAL, UsersAuditEntry>(ids, EntityCacheInfo, UsersAuditEntryDAL.MultiGet);
	}

	public static UsersAuditEntry GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, UsersAuditEntryDAL, UsersAuditEntry>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => UsersAuditEntryDAL.GetUsersAuditEntryByPublicID(publicId));
	}

	public static IEnumerable<UsersAuditEntry> SingleGetsByPublicIds(IEnumerable<Guid> publicIds)
	{
		return publicIds.Select(GetByPublicID);
	}

	public void Construct(UsersAuditEntryDAL dal)
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

	private static string GetLookupCacheKeysByPublicID(Guid publicId)
	{
		return $"PublicID:{publicId}";
	}
}
