using System;
using System.Collections.Generic;
using Roblox.Caching;

namespace Roblox.PremiumFeatures;

public class AccountAddOnExpirationTask : IParallelWorkTask
{
	public delegate void BuildersClubExpirationEventHandler(long accountId, EventArgs e);

	private AccountAddOn _AccountAddOn;

	public string UniqueId => _AccountAddOn.ID.ToString();

	public static event BuildersClubExpirationEventHandler BuildersClubExpiration;

	protected static void OnBuildersClubExpiration(long accountId, EventArgs e)
	{
		AccountAddOnExpirationTask.BuildersClubExpiration?.Invoke(accountId, e);
	}

	public static ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int leaseDurationInMinutes, int numberOfItems)
	{
		List<IParallelWorkTask> tasks = new List<IParallelWorkTask>();
		foreach (int item in AccountAddOn.LeaseAccountAddOnsToExpire(workerId, numberOfItems, leaseDurationInMinutes))
		{
			AccountAddOn entity = AccountAddOn.Get(item);
			if (entity != null)
			{
				AccountAddOnExpirationTask task = new AccountAddOnExpirationTask();
				task._AccountAddOn = entity;
				CacheManager.ProcessEntityChange(entity, StateChangeEventType.Modification);
				tasks.Add(task);
			}
		}
		return tasks;
	}

	public void ProcessTaskAndMarkComplete()
	{
		if (!_AccountAddOn.Completed.HasValue && _AccountAddOn.WorkerID.HasValue && !(_AccountAddOn.WorkerID.Value != PremiumFeatureHelper.WorkerID) && (!_AccountAddOn.LeaseExpiration.HasValue || !(_AccountAddOn.LeaseExpiration.Value <= DateTime.Now)))
		{
			PremiumFeature premiumFeature = PremiumFeature.Get(_AccountAddOn.PremiumFeatureID);
			if (premiumFeature.AdvertisingSuppressionTypeID != AdvertisingSuppressionType.NoneID || premiumFeature.ContentPrivilegeTypeID != ContentPrivilegeType.NoneID || premiumFeature.ShowcaseAllotmentTypeID != ShowcaseAllotmentType.NoneID)
			{
				AccountFeatureSetExpirationTask.CreateNew(_AccountAddOn);
			}
			if (premiumFeature.GrantedBadgeListID != GrantedBadgeList.NoneID)
			{
				GrantedBadgeListExpirationTask.CreateNew(_AccountAddOn);
			}
			if (premiumFeature.IsAnyBuildersClub)
			{
				OnBuildersClubExpiration(_AccountAddOn.AccountID, EventArgs.Empty);
			}
			_AccountAddOn.Completed = DateTime.Now;
			_AccountAddOn.Save();
		}
	}
}
