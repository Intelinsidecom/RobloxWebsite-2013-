namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// Provides a common interface for an object that can convert a <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> into an ID.
/// </summary>
public interface IBCMembershipToPremiumConverter
{
	/// <summary>
	/// Gets the ID of a <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />
	/// </summary>
	/// <param name="robuxStipendFrequencyType">The <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />.</param>
	/// <returns>The ID of the <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />.</returns>
	IPremiumFeatureModel MapBCToPremiumProduct(IPremiumFeatureModel bcPremiumFeature);
}
