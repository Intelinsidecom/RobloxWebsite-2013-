using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditEntryCAL : IRobloxEntity<long, AccountsAuditEntryDAL>, ICacheableObject<long>, ICacheableObject, IRobloxEntity<Guid, AccountsAuditEntryDAL>, ICacheableObject<Guid>
{
	private AccountsAuditEntryDAL _EntityDAL;

	public static readonly CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountsAuditEntryCAL).ToString(), isNullCacheable: true);

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

	internal string Audit_Name
	{
		get
		{
			return _EntityDAL.Audit_Name;
		}
		set
		{
			_EntityDAL.Audit_Name = value;
		}
	}

	internal byte Audit_AccountStatusID
	{
		get
		{
			return _EntityDAL.Audit_AccountStatusID;
		}
		set
		{
			_EntityDAL.Audit_AccountStatusID = value;
		}
	}

	internal int Audit_RoleSetID
	{
		get
		{
			return _EntityDAL.Audit_RoleSetID;
		}
		set
		{
			_EntityDAL.Audit_RoleSetID = value;
		}
	}

	internal string Audit_Description
	{
		get
		{
			return _EntityDAL.Audit_Description;
		}
		set
		{
			_EntityDAL.Audit_Description = value;
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

	public AccountsAuditEntryCAL()
	{
		_EntityDAL = new AccountsAuditEntryDAL();
	}

	public AccountsAuditEntryCAL(AccountsAuditEntryDAL entityDAL)
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

	internal static AccountsAuditEntryCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountsAuditEntryDAL, AccountsAuditEntryCAL>(EntityCacheInfo, id, () => AccountsAuditEntryDAL.Get(id));
	}

	internal static ICollection<AccountsAuditEntryCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountsAuditEntryDAL, AccountsAuditEntryCAL>(ids, EntityCacheInfo, AccountsAuditEntryDAL.MultiGet);
	}

	public static AccountsAuditEntryCAL GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountsAuditEntryDAL, AccountsAuditEntryCAL>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AccountsAuditEntryDAL.GetAccountsAuditEntryByPublicID(publicId));
	}

	public static IEnumerable<AccountsAuditEntryCAL> SingleGetsByPublicIds(IEnumerable<Guid> publicIds)
	{
		return publicIds.Select(GetByPublicID);
	}

	public void Construct(AccountsAuditEntryDAL dal)
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
