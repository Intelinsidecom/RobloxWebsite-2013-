using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Responses;

[DataContract]
public class PurchasePlatformResponse
{
	/// <summary>
	/// String value of the platform on which the subscription was purchased
	/// </summary>
	[DataMember(Name = "purchasePlatform", EmitDefaultValue = true, IsRequired = true)]
	public string PurchasePlatform { get; set; }
}
