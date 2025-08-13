using System;
using System.Collections.Generic;

namespace Roblox.PremiumFeatures;

public interface IGrantedItemListActivationTaskEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IGrantedItemListActivationTaskEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemListActivationTaskEntity" /> with the given ID, or null if none existed.</returns>
	IGrantedItemListActivationTaskEntity Get(long id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.PremiumFeatures.IGrantedItemListActivationTaskEntity" /> with the given grantedItemTypeId and premiumFeatureActivationTaskId.
	/// </summary>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IGrantedItemListActivationTaskEntity" /> with the given grantedItemTypeId and premiumFeatureActivationTaskId.</returns>
	IGrantedItemListActivationTaskEntity GetOrCreate(byte grantedItemTypeId, long premiumFeatureActivationTaskId);

	/// <summary>
	/// Leases a set of <see cref="T:Roblox.PremiumFeatures.IGrantedItemListActivationTaskEntity" /> from the database
	/// </summary>
	/// <param name="grantedItemTypeId">The specific grantedItemTypeId we are asking to lease.</param>
	/// <param name="workerId">The workerId that will be used to mark who is processing each task.</param>
	/// <param name="leaseDurationInMinutes">How many minutes to hold a lease on the tasks.</param>
	/// <param name="maxToLease">The maximum number of tasks to lease in this request.</param>
	/// <returns></returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	/// - <paramref name="leaseDurationInMinutes" />
	/// - <paramref name="maxToLease" />
	/// </exception>
	ICollection<IGrantedItemListActivationTaskEntity> LeaseTasks(byte grantedItemTypeId, Guid workerId, int leaseDurationInMinutes, int maxToLease);
}
