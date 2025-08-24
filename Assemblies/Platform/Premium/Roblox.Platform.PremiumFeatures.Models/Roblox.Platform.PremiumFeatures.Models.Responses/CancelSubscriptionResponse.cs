using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Responses;

[DataContract]
public class CancelSubscriptionResponse
{
	[DataMember(Name = "isSuccess", EmitDefaultValue = true, IsRequired = true)]
	public bool IsSuccess { get; set; }

	[DataMember(Name = "message", EmitDefaultValue = true, IsRequired = true)]
	public string Message { get; set; }
}
