using System;
using Roblox.Entities;

namespace Roblox.PremiumFeatures;

public interface IMembershipMigrationStatusEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AccountId { get; }

	int OriginalPremiumFeatureId { get; }

	int UpdatedPremiumFeatureId { get; }

	DateTime? PremiumStartDate { get; }

	int RobuxDistributionAmount { get; }

	int MigrationStateID { get; }

	new DateTime Created { get; }

	new DateTime Updated { get; }
}
