using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditCAL : IRobloxEntity<long, AccountPinHashesAuditDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject, IRobloxEntity<Guid, AccountPinHashesAuditDAL>, ICacheableObject<Guid>
{
	private AccountPinHashesAuditDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPinHashesAuditCAL).ToString(), isNullCacheable: true);

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

	internal string Audit_PinHash
	{
		get
		{
			return _EntityDAL.Audit_PinHash;
		}
		set
		{
			_EntityDAL.Audit_PinHash = value;
		}
	}

	internal bool Audit_IsValid
	{
		get
		{
			return _EntityDAL.Audit_IsValid;
		}
		set
		{
			_EntityDAL.Audit_IsValid = value;
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

	public AccountPinHashesAuditCAL()
	{
		_EntityDAL = new AccountPinHashesAuditDAL();
	}

	public AccountPinHashesAuditCAL(AccountPinHashesAuditDAL entityDAL)
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

	internal static AccountPinHashesAuditCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountPinHashesAuditDAL, AccountPinHashesAuditCAL>(EntityCacheInfo, id, () => AccountPinHashesAuditDAL.Get(id));
	}

	internal static ICollection<AccountPinHashesAuditCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountPinHashesAuditDAL, AccountPinHashesAuditCAL>(ids, EntityCacheInfo, AccountPinHashesAuditDAL.MultiGet);
	}

	public static AccountPinHashesAuditCAL GetByPublicID(Guid publicId)
	{
		return EntityHelper.GetEntityByLookup<long, AccountPinHashesAuditDAL, AccountPinHashesAuditCAL>(EntityCacheInfo, GetLookupCacheKeysByPublicID(publicId), () => AccountPinHashesAuditDAL.GetAccountPinHashesAuditByPublicID(publicId));
	}

	public void Construct(AccountPinHashesAuditDAL dal)
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
