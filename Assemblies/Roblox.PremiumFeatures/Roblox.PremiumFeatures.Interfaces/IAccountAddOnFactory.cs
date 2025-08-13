using System;
using System.Collections.Generic;

namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// Interface for AccountAddOnFactory
/// </summary>
public interface IAccountAddOnFactory
{
	/// <summary>
	/// Get Subscription AccountAddOn for long AccountId
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	IAccountAddOnModel GetSubscriptionAccountAddOnForAccountId(long accountId);

	/// <summary>
	/// Get AccountAddOns by params
	/// </summary>
	/// <param name="premiumFeatureId">PremiumFeature Id</param>
	/// <param name="minimumExpiration">Min expiration</param>
	/// <param name="maximumExpiration">Max expiration</param>
	/// <param name="isRenewal">Is renewal</param>
	/// <param name="startRowIndex">Start row index</param>
	/// <param name="maximumRows">Max rows</param>
	/// <returns>Collection of <see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	ICollection<IAccountAddOnModel> GetAccountAddOnsByPremiumFeatureIDRenewalIsNullAndExpirationRange(int premiumFeatureId, DateTime minimumExpiration, DateTime maximumExpiration, bool isRenewal, int startRowIndex, int maximumRows);

	/// <summary>
	/// Get lease work items
	/// </summary>
	/// <param name="workerId">Worker Id</param>
	/// <param name="leaseDurationInMinutes">Lease duration in minutes</param>
	/// <param name="numberOfItems">Number of items</param>
	/// <returns>Collection of <see cref="T:Roblox.IParallelWorkTask" /></returns>
	ICollection<IParallelWorkTask> LeaseWorkItems(Guid workerId, int leaseDurationInMinutes, int numberOfItems);

	/// <summary>
	/// Lease an AccountAddOn by id for update in premium migration.
	/// </summary>
	/// <param name="id">AccountAddOn ID</param>
	/// <param name="workerId">Worker Id</param>
	/// <param name="leaseDurationInMinutes">Lease duration in minutes</param>
	/// <returns></returns>
	AccountAddOn LeaseAccountAddOnToMigrate(int id, Guid workerId, int leaseDurationInMinutes);

	/// <summary>
	/// Update an AccountAddOn with new premiumFeatureId.
	/// </summary>
	/// <param name="accountAddOn"></param>
	/// <param name="premiumFeatureId"></param>
	/// <returns></returns>
	IAccountAddOnModel UpdateAddOnToUsePremiumFeatureId(AccountAddOn accountAddOn, int premiumFeatureId);

	/// <summary>
	/// Get BuildersClub membership AccountAddOn using long accountId
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	IAccountAddOnModel GetBuildersClubMembershipAccountAddOn(long accountId);

	/// <summary>
	/// Cancel membership AccountAddOn using long accountId
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <param name="isImmediate">Should expire immediately</param>
	/// <returns>Original <see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	IAccountAddOnModel CancelMembershipForAccountId(long accountId, bool isImmediate);

	/// <summary>
	/// Reverse Builders club cancellation for long accountId
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <param name="originalAccountAddOnModel">original <see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></param>
	/// <returns>Updated <see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	IAccountAddOnModel ReverseBuildersClubCancellationMembershipForAccountId(long accountId, IAccountAddOnModel originalAccountAddOnModel);

	/// <summary>
	/// Updates a Subscription Membership to the provided Premium Feature ID using long accountId
	/// </summary>
	/// <param name="accountId">Account Id</param>
	/// <param name="premiumFeatureId">The Id of the new premium feature</param>
	/// <returns>Original <see cref="T:Roblox.PremiumFeatures.Interfaces.IAccountAddOnModel" /></returns>
	IAccountAddOnModel UpdateSubscriptionForAccountId(long accountId, int premiumFeatureId, bool isRecurring = true);

	/// <summary>
	/// Returns if Account is Premium
	/// </summary>
	/// <param name="accountId"></param>
	/// <returns></returns>
	bool IsPremiumAccount(long accountId);

	/// <summary>
	/// Returns Robux stipend amount for latest active account add on
	/// </summary>
	/// <param name="accountId"></param>
	/// <returns></returns>
	long GetRobuxStipendAmount(long accountId);
}
