using System;
using Roblox.Platform.Counters;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups.Counters;

public class GroupCounter : IGroupCounter
{
	private readonly IDurableCounterFactory _DurableCounterFactory;

	public GroupCounter(IDurableCounterFactory durableCounterFactory)
	{
		_DurableCounterFactory = durableCounterFactory;
	}

	public void IncrementMembersCounter(IGroup group, DateTime timeStamp)
	{
		if (Settings.Default.UseDurableCountersForGroupMemberCount)
		{
			GetAllTimeCounter(group, "Member").IncrementInBackground();
			GetTimeBucketedCounter(group, "Member").IncrementInBackground(timeStamp);
		}
	}

	public void DecrementMembersCounter(IGroup group, DateTime timeStamp)
	{
		if (Settings.Default.UseDurableCountersForGroupMemberCount)
		{
			GetAllTimeCounter(group, "Member").DecrementInBackground();
			GetTimeBucketedCounter(group, "Member").DecrementInBackground(timeStamp);
		}
	}

	public long GetMembersCount(IGroup group, Frequency frequency, Action<Exception> exceptionHandler, bool throwOnError = false)
	{
		try
		{
			if (frequency == Frequency.AllTime)
			{
				return (long)GetAllTimeCounter(group, "Member").GetCount();
			}
			return (long)GetTimeBucketedCounter(group, "Member").GetCount(frequency);
		}
		catch (Exception ex)
		{
			if (throwOnError || exceptionHandler == null)
			{
				throw;
			}
			exceptionHandler(ex);
			return 0L;
		}
	}

	public void IncrementDeveloperProductUpload(IGroup group, DateTime timeStamp)
	{
		IncrementAssetUploads(group, "DeveloperProduct", timeStamp);
	}

	/// <summary>
	/// Used to record creation of new assets. Updating existing assets is another call.
	/// </summary>
	public void IncrementAssetUploads(IGroup group, string assetType, DateTime timeStamp)
	{
		ICounter allTimeCounter = GetAllTimeCounter(group, "AssetUploads");
		ITimeBucketedCounter totalsTimeBucketedCounter = GetTimeBucketedCounter(group, "AssetUploads");
		ITimeBucketedCounter byTypeCounter = GetTimeBucketedCounter(group, "AssetUploads_" + assetType);
		ICounter allTimeCounter2 = GetAllTimeCounter(group, "AssetUploads_" + assetType);
		allTimeCounter.IncrementInBackground();
		totalsTimeBucketedCounter.IncrementInBackground(timeStamp);
		byTypeCounter.IncrementInBackground(timeStamp);
		allTimeCounter2.IncrementInBackground();
	}

	/// <summary>
	/// Used to record uploading new versions of existing assets.
	/// </summary>
	public void IncrementAssetUpdates(IGroup group, string assetType, DateTime timeStamp)
	{
		ITimeBucketedCounter counter = GetTimeBucketedCounter(group, "AssetUpdates_" + assetType);
		ICounter allTimeCounter = GetAllTimeCounter(group, "AssetUpdates_" + assetType);
		counter.IncrementInBackground(timeStamp);
		allTimeCounter.IncrementInBackground();
	}

	/// <param name="revenue">This should be the revenue to the group - it should not include the marketplace fee.</param>
	public void IncrementSalesCounters(IGroup group, string productType, long revenue, string currencyType, DateTime timeStamp)
	{
		ITimeBucketedCounter salesCounter = GetTimeBucketedCounter(group, "Sales");
		ICounter allTimeSalesCounter = GetAllTimeCounter(group, "Sales");
		ITimeBucketedCounter salesByProductCounter = GetTimeBucketedCounter(group, "Sales_" + productType);
		ICounter allTimeSalesByProductCounter = GetAllTimeCounter(group, "Sales_" + productType);
		ITimeBucketedCounter revenueCounter = GetTimeBucketedCounter(group, "SalesRevenue_" + currencyType);
		ICounter allTimeCounter = GetAllTimeCounter(group, "SalesRevenue_" + currencyType);
		salesCounter.IncrementInBackground(timeStamp);
		allTimeSalesCounter.IncrementInBackground();
		salesByProductCounter.IncrementInBackground(timeStamp);
		allTimeSalesByProductCounter.IncrementInBackground();
		revenueCounter.IncrementInBackground(timeStamp);
		allTimeCounter.IncrementInBackground();
	}

	private ICounter GetAllTimeCounter(IGroup group, string counterType)
	{
		return _DurableCounterFactory.GetCounter("Group", counterType, group.Id);
	}

	private ITimeBucketedCounter GetTimeBucketedCounter(IGroup group, string counterType)
	{
		return _DurableCounterFactory.GetTimeBucketedCounter("Group", counterType, group.Id);
	}
}
