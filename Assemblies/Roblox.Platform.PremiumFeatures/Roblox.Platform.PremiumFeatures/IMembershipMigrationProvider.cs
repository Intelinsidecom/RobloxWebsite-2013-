using Roblox.PremiumFeatures.Models;

namespace Roblox.Platform.PremiumFeatures;

public interface IMembershipMigrationProvider
{
	MembershipMigrationModel AttemptMembershipMigration(long userId);

	GetMembershipMigrationAuditLogResponse GetMembershipMigrationRecordForUser(long userId);
}
