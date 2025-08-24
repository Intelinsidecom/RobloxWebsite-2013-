using Roblox.Billing.Client;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.PremiumFeatures.Models;

namespace Roblox.Platform.PremiumFeatures;

public class MembershipMigrationProvider : IMembershipMigrationProvider
{
	protected readonly IBillingClient BillingClient;

	protected readonly ILogger Logger;

	public MembershipMigrationProvider(IBillingClient billingClient, ILogger logger)
	{
		BillingClient = billingClient ?? throw new PlatformArgumentNullException("billingClient");
		Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public MembershipMigrationModel AttemptMembershipMigration(long userId)
	{
		return BillingClient.AttemptMembershipMigration(userId);
	}

	public GetMembershipMigrationAuditLogResponse GetMembershipMigrationRecordForUser(long userId)
	{
		return BillingClient.GetMembershipMigrationAuditLog(userId);
	}
}
