using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditEntry : IRobloxEntity<long, AccountPhoneNumbersAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject, IRobloxEntity<Guid, AccountPhoneNumbersAuditEntryDAL>, ICacheableObject<Guid>
{
	private AccountPhoneNumbersAuditEntryDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPhoneNumbersAuditEntry).ToString(), isNullCacheable: true);

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

	internal long? Audit_PhoneNumberID
	{
		get
		{
			return _EntityDAL.Audit_PhoneNumberID;
		}
		set
		{
			_EntityDAL.Audit_PhoneNumberID = value;
		}
	}

	internal bool? Audit_IsVerified
	{
		get
		{
			return _EntityDAL.Audit_IsVerified;
		}
		set
		{
			_EntityDAL.Audit_IsVerified = value;
		}
	}

	internal string Audit_Phone
	{
		get
		{
			return _EntityDAL.Audit_Phone;
		}
		set
		{
			_EntityDAL.Audit_Phone = value;
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

	public AccountPhoneNumbersAuditEntry()
	{
		_EntityDAL = new AccountPhoneNumbersAuditEntryDAL();
	}

	public AccountPhoneNumbersAuditEntry(AccountPhoneNumbersAuditEntryDAL entityDAL)
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
			_EntityDAL.PublicID = Guid.NewGuid();
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	internal static AccountPhoneNumbersAuditEntry Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountPhoneNumbersAuditEntryDAL, AccountPhoneNumbersAuditEntry>(EntityCacheInfo, id, () => AccountPhoneNumbersAuditEntryDAL.Get(id));
	}

	private static ICollection<AccountPhoneNumbersAuditEntry> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountPhoneNumbersAuditEntryDAL, AccountPhoneNumbersAuditEntry>(ids, EntityCacheInfo, AccountPhoneNumbersAuditEntryDAL.MultiGet);
	}

	public static AccountPhoneNumbersAuditEntry GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<Guid, AccountPhoneNumbersAuditEntryDAL, AccountPhoneNumbersAuditEntry>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AccountPhoneNumbersAuditEntryDAL.GetAccountPhoneNumbersAuditEntryByPublicID(publicId));
	}

	public void Construct(AccountPhoneNumbersAuditEntryDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return GetLookupCacheKeysByPublicID(PublicID);
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByPublicID(PublicID));
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
