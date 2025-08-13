using Roblox.PremiumFeatures.Models.Enums;
using Roblox.PremiumFeatures.Models.Responses;

namespace Roblox.Platform.PremiumFeatures.Interfaces;

/// <summary>
/// PremiumFeatures Product Interface
/// </summary>
public interface IPremiumFeaturesProduct
{
	/// <summary>
	/// Get PremiumFeatures Products
	/// </summary>
	/// <param name="userId"></param>
	/// <param name="ip"></param>
	/// <param name="premiumFeatureType"></param>
	/// <param name="isMobile"></param>
	/// <param name="platformType"></param>
	/// <returns></returns>
	PremiumFeaturesAvailableProductResponse GetPremiumFeaturesProducts(long userId, string ip, PremiumFeatureType premiumFeatureType, bool isMobile, PremiumFeaturesProductPlatformType platformType = PremiumFeaturesProductPlatformType.Default);
}
