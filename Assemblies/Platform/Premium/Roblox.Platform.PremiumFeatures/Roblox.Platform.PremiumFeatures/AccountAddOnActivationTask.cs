using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

public class AccountAddOnActivationTask : IRobloxEntity<long, AccountAddOnActivationTaskDAL>, ICacheableObject<long>, ICacheableObject, IParallelWorkTask
{
	private AccountAddOnActivationTaskDAL _EntityDAL;

	internal static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "AccountAddOnActivationTask", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	internal long PremiumFeatureActivationTaskID
	{
		get
		{
			return _EntityDAL.PremiumFeatureActivationTaskID;
		}
		set
		{
			_EntityDAL.PremiumFeatureActivationTaskID = value;
		}
	}

	internal Guid? WorkerID
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

	internal DateTime? Completed
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

	internal DateTime Created => _EntityDAL.Created;

	internal DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public string UniqueId => ID.ToString();

	public static event Action<string, long, bool> AccountAddonActivationTaskProcessed;

	public AccountAddOnActivationTask()
	{
		_EntityDAL = new AccountAddOnActivationTaskDAL();
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
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	private static DateTime CalculateBuildersClubUpgradeBaseExpiration(AccountAddOn currentBuildersClubMembershipAddOn, PremiumFeature newPremiumFeature, DurationType durationType)
	{
		DateTime now = DateTime.Now;
		if (currentBuildersClubMembershipAddOn == null || currentBuildersClubMembershipAddOn.Expiration < now)
		{
			return PremiumFeatureHelper.CalculateBaseExpiration(now, durationType, newPremiumFeature.IsRenewal);
		}
		PremiumFeature currentPremiumFeature = PremiumFeature.Get(currentBuildersClubMembershipAddOn.PremiumFeatureID);
		DateTime unpaddedExpiration = PremiumFeatureHelper.CalculateGracePeriodAwareUnpaddedExpiration(currentBuildersClubMembershipAddOn.Expiration, currentPremiumFeature.IsRenewal);
		if (Settings.Default.RenewalCalculationStartDateEqualOrLargerThanCurrentTimeEnabled && unpaddedExpiration < now)
		{
			unpaddedExpiration = now;
		}
		if ((currentPremiumFeature.IsBuildersClub && newPremiumFeature.IsBuildersClub) || (currentPremiumFeature.IsTurboBuildersClub && newPremiumFeature.IsTurboBuildersClub) || (currentPremiumFeature.IsOutrageousBuildersClub && newPremiumFeature.IsOutrageousBuildersClub))
		{
			return PremiumFeatureHelper.CalculateBaseExpiration(unpaddedExpiration, durationType, newPremiumFeature.IsRenewal);
		}
		DateTime expiration = unpaddedExpiration;
		if (!currentPremiumFeature.IsOutrageousBuildersClub)
		{
			if (currentPremiumFeature.IsTurboBuildersClub)
			{
				if (newPremiumFeature.IsOutrageousBuildersClub)
				{
					return PremiumFeatureHelper.CalculateBaseExpiration(GetCompressedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.OBCtoTBCDurationConversionFactor), durationType, newPremiumFeature.IsRenewal);
				}
				return PremiumFeatureHelper.CalculateBaseExpiration(GetExpandedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.TBCtoBCDurationConversionFactor), durationType, newPremiumFeature.IsRenewal);
			}
			DateTime compressedExpiration = ((!newPremiumFeature.IsOutrageousBuildersClub) ? GetCompressedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.TBCtoBCDurationConversionFactor) : GetCompressedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.OBCtoBCDurationConversionFactor));
			return PremiumFeatureHelper.CalculateBaseExpiration(compressedExpiration, durationType, newPremiumFeature.IsRenewal);
		}
		DateTime expandedExpiration = ((!newPremiumFeature.IsTurboBuildersClub) ? GetExpandedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.OBCtoBCDurationConversionFactor) : GetExpandedExpirationForMembershipConversion(unpaddedExpiration, Settings.Default.OBCtoTBCDurationConversionFactor));
		return PremiumFeatureHelper.CalculateBaseExpiration(expandedExpiration, durationType, newPremiumFeature.IsRenewal);
	}

	private static DateTime GetCompressedExpirationForMembershipConversion(DateTime currentMembershipExpiration, float conversionFactor)
	{
		DateTime now = DateTime.Now;
		long currentMembershipTimeRemainingInTicks = currentMembershipExpiration.Subtract(now).Ticks;
		if (currentMembershipTimeRemainingInTicks < 1)
		{
			return now;
		}
		long compressedExpirationInTicks = (long)((float)currentMembershipTimeRemainingInTicks / conversionFactor);
		return now.AddTicks(compressedExpirationInTicks);
	}

	private static DateTime GetExpandedExpirationForMembershipConversion(DateTime currentMembershipExpiration, float conversionFactor)
	{
		DateTime now = DateTime.Now;
		long currentMembershipTimeRemainingInTicks = currentMembershipExpiration.Subtract(now).Ticks;
		if (currentMembershipTimeRemainingInTicks < 1)
		{
			return now;
		}
		long expandedExpirationInTicks = (long)((float)currentMembershipTimeRemainingInTicks * conversionFactor);
		return now.AddTicks(expandedExpirationInTicks);
	}

	private void ProcessBuildersClubAddOnActivation(PremiumFeature premiumFeature, long accountId)
	{
		DurationType durationType = DurationType.Get(premiumFeature.DurationTypeID);
		RobuxStipendQuantityType robuxStipendQuantityType = RobuxStipendQuantityType.Get(premiumFeature.RobuxStipendQuantityTypeID);
		AccountAddOn latestAccountAddOnByAccountId = AccountAddOn.GetLatestAccountAddOnByAccountID(accountId);
		RobuxStipend stipend = null;
		if (latestAccountAddOnByAccountId == null)
		{
			DateTime baseExpiration = PremiumFeatureHelper.CalculateBaseExpiration(DateTime.Now, durationType, premiumFeature.IsRenewal);
			DateTime gracePeriodAwareExpiration = CalculateGracePeriodAwareExpiration(baseExpiration, premiumFeature.IsRenewal);
			DateTime? renewal = PremiumFeatureHelper.CalculateRenewal(baseExpiration, premiumFeature.IsRenewal);
			string value = robuxStipendQuantityType.Value;
			if (!(value == "None"))
			{
				stipend = RobuxStipend.CreateNew(accountId, robuxStipendQuantityType, premiumFeature.RobuxStipendFrequencyTypeID, gracePeriodAwareExpiration);
			}
			AccountAddOn.CreateNew(accountId, premiumFeature, renewal, gracePeriodAwareExpiration, stipend);
			return;
		}
		DateTime baseExpiration2 = CalculateBuildersClubUpgradeBaseExpiration(latestAccountAddOnByAccountId, premiumFeature, durationType);
		DateTime gracePeriodAwareExpiration2 = CalculateGracePeriodAwareExpiration(baseExpiration2, premiumFeature.IsRenewal);
		DateTime? renewal2 = PremiumFeatureHelper.CalculateRenewal(baseExpiration2, premiumFeature.IsRenewal);
		if (latestAccountAddOnByAccountId.RobuxStipendID.HasValue)
		{
			stipend = RobuxStipend.Get(latestAccountAddOnByAccountId.RobuxStipendID.Value);
		}
		if (stipend == null)
		{
			string value = robuxStipendQuantityType.Value;
			if (!(value == "None"))
			{
				stipend = RobuxStipend.CreateNew(accountId, robuxStipendQuantityType, premiumFeature.RobuxStipendFrequencyTypeID, gracePeriodAwareExpiration2);
			}
		}
		else
		{
			if (stipend.LastAwarded.HasValue && stipend.LastAwarded.Value < DateTime.Now.AddDays(-1.0))
			{
				stipend.LastAwarded = null;
			}
			if (!stipend.NextDistribution.HasValue)
			{
				stipend.NextDistribution = DateTime.Now;
			}
			stipend.Expiration = gracePeriodAwareExpiration2;
			stipend.RobuxStipendQuantityTypeID = robuxStipendQuantityType.ID;
			stipend.RobuxStipendFrequencyTypeID = premiumFeature.RobuxStipendFrequencyTypeID;
			stipend.Save();
		}
		if (latestAccountAddOnByAccountId.Expiration.AddDays(7.0) <= DateTime.Now)
		{
			latestAccountAddOnByAccountId.RenewedSince = DateTime.Now;
		}
		latestAccountAddOnByAccountId.Expiration = gracePeriodAwareExpiration2;
		latestAccountAddOnByAccountId.Renewal = renewal2;
		latestAccountAddOnByAccountId.PremiumFeatureID = premiumFeature.ID;
		latestAccountAddOnByAccountId.RobuxStipendID = stipend?.ID;
		latestAccountAddOnByAccountId.LeaseExpiration = null;
		latestAccountAddOnByAccountId.WorkerID = null;
		latestAccountAddOnByAccountId.Completed = null;
		latestAccountAddOnByAccountId.Save();
	}

	private void ProcessGenericAddOnActivation(PremiumFeature premiumFeature, long accountId)
	{
		DurationType durationType = DurationType.Get(premiumFeature.DurationTypeID);
		RobuxStipendQuantityType robuxStipendQuantityType = RobuxStipendQuantityType.Get(premiumFeature.RobuxStipendQuantityTypeID);
		DateTime baseExpiration = PremiumFeatureHelper.CalculateBaseExpiration(DateTime.Now, durationType, premiumFeature.IsRenewal);
		DateTime gracePeriodAwareExpiration = CalculateGracePeriodAwareExpiration(baseExpiration, premiumFeature.IsRenewal);
		DateTime? renewal = PremiumFeatureHelper.CalculateRenewal(baseExpiration, premiumFeature.IsRenewal);
		AccountAddOn currentAccountAddOn = GetLatestAccountAddOnByAccountID(accountId);
		RobuxStipend stipend = null;
		if (currentAccountAddOn == null)
		{
			string value = robuxStipendQuantityType.Value;
			if (!(value == "None"))
			{
				stipend = RobuxStipend.CreateNew(accountId, robuxStipendQuantityType, premiumFeature.RobuxStipendFrequencyTypeID, baseExpiration);
			}
			AccountAddOn.CreateNew(accountId, premiumFeature, renewal, gracePeriodAwareExpiration, stipend);
			return;
		}
		if (currentAccountAddOn.RobuxStipendID.HasValue)
		{
			stipend = RobuxStipend.Get(currentAccountAddOn.RobuxStipendID.Value);
		}
		if (stipend == null)
		{
			string value = robuxStipendQuantityType.Value;
			if (!(value == "None"))
			{
				stipend = RobuxStipend.CreateNew(accountId, robuxStipendQuantityType, premiumFeature.RobuxStipendFrequencyTypeID, baseExpiration);
			}
		}
		else
		{
			stipend.LastAwarded = null;
			stipend.NextDistribution = DateTime.Now;
			stipend.Expiration = baseExpiration;
			stipend.RobuxStipendQuantityTypeID = robuxStipendQuantityType.ID;
			stipend.RobuxStipendFrequencyTypeID = premiumFeature.RobuxStipendFrequencyTypeID;
			stipend.Save();
		}
		if (currentAccountAddOn.Expiration.AddDays(7.0) <= DateTime.Now)
		{
			currentAccountAddOn.RenewedSince = DateTime.Now;
		}
		currentAccountAddOn.Expiration = gracePeriodAwareExpiration;
		currentAccountAddOn.Renewal = renewal;
		currentAccountAddOn.PremiumFeatureID = premiumFeature.ID;
		currentAccountAddOn.RobuxStipendID = stipend?.ID;
		currentAccountAddOn.LeaseExpiration = null;
		currentAccountAddOn.WorkerID = null;
		currentAccountAddOn.Completed = null;
		currentAccountAddOn.Save();
	}

	internal static AccountAddOnActivationTask CreateNew(PremiumFeatureActivationTask premiumFeatureActivationTask)
	{
		AccountAddOnActivationTask accountAddOnActivationTask = new AccountAddOnActivationTask();
		accountAddOnActivationTask.PremiumFeatureActivationTaskID = premiumFeatureActivationTask.ID;
		accountAddOnActivationTask.Save();
		return accountAddOnActivationTask;
	}

	internal static AccountAddOnActivationTask Get(long id)
	{
		return EntityHelper.GetEntity<long, AccountAddOnActivationTaskDAL, AccountAddOnActivationTask>(EntityCacheInfo, id, () => AccountAddOnActivationTaskDAL.Get(id));
	}

	internal static AccountAddOnActivationTask Get(long? id)
	{
		if (id.HasValue)
		{
			return Get(id.Value);
		}
		return null;
	}

	public static AccountAddOnActivationTask GetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.GetOrCreateEntity<long, AccountAddOnActivationTask>(EntityCacheInfo, $"PremiumFeatureActivationTaskID:{premiumFeatureActivationTaskID}", () => DoGetOrCreate(premiumFeatureActivationTaskID));
	}

	private static AccountAddOnActivationTask DoGetOrCreate(long premiumFeatureActivationTaskID)
	{
		return EntityHelper.DoGetOrCreate<long, AccountAddOnActivationTaskDAL, AccountAddOnActivationTask>(() => AccountAddOnActivationTaskDAL.GetOrCreate(premiumFeatureActivationTaskID));
	}

	public static ICollection<IParallelWorkTask> LeaseTasks(Guid workerId, int leaseDurationInMinutes, int maxCount)
	{
		List<IParallelWorkTask> entities = new List<IParallelWorkTask>();
		foreach (long item in AccountAddOnActivationTaskDAL.LeaseTasks(workerId, leaseDurationInMinutes, maxCount))
		{
			AccountAddOnActivationTaskDAL entityDal = AccountAddOnActivationTaskDAL.Get(item);
			if (entityDal != null)
			{
				AccountAddOnActivationTask entity = new AccountAddOnActivationTask();
				entity.Construct(entityDal);
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				entities.Add(entity);
			}
		}
		return entities;
	}

	public void Construct(AccountAddOnActivationTaskDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield break;
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}

	public void ProcessTaskAndMarkComplete()
	{
		PremiumFeatureActivationTask premiumFeatureActivationTask = PremiumFeatureActivationTask.Get(PremiumFeatureActivationTaskID);
		PremiumFeature premiumFeature = PremiumFeature.Get(premiumFeatureActivationTask.PremiumFeatureID);
		AccountAddOnType accountAddOnType = AccountAddOnType.Get(premiumFeature.AccountAddOnTypeID);
		long accountId = premiumFeatureActivationTask.AccountID;
		LeasedLock leasedLock = LeasedLock.GetOrCreate("AccountAddOnActivation_AccountID:" + accountId);
		if (!leasedLock.TryAcquire(ParallelTaskWorker.ID, Settings.Default.AccountAddOnActivationLeaseDurationInMilliseconds))
		{
			ExceptionHandler.LogException(string.Format("{0}\nStackTrace:{1}", "Acquiring account add on activation lease lock failed.", Environment.StackTrace), LogLevel.Information);
			return;
		}
		AccountAddOn oldAccountAddon = GetLatestAccountAddOnByAccountID(accountId);
		DateTime? previousExpiration = oldAccountAddon?.Expiration;
		int previousPremiumFeatureId = oldAccountAddon?.PremiumFeatureID ?? 0;
		switch (accountAddOnType.Value)
		{
		case "Builders Club Membership":
		case "Turbo Builders Club Membership":
		case "Outrageous Builders Club Membership":
			ProcessBuildersClubAddOnActivation(premiumFeature, accountId);
			break;
		default:
			ProcessGenericAddOnActivation(premiumFeature, accountId);
			break;
		}
		DateTime? currentExpiration = GetLatestAccountAddOnByAccountID(accountId)?.Expiration;
		string descriptiveString = string.Format("AccountAddon updated on account ID {0} from task {1} with previous expiration: {2} and current expiration: {3}", accountId, PremiumFeatureActivationTaskID, previousExpiration.HasValue ? previousExpiration.Value.ToString() : "(none)", currentExpiration);
		if (oldAccountAddon != null && premiumFeature.IsRenewal && premiumFeature.ID == previousPremiumFeatureId && currentExpiration.HasValue && previousExpiration.Value > DateTime.Now && (currentExpiration.Value - previousExpiration.Value).TotalDays > 31.0)
		{
			string description = "Renewing a monthly BC membership, but the expiration difference is greater than a month! " + descriptiveString;
			OnAccountAddonActivationTaskProcessed(description, accountId, isSuspicious: true);
		}
		else
		{
			OnAccountAddonActivationTaskProcessed(descriptiveString, accountId, isSuspicious: false);
		}
		WorkerID = PremiumFeatureHelper.WorkerID;
		Completed = DateTime.Now;
		Save();
		leasedLock.TryRelease(ParallelTaskWorker.ID);
	}

	public void OnAccountAddonActivationTaskProcessed(string description, long accountId, bool isSuspicious)
	{
		if (AccountAddOnActivationTask.AccountAddonActivationTaskProcessed != null)
		{
			AccountAddOnActivationTask.AccountAddonActivationTaskProcessed(description, accountId, isSuspicious);
		}
	}

	private static AccountAddOn GetLatestAccountAddOnByAccountID(long accountId, int? premiumFeatureID = null)
	{
		return (from addOn in AccountAddOn.GetAccountAddOnsByAccountID(accountId)?.Where((AccountAddOn addOn) => !premiumFeatureID.HasValue || addOn.PremiumFeatureID == premiumFeatureID)
			orderby addOn.Expiration descending
			select addOn).FirstOrDefault();
	}

	internal static DateTime CalculateBuildersClubUpgradeExpiration(AccountAddOn currentBuildersClubMembershipAddOn, int newPremiumFeatureId, bool isBaseExpiration = false)
	{
		PremiumFeature newPremiumFeature = PremiumFeature.Get(newPremiumFeatureId);
		if (!newPremiumFeature.IsAnyBuildersClub && !newPremiumFeature.IsAnySubscription)
		{
			throw new ArgumentException($"PremiumFeature {newPremiumFeature.Name} is not a valid Membership.");
		}
		DurationType durationType = DurationType.Get(newPremiumFeature.DurationTypeID);
		DateTime baseExpiration = CalculateBuildersClubUpgradeBaseExpiration(currentBuildersClubMembershipAddOn, newPremiumFeature, durationType);
		if (!isBaseExpiration)
		{
			return CalculateGracePeriodAwareExpiration(baseExpiration, newPremiumFeature.IsRenewal);
		}
		return baseExpiration;
	}

	internal static DateTime CalculateGracePeriodAwareExpiration(DateTime baseExpiration, bool isRenewal)
	{
		if (!isRenewal)
		{
			return baseExpiration;
		}
		return baseExpiration.AddDays(3.0);
	}
}
