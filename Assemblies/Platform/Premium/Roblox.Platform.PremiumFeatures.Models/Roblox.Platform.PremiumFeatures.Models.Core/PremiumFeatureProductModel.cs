using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Enums;

namespace Roblox.PremiumFeatures.Models.Core;

/// <summary>
/// PremiumFeature Product Model
/// </summary>
[DataContract]
public class PremiumFeatureProductModel
{
	/// <summary>
	/// PremiumFeature Id
	/// </summary>
	[DataMember(Name = "premiumFeatureId", EmitDefaultValue = true, IsRequired = true)]
	public int PremiumFeatureId { get; set; }

	/// <summary>
	/// Mobile Product Id
	/// </summary>
	[DataMember(Name = "mobileProductId", EmitDefaultValue = true, IsRequired = true)]
	public string MobileProductId { get; set; }

	/// <summary>
	/// Robux Amount
	/// </summary>
	[DataMember(Name = "robuxAmount", EmitDefaultValue = true, IsRequired = true)]
	public long RobuxAmount { get; set; }

	/// <summary>
	/// PremiumFeature Type Name
	/// </summary>
	[DataMember(Name = "premiumFeatureType", EmitDefaultValue = true, IsRequired = true)]
	public PremiumFeatureType PremiumFeatureType { get; set; }

	/// <summary>
	/// Subscription Type Name
	/// </summary>
	[DataMember(Name = "subscriptionTypeName", EmitDefaultValue = true, IsRequired = true)]
	public string SubscriptionTypeName { get; set; }

	/// <summary>
	/// Is only for subscribed users
	/// </summary>
	[DataMember(Name = "isSubscriptionOnly", EmitDefaultValue = true, IsRequired = true)]
	public bool IsSubscriptionOnly { get; set; }

	/// <summary>
	/// Subscription Type Name
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = true, IsRequired = true)]
	public string Description { get; set; }
}
