using System.Runtime.Serialization;
namespace Roblox.Platform.PremiumFeatures.Models.Requests {
    [DataContract]

public class GetMembershipMigrationAuditLogRequest
{
	[DataMember(Name = "userId")]
	public long UserId;
}


}
