using System.Runtime.Serialization;
namespace Roblox.Platform.PremiumFeatures.Models {
    [DataContract]

public class AttemptMembershipMigrationRequest
{
	[DataMember(Name = "userId", EmitDefaultValue = false, IsRequired = false)]
	public long UserId;
}


}
