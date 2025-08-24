using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Responses;

[DataContract]
public class SubscriptionProductResponse
{
	[DataMember(Name = "subscriptionProductModel", EmitDefaultValue = true, IsRequired = true)]
	public SubscriptionProductModel subscriptionProductModel { get; set; }
}
