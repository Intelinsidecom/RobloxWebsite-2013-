using System.Runtime.Serialization;
namespace Roblox.Platform.PremiumFeatures.Models.Requests {
    [DataContract]

public class CancelSubscriptionRequest
{
	[DataMember(Name = "accountId", EmitDefaultValue = true, IsRequired = true)]
	public long AccountId { get; set; }
}


}
