using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.AccountPins.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPinHashCAL : IRobloxEntity<long, AccountPinHashDAL>, ICacheableObject<long>, ICacheableObject, IRemoteCacheableObject
{
	private AccountPinHashDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPinHashCAL).ToString(), isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	internal string PinHash
	{
		get
		{
			return _EntityDAL.PinHash;
		}
		set
		{
			_EntityDAL.PinHash = value;
		}
	}

	internal bool IsValid
	{
		get
		{
			return _EntityDAL.IsValid;
		}
		set
		{
			_EntityDAL.IsValid = value;
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

	internal DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountPinHashCAL()
	{
		_EntityDAL = new AccountPinHashDAL();
	}

	public AccountPinHashCAL(AccountPinHashDAL entityDAL)
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
			_EntityDAL.Updated = _EntityDAL.Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	internal static AccountPinHashCAL Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountPinHashDAL, AccountPinHashCAL>(EntityCacheInfo, id, () => AccountPinHashDAL.Get(id));
	}

	internal static ICollection<AccountPinHashCAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.MultiGetEntity<long, AccountPinHashDAL, AccountPinHashCAL>(ids, EntityCacheInfo, AccountPinHashDAL.MultiGet);
	}

	internal static ICollection<AccountPinHashCAL> GetAccountPinHashesByAccountIDAndIsValid(long accountId, bool isValid, int count, long? exclusiveStartId)
	{
		string collectionId = $"GetAccountPinHashesByAccountIDAndIsValid_AccountID:{accountId}_IsValid:{isValid}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountID(accountId)), collectionId, () => AccountPinHashDAL.GetAccountPinHashIDsByAccountIDAndIsValid(accountId, isValid, count, exclusiveStartId), MultiGet);
	}

	public void Construct(AccountPinHashDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken(GetLookupCacheKeysByAccountID(AccountID));
		yield return new StateToken(GetLookupCacheKeysByAccountIDIsValid(AccountID, IsValid));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(long id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountIDIsValid(long accountId, bool isValid)
	{
		return $"AccountID:{accountId}_IsValid:{isValid}";
	}

	/// <summary>
	/// This cache key should be used by
	/// * GetAccountPinHashesByAccountIDAndIsValid()
	/// * BuildStateTokenCollection()
	/// so that when a record changes its validity, caches are cleared/updated appropriatedly.
	/// </summary>
	private static string GetLookupCacheKeysByAccountID(long accountId)
	{
		return $"AccountID:{accountId}";
	}
}
