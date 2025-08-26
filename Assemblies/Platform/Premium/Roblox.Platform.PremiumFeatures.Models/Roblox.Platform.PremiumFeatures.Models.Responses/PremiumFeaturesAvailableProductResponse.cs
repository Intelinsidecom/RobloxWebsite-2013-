using System.Collections.Generic;
using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Core;
namespace Roblox.Platform.PremiumFeatures.Models.Responses {
    /// <summary>

/// Response model for PremiumFeature available products
/// </summary>
[DataContract]
public class PremiumFeaturesAvailableProductResponse
{
	/// <summary>
	/// List of Products
	/// </summary>
	[DataMember(Name = "products", EmitDefaultValue = false, IsRequired = false)]
	public ICollection<PremiumFeaturesAvailableProductModel> Products { get; set; }
}


}
