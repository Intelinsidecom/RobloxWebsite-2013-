using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal interface IMembershipMigrationAuditLogEntityFactory : IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Billing.IMembershipMigrationAuditLogEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Billing.IMembershipMigrationAuditLogEntity" /> with the given ID, or null if none existed.</returns>
	IMembershipMigrationAuditLogEntity Get(long id);
}
