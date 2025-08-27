using System.Collections.Generic;
using System.Runtime.Serialization;
using Roblox.Platform.PremiumFeatures.Models.Core;
using Roblox.Platform.PremiumFeatures.Models.Enums;
namespace Roblox.Platform.PremiumFeatures.Models.Requests {
    [DataContract]

public class PremiumFeatureProductDetailRequest
{
	[DataMember(Name = "premiumFeatureProducts", EmitDefaultValue = false, IsRequired = true)]
	public ICollection<PremiumFeatureProductModel> PremiumFeatureProducts { get; set; }

	[DataMember(Name = "countryId", EmitDefaultValue = true, IsRequired = true)]
	public int CountryId { get; set; }

	[DataMember(Name = "isMobile", EmitDefaultValue = true, IsRequired = true)]
	public bool IsMobile { get; set; }

	[DataMember(Name = "accountId", EmitDefaultValue = true, IsRequired = false)]
	public long AccountId { get; set; }

	[DataMember(Name = "platformType", EmitDefaultValue = true, IsRequired = false)]
	public PremiumFeaturesProductPlatformType PlatformType { get; set; }
}


}
