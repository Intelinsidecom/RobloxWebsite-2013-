using System;

namespace Roblox.PremiumFeatures;

public interface IMembershipMigrationStatusEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStatusEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStatusEntity" /> with the given ID, or null if none existed.</returns>
	IMembershipMigrationStatusEntity Get(long id);

	/// <summary>
	/// Get or create a MembershipMigrationStatus Entity
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="originalPremiumFeatureId"></param>
	/// <param name="updatedPremiumFeatureId"></param>
	/// <param name="premiumStartDate"></param>
	/// <param name="robuxDistributionAmount"></param>
	/// <param name="migrationState"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity GetOrCreate(long accountId, int originalPremiumFeatureId = 0, int updatedPremiumFeatureId = 0, DateTime? premiumStartDate = null, int robuxDistributionAmount = 0, MembershipMigrationState migrationState = MembershipMigrationState.Unknown);

	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStatusEntity" /> by Account ID.
	/// </summary>
	/// <param name="accountId">The Account ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.IMembershipMigrationStatusEntity" /> with the given account ID, or null if none existed.</returns>
	IMembershipMigrationStatusEntity GetByAccountId(long accountId);

	/// <summary>
	/// Create a new MembershipMigrationStatus Entity
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="migrationState"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity Create(long accountId, MembershipMigrationState migrationState = MembershipMigrationState.Unknown);

	/// <summary>
	/// Updates the MigrationState
	/// </summary>
	/// <param name="id"></param>
	/// <param name="migrationState"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateMembershipMigrationStateById(long id, MembershipMigrationState migrationState);

	/// <summary>
	/// Updates the MigrationState by Account ID
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="migrationState"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateMembershipMigrationStateByAccountId(long accountId, MembershipMigrationState migrationState);

	/// <summary>
	/// Updates the Original PremiumFeature Id
	/// </summary>
	/// <param name="id"></param>
	/// <param name="premiumFeatureId"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateOriginalPremiumFeatureIdById(long id, int premiumFeatureId);

	/// <summary>
	/// Updates the Original PremiumFeature by Account ID
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="premiumFeatureId"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateOriginalPremiumFeatureIdByAccountId(long accountId, int premiumFeatureId);

	/// <summary>
	/// Updates the Updated PremiumFeatureId
	/// </summary>
	/// <param name="id"></param>
	/// <param name="premiumFeatureId"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateUpdatedPremiumFeatureIdById(long id, int premiumFeatureId);

	/// <summary>
	/// Updates the Updated PremiumFeatureId by Account ID
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="premiumFeatureId"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateUpdatedPremiumFeatureIdByAccountId(long accountId, int premiumFeatureId);

	/// <summary>
	/// Updates the Premium Start date
	/// </summary>
	/// <param name="id"></param>
	/// <param name="premiumStartDate"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdatePremiumStartDateById(long id, DateTime premiumStartDate);

	/// <summary>
	/// Updates the Premium Start date by Account ID
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="premiumStartDate"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdatePremiumStartDateByAccountId(long accountId, DateTime premiumStartDate);

	/// <summary>
	/// Updates the Robux Distribution amount
	/// </summary>
	/// <param name="id"></param>
	/// <param name="robuxDistributionAmount"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateRobuxDistributionAmountById(long id, int robuxDistributionAmount);

	/// <summary>
	/// Updates the Robux Distribution amount by Account ID
	/// </summary>
	/// <param name="accountId"></param>
	/// <param name="robuxDistributionAmount"></param>
	/// <returns></returns>
	IMembershipMigrationStatusEntity UpdateRobuxDistributionAmountByAccountId(long accountId, int robuxDistributionAmount);
}
