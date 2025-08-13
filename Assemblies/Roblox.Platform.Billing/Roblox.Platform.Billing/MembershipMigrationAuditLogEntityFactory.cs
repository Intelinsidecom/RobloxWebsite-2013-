using System.Diagnostics.CodeAnalysis;
using Roblox.Billing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

[ExcludeFromCodeCoverage]
internal class MembershipMigrationAuditLogEntityFactory : IMembershipMigrationAuditLogEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	public MembershipMigrationAuditLogEntityFactory(BillingDomainFactories domainFactories)
	{
		DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public IMembershipMigrationAuditLogEntity Get(long id)
	{
		return CalToCachedMssql(MembershipMigrationAuditLog.Get(id));
	}

	private static IMembershipMigrationAuditLogEntity CalToCachedMssql(MembershipMigrationAuditLog cal)
	{
		if (cal != null)
		{
			return new MembershipMigrationAuditLogCachedMssqlEntity
			{
				Id = cal.ID,
				AccountId = cal.AccountID,
				OriginalPremiumFeatureId = cal.OriginalPremiumFeatureID,
				UpdatedPremiumFeatureId = cal.UpdatedPremiumFeatureID,
				OriginalProductId = cal.OriginalProductID,
				UpdatedProductId = cal.UpdatedProductID,
				OriginalPrice = cal.OriginalPrice,
				UpdatedPrice = cal.UpdatedPrice,
				RobuxGrantAmount = cal.RobuxGrantAmount,
				SaleId = cal.SaleID,
				CurrencyTypeId = cal.CurrencyTypeID,
				LastRobuxDistributionDate = cal.LastRobuxDistributionDate,
				UpdatedMembershipStartDate = cal.UpdatedMembershipStartDate,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
