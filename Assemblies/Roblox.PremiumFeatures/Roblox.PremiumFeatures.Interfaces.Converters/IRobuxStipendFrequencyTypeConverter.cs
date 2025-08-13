using Roblox.PremiumFeatures.Enums;

namespace Roblox.PremiumFeatures.Interfaces.Converters;

/// <summary>
/// Provides a common interface for an object that can convert a <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> into an ID.
/// </summary>
public interface IRobuxStipendFrequencyTypeConverter
{
	/// <summary>
	/// Gets the ID of a <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />
	/// </summary>
	/// <param name="robuxStipendFrequencyType">The <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />.</param>
	/// <returns>The ID of the <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" />.</returns>
	byte GetIdByType(RobuxStipendFrequencyType robuxStipendFrequencyType);

	/// <summary>
	/// Gets a <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> for the given ID, or null if no <see cref="T:Roblox.PremiumFeatures.Enums.RobuxStipendFrequencyType" /> is associated with the given ID.</returns>
	RobuxStipendFrequencyType? GetTypeById(byte id);
}
