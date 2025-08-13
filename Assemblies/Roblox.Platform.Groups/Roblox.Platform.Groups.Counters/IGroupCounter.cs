using System;
using Roblox.Platform.Counters;

namespace Roblox.Platform.Groups.Counters;

public interface IGroupCounter
{
	void IncrementMembersCounter(IGroup group, DateTime timeStamp);

	void DecrementMembersCounter(IGroup group, DateTime timeStamp);

	long GetMembersCount(IGroup group, Frequency frequency, Action<Exception> exceptionHandler, bool throwOnError = false);

	void IncrementDeveloperProductUpload(IGroup group, DateTime timeStamp);

	/// <summary>
	/// Used to record creation of new assets. Updating existing assets is another call.
	/// </summary>
	void IncrementAssetUploads(IGroup group, string assetType, DateTime timeStamp);

	/// <summary>
	/// Used to record uploading new versions of existing assets.
	/// </summary>
	void IncrementAssetUpdates(IGroup group, string assetType, DateTime timeStamp);

	/// <param name="revenue">This should be the revenue to the group - it should not include the marketplace fee.</param>
	void IncrementSalesCounters(IGroup group, string productType, long revenue, string currencyType, DateTime timeStamp);
}
