using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumberCAL : IRobloxEntity<int, AccountPhoneNumberDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private AccountPhoneNumberDAL _EntityDAL;

	private bool _IsVerifiedChanged;

	private bool? _IsVerifiedOld;

	private bool _IsActiveChanged;

	private bool? _IsActiveOld;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(AccountPhoneNumberCAL).ToString(), isNullCacheable: true);

	public int ID => _EntityDAL.ID;

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

	internal string Phone
	{
		get
		{
			return _EntityDAL.Phone;
		}
		set
		{
			_EntityDAL.Phone = value;
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

	internal int? PhoneNumberID
	{
		get
		{
			return _EntityDAL.PhoneNumberID;
		}
		set
		{
			_EntityDAL.PhoneNumberID = value;
		}
	}

	internal bool? IsVerified
	{
		get
		{
			return _EntityDAL.IsVerified;
		}
		set
		{
			_IsVerifiedChanged = true;
			_IsVerifiedOld = _EntityDAL.IsVerified;
			_EntityDAL.IsVerified = value;
		}
	}

	internal bool? IsActive
	{
		get
		{
			return _EntityDAL.IsActive;
		}
		set
		{
			_IsActiveChanged = true;
			_IsActiveOld = _EntityDAL.IsActive;
			_EntityDAL.IsActive = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public AccountPhoneNumberCAL()
	{
		_EntityDAL = new AccountPhoneNumberDAL();
	}

	public AccountPhoneNumberCAL(AccountPhoneNumberDAL entityDAL)
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

	internal static AccountPhoneNumberCAL Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountPhoneNumberDAL, AccountPhoneNumberCAL>(EntityCacheInfo, id, () => AccountPhoneNumberDAL.Get(id));
	}

	internal static ICollection<AccountPhoneNumberCAL> GetAccountPhoneNumberIDsByPhoneNumberIDIsVerifiedAndIsActive(int phoneNumberId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		string collectionId = $"GetAccountPhoneNumbersByPhoneNumberIDAndIsVerified_PhoneNumberID:{phoneNumberId}_IsVerified:{isVerified}_IsActive:{isActive}_Count:{count}_ExclusiveStartAccountPhoneNumberID:{exclusiveStartAccountPhoneNumberId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByPhoneNumberIDIsVerifiedIsActive(phoneNumberId, isVerified, isActive)), collectionId, () => AccountPhoneNumberDAL.GetAccountPhoneNumberIDsByPhoneNumberIDIsVerifiedAndIsActive(phoneNumberId, isVerified, isActive, count, exclusiveStartAccountPhoneNumberId), MultiGet);
	}

	private static ICollection<AccountPhoneNumberCAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, AccountPhoneNumberDAL, AccountPhoneNumberCAL>(ids, EntityCacheInfo, AccountPhoneNumberDAL.MultiGet);
	}

	internal static ICollection<AccountPhoneNumberCAL> GetAccountPhoneNumbersByAccountIDAndIsVerified(long accountId, bool? isVerified, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		string collectionId = $"GetAccountPhoneNumbersByAccountIDAndIsVerified_AccountID:{accountId}_IsVerified:{isVerified}_Count:{count}_ExclusiveStartAccountPhoneNumberID:{exclusiveStartAccountPhoneNumberId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountIDIsVerified(accountId, isVerified)), collectionId, () => AccountPhoneNumberDAL.GetAccountPhoneNumberIDsByAccountIDAndIsVerified(accountId, isVerified, count, exclusiveStartAccountPhoneNumberId), MultiGet);
	}

	internal static ICollection<AccountPhoneNumberCAL> GetAccountPhoneNumbersByAccountIDIsVerifiedAndIsActive(long accountId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		string collectionId = $"GetAccountPhoneNumbersByAccountIDAndIsVerified_AccountID:{accountId}_IsVerified:{isVerified}_IsActive:{isActive}_Count:{count}_ExclusiveStartAccountPhoneNumberID:{exclusiveStartAccountPhoneNumberId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountIDIsVerifiedIsActive(accountId, isVerified, isActive)), collectionId, () => AccountPhoneNumberDAL.GetAccountPhoneNumberIDsByAccountIDIsVerifiedAndIsActive(accountId, isVerified, isActive, count, exclusiveStartAccountPhoneNumberId), MultiGet);
	}

	internal static ICollection<AccountPhoneNumberCAL> GetAccountPhoneNumbersByAccountID(long accountId, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		string collectionId = $"GetAccountPhoneNumbersByAccountID_AccountID:{accountId}_Count:{count}_ExclusiveStartAccountPhoneNumberID:{exclusiveStartAccountPhoneNumberId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByAccountID(accountId)), collectionId, () => AccountPhoneNumberDAL.GetAccountPhoneNumberIDsByAccountID(accountId, count, exclusiveStartAccountPhoneNumberId), MultiGet);
	}

	public void Construct(AccountPhoneNumberDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (_IsVerifiedChanged || _IsActiveChanged)
		{
			bool? isVerifiedToInvalidate = (_IsVerifiedChanged ? _IsVerifiedOld : IsVerified);
			bool? isActiveToInvalidate = (_IsActiveChanged ? _IsActiveOld : IsActive);
			yield return new StateToken(GetLookupCacheKeysByPhoneNumberIDIsVerifiedIsActive(PhoneNumberID, isVerifiedToInvalidate, isActiveToInvalidate));
			yield return new StateToken(GetLookupCacheKeysByAccountIDIsVerified(AccountID, isVerifiedToInvalidate));
			yield return new StateToken(GetLookupCacheKeysByAccountIDIsVerifiedIsActive(AccountID, isVerifiedToInvalidate, isActiveToInvalidate));
		}
		yield return new StateToken(GetLookupCacheKeysByPhoneNumberIDIsVerifiedIsActive(PhoneNumberID, IsVerified, IsActive));
		yield return new StateToken(GetLookupCacheKeysByAccountIDIsVerified(AccountID, IsVerified));
		yield return new StateToken(GetLookupCacheKeysByAccountID(AccountID));
		yield return new StateToken(GetLookupCacheKeysByAccountIDIsVerifiedIsActive(AccountID, IsVerified, IsActive));
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static string GetLookupCacheKeysByID(int id)
	{
		return $"ID:{id}";
	}

	private static string GetLookupCacheKeysByAccountIDIsVerified(long accountId, bool? isVerified)
	{
		return $"AccountID:{accountId}_IsVerified:{isVerified}";
	}

	private static string GetLookupCacheKeysByAccountID(long accountId)
	{
		return $"AccountID:{accountId}_";
	}

	private static string GetLookupCacheKeysByPhoneNumberIDIsVerifiedIsActive(int? phoneNumberId, bool? isVerified, bool? isActive)
	{
		return $"PhoneNumberID:{phoneNumberId}_IsVerified:{isVerified}_IsActive:{isActive}";
	}

	private static string GetLookupCacheKeysByAccountIDIsVerifiedIsActive(long accountId, bool? isVerified, bool? isActive)
	{
		return $"AccountID:{accountId}_IsVerified:{isVerified}_IsActive:{isActive}";
	}
}
