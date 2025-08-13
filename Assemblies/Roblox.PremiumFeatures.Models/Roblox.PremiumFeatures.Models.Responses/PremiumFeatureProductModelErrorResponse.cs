using System.Runtime.Serialization;
using Roblox.PremiumFeatures.Models.Enums;

namespace Roblox.PremiumFeatures.Models.Responses;

/// <summary>
/// Error response model for PremiumFeatureProductModel
/// </summary>
[DataContract]
public class PremiumFeatureProductModelErrorResponse : PremiumFeatureProductModelResponse
{
	/// <summary>
	/// Error Code. see <see cref="T:Roblox.PremiumFeatures.Models.Enums.PremiumFeaturesErrorCode" />
	/// </summary>
	[DataMember(Name = "errorCode", EmitDefaultValue = false, IsRequired = false)]
	public PremiumFeaturesErrorCode ErrorCode { get; set; }

	/// <summary>
	/// Template string error message. For internal use. Use code to render an appropriate message depending on UI.
	/// </summary>
	[DataMember(Name = "errorMessage", EmitDefaultValue = false, IsRequired = false)]
	public string ErrorMessage { get; set; }
}
