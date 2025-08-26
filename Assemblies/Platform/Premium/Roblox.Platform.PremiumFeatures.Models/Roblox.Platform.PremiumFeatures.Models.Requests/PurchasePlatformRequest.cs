using System.Runtime.Serialization;
namespace Roblox.Platform.PremiumFeatures.Models.Requests {
    [DataContract]

public class PurchasePlatformRequest
{
	[DataMember(Name = "accountId", EmitDefaultValue = true, IsRequired = true)]
	public long AccountId { get; set; }
}


}
