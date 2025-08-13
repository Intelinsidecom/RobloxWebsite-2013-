using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Requests;

[DataContract]
public class ExecuteBuildersClubCancellationForUserRequest
{
	[DataMember(Name = "userId", EmitDefaultValue = true, IsRequired = true)]
	public long UserId { get; set; }

	[DataMember(Name = "accountId", EmitDefaultValue = true, IsRequired = true)]
	public long AccountId { get; set; }

	[DataMember(Name = "isConfirmed", EmitDefaultValue = true, IsRequired = true)]
	public bool IsConfirmed { get; set; }
}
