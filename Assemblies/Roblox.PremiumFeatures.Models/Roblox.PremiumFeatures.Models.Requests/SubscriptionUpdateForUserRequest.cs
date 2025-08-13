using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Requests;

[DataContract]
public class SubscriptionUpdateForUserRequest
{
	[DataMember(Name = "accountId", EmitDefaultValue = true, IsRequired = true)]
	public long AccountId { get; set; }

	[DataMember(Name = "productId", EmitDefaultValue = true, IsRequired = true)]
	public int ProductId { get; set; }

	[DataMember(Name = "IsSwitchingToMonthly", EmitDefaultValue = true, IsRequired = true)]
	public bool IsSwitchingToMonthly { get; set; }
}
