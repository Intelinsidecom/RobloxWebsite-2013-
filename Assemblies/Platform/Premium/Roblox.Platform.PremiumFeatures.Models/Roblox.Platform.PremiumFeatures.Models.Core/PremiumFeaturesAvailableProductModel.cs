using System.Runtime.Serialization;

namespace Roblox.PremiumFeatures.Models.Core;

/// <summary>
/// Premium Feature Product
/// </summary>
[DataContract]
public class PremiumFeaturesAvailableProductModel
{
	/// <summary>
	/// Product Id
	/// </summary>
	[DataMember(Name = "productId", EmitDefaultValue = true, IsRequired = true)]
	public long ProductId { get; set; }

	/// <summary>
	/// Premium Feature Id
	/// </summary>
	[DataMember(Name = "premiumFeatureId", EmitDefaultValue = true, IsRequired = true)]
	public long PremiumFeatureId { get; set; }

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
	/// Premium Feature Type
	/// </summary>
	[DataMember(Name = "premiumFeatureTypeName", EmitDefaultValue = true, IsRequired = true)]
	public string PremiumFeatureTypeName { get; set; }

	/// <summary>
	///  Subscription Type
	/// </summary>
	[DataMember(Name = "subscriptionTypeName", EmitDefaultValue = false, IsRequired = false)]
	public string SubscriptionTypeName { get; set; }

	/// <summary>
	///  Subscription Type
	/// </summary>
	[DataMember(Name = "isSubscriptionOnly", EmitDefaultValue = true, IsRequired = true)]
	public bool IsSubscriptionOnly { get; set; }

	/// <summary>
	/// Localized price
	/// </summary>
	[DataMember(Name = "price", EmitDefaultValue = true, IsRequired = true)]
	public Money Price { get; set; }

	/// <summary>
	/// Description of the product
	/// </summary>
	[DataMember(Name = "description", EmitDefaultValue = true, IsRequired = true)]
	public string Description { get; set; }
}
