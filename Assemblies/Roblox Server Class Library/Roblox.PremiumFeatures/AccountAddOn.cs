using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Caching.Shared;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

public class AccountAddOn : IRobloxEntity<int, AccountAddOnDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
{
	private AccountAddOnDAL _EntityDAL;

	private static readonly ISharedCacheClient _MemcachedClient;

	internal static CacheInfo EntityCacheInfo;

	private static bool _IsRemoteCacheEnabled => Settings.Default.IsAccountAddonsByAccountIDRemoteCacheEnabled;

	private static int _AccountAddOnMaxCacheSize => Settings.Default.AccountAddOnMaxCacheSize;

	public int ID => _EntityDAL.ID;

	public long AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		private set
		{
			_EntityDAL.AccountID = value;
		}
	}

	public int PremiumFeatureID
	{
		get
		{
			return _EntityDAL.PremiumFeatureID;
		}
		set
		{
			_EntityDAL.PremiumFeatureID = value;
		}
	}

	public DateTime? Renewal
	{
		get
		{
			return _EntityDAL.Renewal;
		}
		set
		{
			_EntityDAL.Renewal = value;
		}
	}

	public DateTime Expiration
	{
		get
		{
			return _EntityDAL.Expiration;
		}
		set
		{
			_EntityDAL.Expiration = value;
		}
	}

	public long? RobuxStipendID
	{
		get
		{
			return _EntityDAL.RobuxStipendID;
		}
		set
		{
			_EntityDAL.RobuxStipendID = value;
		}
	}

	public DateTime? LeaseExpiration
	{
		get
		{
			return _EntityDAL.LeaseExpiration;
		}
		set
		{
			_EntityDAL.LeaseExpiration = value;
		}
	}

	public Guid? WorkerID
	{
		get
		{
			return _EntityDAL.WorkerID;
		}
		set
		{
			_EntityDAL.WorkerID = value;
		}
	}

	public DateTime? Completed
	{
		get
		{
			return _EntityDAL.Completed;
		}
		set
		{
			_EntityDAL.Completed = value;
		}
	}

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public DateTime? RenewedSince
	{
		get
		{
			return _EntityDAL.RenewedSince;
		}
		set
		{
			_EntityDAL.RenewedSince = value;
		}
	}

	public string Name => PremiumFeature.Get(PremiumFeatureID).Name;

	public string AccountAddOnTypeName => AccountAddOnType.Get(PremiumFeature.Get(PremiumFeatureID).AccountAddOnTypeID).Value;

	public bool IsLifetime => Name.Contains("Lifetime");

	public CacheInfo CacheInfo => EntityCacheInfo;

	static AccountAddOn()
	{
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountAddOn", isNullCacheable: true);
		_MemcachedClient = SharedCacheWebClient.GetSingleton();
	}

	public AccountAddOn()
	{
		_EntityDAL = new AccountAddOnDAL();
	}

	public AccountAddOn(AccountAddOnDAL entityDal)
	{
		_EntityDAL = entityDal;
	}

	public long GetStipendAmount()
	{
		if (RobuxStipendID.HasValue)
		{
			try
			{
				RobuxStipend stipend = RobuxStipend.Get(RobuxStipendID.Value);
				if (stipend != null)
				{
					RobuxStipendQuantityType quatityType = RobuxStipendQuantityType.Get(stipend.RobuxStipendQuantityTypeID);
					if (quatityType != null)
					{
						return quatityType.Amount;
					}
				}
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		return 0L;
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
		InvalidateCache(AccountID);
	}

	public PremiumFeature GetPremiumFeature()
	{
		return PremiumFeature.MustGet(PremiumFeatureID);
	}

	public void Save()
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
		InvalidateCache(AccountID);
	}

	public static AccountAddOn CreateNew(long accountId, PremiumFeature premiumFeature, DateTime? renewal, DateTime expiration, RobuxStipend robuxStipend)
	{
		AccountAddOn accountAddOn = new AccountAddOn();
		accountAddOn.AccountID = accountId;
		accountAddOn.PremiumFeatureID = premiumFeature.ID;
		accountAddOn.Renewal = renewal;
		accountAddOn.Expiration = expiration;
		accountAddOn.RobuxStipendID = robuxStipend?.ID;
		accountAddOn.LeaseExpiration = null;
		accountAddOn.WorkerID = null;
		accountAddOn.Completed = null;
		accountAddOn.RenewedSince = DateTime.Now;
		accountAddOn.Save();
		return accountAddOn;
	}

	public static AccountAddOn Get(int id)
	{
		return EntityHelper.GetEntity<int, AccountAddOnDAL, AccountAddOn>(EntityCacheInfo, id, () => AccountAddOnDAL.Get(id));
	}

	internal static ICollection<AccountAddOn> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.MultiGetEntity<int, AccountAddOnDAL, AccountAddOn>(ids, EntityCacheInfo, MultiGetDal);
	}

	private static ICollection<AccountAddOnDAL> MultiGetDal(ICollection<int> ids)
	{
		if (ids.Count != 1 || !Settings.Default.IsAccountAddonSmartMultigetEnabled)
		{
			return AccountAddOnDAL.MultiGet(ids);
		}
		return new AccountAddOnDAL[1] { AccountAddOnDAL.Get(ids.First()) };
	}

	public static ICollection<AccountAddOn> GetAccountAddOnsByPremiumFeatureIDRenewalIsNullAndExpirationRange(int premiumFeatureId, DateTime minimumExpiration, DateTime maximumExpiration, bool isRenewal, int startRowIndex, int maximumRows)
	{
		ICollection<int> collection = AccountAddOnDAL.AccountAddOns_GetAccountAddOnIDsByPremiumFeatureIDRenewalIsNullAndExpirationRange_Paged(premiumFeatureId, minimumExpiration, maximumExpiration, isRenewal, startRowIndex + 1, maximumRows);
		Collection<AccountAddOn> accountAddOns = new Collection<AccountAddOn>();
		foreach (int id in collection)
		{
			accountAddOns.Add(Get(id));
		}
		return accountAddOns;
	}

	public static ICollection<AccountAddOn> GetAccountAddOnsByAccountID(long accountId)
	{
		if (_IsRemoteCacheEnabled)
		{
			string collectionKey = GetMemcachedKey(accountId);
			_MemcachedClient.Query(collectionKey, out byte[] result);
			int[] accountAddOnIds;
			if (result == null || result.Length == 0)
			{
				accountAddOnIds = EntityHelper.GetEntityIDCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionKey, () => AccountAddOnDAL.GetAccountAddOnIDsByAccountID(accountId))?.ToArray();
				if (accountAddOnIds != null && accountAddOnIds.Length <= _AccountAddOnMaxCacheSize)
				{
					_MemcachedClient.Set(collectionKey, GetByteArrayFromIntArray(accountAddOnIds), Settings.Default.AccountAddOnCacheExpiration);
				}
			}
			else
			{
				accountAddOnIds = GetIntArrayFromByteArray(result);
			}
			return (from e in EntityHelper.GetEntitiesByIds<AccountAddOn, AccountAddOnDAL, int>(EntityCacheInfo, (IReadOnlyCollection<int>)(object)accountAddOnIds, AccountAddOnDAL.MultiGet)
				where e != null
				select e).ToList();
		}
		string collectionId = $"GetAccountAddOnsByAccountID_AccountID:{accountId}";
		return (from e in EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AccountID:{accountId}"), collectionId, () => AccountAddOnDAL.GetAccountAddOnIDsByAccountID(accountId), MultiGet)
			where e != null
			select e).ToList();
	}

	public static AccountAddOn LeaseAccountAddOnToMigrate(int id, Guid workerId, int leaseDurationInMinutes)
	{
		AccountAddOnDAL entityDal = AccountAddOnDAL.LeaseAccountAddOnToMigrate(id, workerId, leaseDurationInMinutes);
		if (entityDal != null)
		{
			AccountAddOn accountAddOn = new AccountAddOn();
			accountAddOn.Construct(entityDal);
			CacheManager.ProcessEntityChange(accountAddOn, StateChangeEventType.Modification);
			return accountAddOn;
		}
		return null;
	}

	public static ICollection<int> LeaseAccountAddOnsToExpire(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		return AccountAddOnDAL.LeaseAccountAddOnsToExpire(workerId, numberOfItems, leaseDurationInMinutes);
	}

	internal static AccountAddOn MustGet(int id)
	{
		return EntityHelper.MustGet(id, Get);
	}

	public static AccountAddOn GetBuildersClubMembershipAccountAddOn(long accountId)
	{
		AccountAddOn bcMembershipAccountAddOn = null;
		ICollection<AccountAddOn> accountAddOns = GetAccountAddOnsByAccountID(accountId);
		if (accountAddOns.Count > 0)
		{
			foreach (AccountAddOn accountAddOn in accountAddOns)
			{
				if (PremiumFeature.Get(accountAddOn.PremiumFeatureID).IsAnyBuildersClub)
				{
					bcMembershipAccountAddOn = accountAddOn;
				}
			}
		}
		return bcMembershipAccountAddOn;
	}

	public static AccountAddOn GetLatestAccountAddOnByAccountID(long accountId, int? premiumFeatureID = null)
	{
		return (from addOn in GetAccountAddOnsByAccountID(accountId)?.Where((AccountAddOn addOn) => !premiumFeatureID.HasValue || addOn.PremiumFeatureID == premiumFeatureID)
			orderby addOn.ID descending
			select addOn).FirstOrDefault();
	}

	public void Construct(AccountAddOnDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AccountID:{AccountID}");
	}

	public object GetSerializable()
	{
		return _EntityDAL;
	}

	private static byte[] GetByteArrayFromIntArray(int[] intArray)
	{
		byte[] data = new byte[intArray.Length * 4];
		for (int i = 0; i < intArray.Length; i++)
		{
			Array.Copy(BitConverter.GetBytes(intArray[i]), 0, data, i * 4, 4);
		}
		return data;
	}

	private static int[] GetIntArrayFromByteArray(byte[] byteArray)
	{
		int[] intArray = new int[byteArray.Length / 4];
		for (int i = 0; i < byteArray.Length; i += 4)
		{
			intArray[i / 4] = BitConverter.ToInt32(byteArray, i);
		}
		return intArray;
	}

	private static void InvalidateCache(long accountId)
	{
		_MemcachedClient.Remove(GetMemcachedKey(accountId));
	}

	private static string GetMemcachedKey(long accountId)
	{
		return $"GetAccountAddOnsByAccountID_AccountID:{accountId}";
	}
}
