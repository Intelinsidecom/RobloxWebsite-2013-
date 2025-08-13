using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models;

[DataContract]
public class AttemptMembershipMigrationRequest
{
	[DataMember(Name = "userId", EmitDefaultValue = false, IsRequired = false)]
	public long UserId;
}
