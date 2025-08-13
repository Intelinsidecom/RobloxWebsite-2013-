using System.Collections.Generic;
using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Core;

namespace Roblox.PremiumFeatures.Models.Responses;

/// <summary>
/// Response model for PremiumFeature Products
/// </summary>
[DataContract]
public class PremiumFeatureProductModelResponse
{
	/// <summary>
	/// PremiumFeature products
	/// </summary>
	[DataMember(Name = "premiumFeatureProducts", EmitDefaultValue = true, IsRequired = true)]
	public ICollection<PremiumFeatureProductModel> PremiumFeatureProducts { get; set; }
}
