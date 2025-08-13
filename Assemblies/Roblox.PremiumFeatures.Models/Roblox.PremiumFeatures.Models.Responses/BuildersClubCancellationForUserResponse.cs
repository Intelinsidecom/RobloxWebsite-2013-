using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Responses;

[DataContract]
public class BuildersClubCancellationForUserResponse
{
	[DataMember(Name = "userId", EmitDefaultValue = true, IsRequired = true)]
	public long UserId { get; set; }

	[DataMember(Name = "robuxAmount", EmitDefaultValue = true, IsRequired = true)]
	public long RobuxAmount { get; set; }
}
