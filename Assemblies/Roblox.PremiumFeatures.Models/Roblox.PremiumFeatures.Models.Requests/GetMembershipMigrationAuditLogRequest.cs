using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Requests;

[DataContract]
public class GetMembershipMigrationAuditLogRequest
{
	[DataMember(Name = "userId")]
	public long UserId;
}
