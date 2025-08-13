using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Properties;

namespace Roblox;

[Serializable]
public class AccountEmailAddress : IRobloxEntity<int, AccountEmailAddressDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	public delegate void EntityUpdatedEventHandler(AccountEmailAddress sender, SaveAccountEmailAddressEventArgs e);

	/// <remarks>MailChimp has been obsoleted. This enum is saved for compatibility reasons.</remarks>
	public enum SaveRequestSource
	{
		Roblox,
		MailChimp
	}

	public class SaveAccountEmailAddressEventArgs : EventArgs
	{
		public SaveRequestSource SaveRequestSource { get; private set; }

		public SaveAccountEmailAddressEventArgs(SaveRequestSource saveRequestSource)
		{
			SaveRequestSource = saveRequestSource;
		}
	}

	private AccountEmailAddressDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), "Roblox.AccountEmailAddress", isNullCacheable: true);

	public int ID => _EntityDAL.ID;

	public long AccountID
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

	public int EmailAddressID
	{
		get
		{
			return _EntityDAL.EmailAddressID;
		}
		set
		{
			_EntityDAL.EmailAddressID = value;
		}
	}

	public bool IsVerified
	{
		get
		{
			return _EntityDAL.IsVerified;
		}
		set
		{
			_EntityDAL.IsVerified = value;
		}
	}

	public bool IsValid
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

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public bool Newsletter
	{
		get
		{
			return _EntityDAL.Newsletter;
		}
		set
		{
			_EntityDAL.Newsletter = value;
		}
	}

	public static string UnsubscribeNewsletterKey => Settings.Default.UnsubscribeNewsletterKey;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public static event EntityUpdatedEventHandler EntityUpdated;

	public void Construct(AccountEmailAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public AccountEmailAddress()
	{
		_EntityDAL = new AccountEmailAddressDAL();
	}

	public AccountEmailAddress(AccountEmailAddressDAL dal)
	{
		_EntityDAL = dal;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public Account GetAccount()
	{
		return Account.MustGet(AccountID);
	}

	public EmailAddress GetEmailAddress()
	{
		return EmailAddress.MustGet(EmailAddressID);
	}

	public void Save(SaveRequestSource saveRequestSource = SaveRequestSource.Roblox)
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
		OnEntityUpdated(this, new SaveAccountEmailAddressEventArgs(saveRequestSource));
	}

	public string EncryptAccountID(long accountId)
	{
		return HashFunctions.ComputeHashString((accountId + UnsubscribeNewsletterKey).GetBytes());
	}

	public static AccountEmailAddress CreateNew(long accountId, int emailAddressId, bool newsletter)
	{
		AccountEmailAddress currentAccountEmailAddress = GetCurrent(accountId);
		if (currentAccountEmailAddress != null && currentAccountEmailAddress.EmailAddressID == emailAddressId)
		{
			return currentAccountEmailAddress;
		}
		AccountEmailAddress accountEmailAddress = new AccountEmailAddress();
		accountEmailAddress.AccountID = accountId;
		accountEmailAddress.EmailAddressID = emailAddressId;
		accountEmailAddress.Newsletter = newsletter;
		accountEmailAddress.Save();
		return accountEmailAddress;
	}

	public static AccountEmailAddress CreateNew(long accountId, string emailAddress, bool newsletter)
	{
		EmailAddress ea = EmailAddress.GetOrCreate(emailAddress);
		return CreateNew(accountId, ea.ID, newsletter);
	}

	public static AccountEmailAddress Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountEmailAddressDAL, AccountEmailAddress>(EntityCacheInfo, id, () => AccountEmailAddressDAL.Get(id));
	}

	public static AccountEmailAddress Get(int? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return Get(id.Value);
	}

	public static AccountEmailAddress GetCurrent(long accountId)
	{
		return GetCurrentValid(accountId);
	}

	public static AccountEmailAddress GetCurrentValid(long accountId)
	{
		return GetValidAccountEmailAddressesPaged(accountId, 0, 1).FirstOrDefault();
	}

	public static AccountEmailAddress GetCurrentVerified(long accountId)
	{
		return GetValidAccountEmailAddressesByIsVerifiedPaged(accountId, isVerified: true, 0, 1).FirstOrDefault();
	}

	public static AccountEmailAddress GetCurrentUnverified(long accountId)
	{
		return GetValidAccountEmailAddressesByIsVerifiedPaged(accountId, isVerified: false, 0, 1).FirstOrDefault();
	}

	public static int GetTotalNumberOfValidAccountEmailAddresses(long accountId)
	{
		string countId = $"GetTotalNumberOfAccountEmailAddresses_AccountID:{accountId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), countId, () => AccountEmailAddressDAL.GetTotalNumberOfValidAccountEmailAddresses(accountId));
	}

	public static int GetTotalNumberOfAccountsByValidEmailAddressID(int emailAddressId)
	{
		string countId = $"GetTotalNumberOfAccountsByValidEmailAddressID_EmailAddressID:{emailAddressId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"EmailAddressID:{emailAddressId}"), countId, () => AccountEmailAddressDAL.GetTotalNumberOfAccountsByValidEmailAddressID(emailAddressId));
	}

	public static ICollection<AccountEmailAddress> GetValidAccountEmailAddresses(int emailAddressId)
	{
		string collectionId = $"GetAccountEmailAddresses_EmailAddressID:{emailAddressId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"EmailAddressID:{emailAddressId}"), collectionId, () => AccountEmailAddressDAL.GetValidAccountEmailAddressIDs(emailAddressId), MultiGet);
	}

	public static ICollection<AccountEmailAddress> GetValidAccountEmailAddressesPaged(long accountId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAccountEmailAddressesPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => AccountEmailAddressDAL.GetValidAccountEmailAddressIDsPaged(accountId, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<AccountEmailAddress> GetValidAccountEmailAddressesByIsVerifiedPaged(long accountId, bool isVerified, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetValidAccountEmailAddressesPaged_AccountID:{accountId}_IsVerified:{isVerified}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => AccountEmailAddressDAL.GetValidAccountEmailAddressIDsByIsVerifiedPaged(accountId, isVerified, startRowIndex + 1, maximumRows), MultiGet);
	}

	internal static ICollection<AccountEmailAddress> GetAccountEmailAddressesByEmailAddressID(int emailAddressId, int count, int exclusiveStartAccountEmailAddressId)
	{
		string collectionId = $"GetAccountEmailAddressesByEmailAddressID_EmailAddressID:{emailAddressId}_Count:{count}_ExclusiveStartAccountEmailAddressID:{exclusiveStartAccountEmailAddressId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByEmailAddressID(emailAddressId)), collectionId, () => AccountEmailAddressDAL.GetAccountEmailAddressIDsByEmailAddressID(emailAddressId, count, exclusiveStartAccountEmailAddressId), MultiGet);
	}

	internal static int GetTotalNumberOfAccountEmailAddressesByEmailAddressId(int emailAddressId)
	{
		string countId = $"GetTotalNumberOfAccountEmailAddressesByEmailAddressId_EmailAddressID:{emailAddressId}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByEmailAddressID(emailAddressId)), countId, () => AccountEmailAddressDAL.GetTotalNumberOfAccountEmailAddressesByEmailAddressID(emailAddressId));
	}

	public static ICollection<AccountEmailAddress> GetAccountEmailAddressesPaged(long accountId, int startRowIndex, int maximumRows)
	{
		string collectionId = $"GetAllAccountEmailAddressesPaged_AccountID:{accountId}_StartRowIndex:{startRowIndex}_MaximumRows:{maximumRows}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => AccountEmailAddressDAL.GetAccountEmailAddressIDsPaged(accountId, startRowIndex + 1, maximumRows), MultiGet);
	}

	public static ICollection<AccountEmailAddress> GetAccountEmailAddressesByEmailAddressIDAndIsValid(int emailAddressId, bool isValid, int count, int exclusiveStartId)
	{
		string collectionId = $"GetAccountEmailAddressesByEmailAddressIDAndIsValid_EmailAddressID:{emailAddressId}_IsValid:{isValid}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByEmailAddressIDIsValid(emailAddressId, isValid)), collectionId, () => AccountEmailAddressDAL.GetAccountEmailAddressIDsByEmailAddressIDAndIsValid(emailAddressId, isValid, count, exclusiveStartId), MultiGet);
	}

	public static ICollection<AccountEmailAddress> GetAccountEmailAddressesByEmailAddressIDIsVerifiedAndIsValid(int emailAddressId, bool isVerified, bool isValid, int count, int? exclusiveStartId)
	{
		string collectionId = $"GetAccountEmailAddressesByEmailAddressIDIsVerifiedAndIsValid_EmailAddressID:{emailAddressId}_IsVerified:{isVerified}_IsValid:{isValid}_Count:{count}_ExclusiveStartID:{exclusiveStartId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, CacheManager.BuildQualifiedCachePolicy(GetLookupCacheKeysByEmailAddressIDIsVerifiedIsValid(emailAddressId, isVerified, isValid)), collectionId, () => AccountEmailAddressDAL.GetAccountEmailAddressIDsByEmailAddressIDIsVerifiedAndIsValid(emailAddressId, isVerified, isValid, count, exclusiveStartId), MultiGet);
	}

	private static ICollection<AccountEmailAddress> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, AccountEmailAddressDAL, AccountEmailAddress>(ids, EntityCacheInfo, AccountEmailAddressDAL.MultiGet);
	}

	public static AccountEmailAddress MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static void RevertAccountEmailAddress(AccountEmailAddress accountEmailAddressToRestore)
	{
		if (!accountEmailAddressToRestore.IsValid)
		{
			throw new ApplicationException($"Cannot revert AccountEmailAddress: {accountEmailAddressToRestore.ID}.  The item is not valid.");
		}
		int totalNumberOfValidAccountEmailAddresses = GetTotalNumberOfValidAccountEmailAddresses(accountEmailAddressToRestore.AccountID);
		foreach (AccountEmailAddress accountEmailAddress in GetValidAccountEmailAddressesPaged(accountEmailAddressToRestore.AccountID, 0, totalNumberOfValidAccountEmailAddresses))
		{
			if (accountEmailAddress.ID == accountEmailAddressToRestore.ID)
			{
				break;
			}
			accountEmailAddress.IsValid = false;
			accountEmailAddress.Save();
		}
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountID:{AccountID}");
		yield return new StateToken($"EmailAddressID:{EmailAddressID}");
		yield return new StateToken(GetLookupCacheKeysByEmailAddressIDIsValid(EmailAddressID, IsValid));
		yield return new StateToken(GetLookupCacheKeysByEmailAddressIDIsVerifiedIsValid(EmailAddressID, IsVerified, IsValid));
	}

	private static void OnEntityUpdated(AccountEmailAddress sender, SaveAccountEmailAddressEventArgs e)
	{
		if (AccountEmailAddress.EntityUpdated != null)
		{
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				AccountEmailAddress.EntityUpdated(sender, e);
			});
		}
	}

	private static string GetLookupCacheKeysByEmailAddressID(int emailAddressID)
	{
		return $"EmailAddressID:{emailAddressID}";
	}

	private static string GetLookupCacheKeysByEmailAddressIDIsValid(int emailAddressId, bool isValid)
	{
		return $"EmailAddressID:{emailAddressId}_IsValid:{isValid}";
	}

	private static string GetLookupCacheKeysByEmailAddressIDIsVerifiedIsValid(int emailAddressId, bool isVerified, bool isValid)
	{
		return $"EmailAddressID:{emailAddressId}_IsVerified:{isVerified}_IsValid:{isValid}";
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}
}
