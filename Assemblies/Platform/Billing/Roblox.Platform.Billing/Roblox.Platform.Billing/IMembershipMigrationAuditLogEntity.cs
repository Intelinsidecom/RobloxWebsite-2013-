using System;
using Roblox.Entities;

namespace Roblox.Platform.Billing;

internal interface IMembershipMigrationAuditLogEntity : IUpdateableEntity<long>, IEntity<long>
{
	long AccountId { get; set; }

	int OriginalPremiumFeatureId { get; set; }

	int UpdatedPremiumFeatureId { get; set; }

	int OriginalProductId { get; set; }

	int UpdatedProductId { get; set; }

	decimal OriginalPrice { get; set; }

	decimal UpdatedPrice { get; set; }

	int RobuxGrantAmount { get; set; }

	long SaleId { get; set; }

	byte CurrencyTypeId { get; set; }

	DateTime? LastRobuxDistributionDate { get; set; }

	DateTime? UpdatedMembershipStartDate { get; set; }
}
