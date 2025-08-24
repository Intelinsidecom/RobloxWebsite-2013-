using Roblox.PremiumFeatures.Interfaces.Entities;

namespace Roblox.PremiumFeatures.Interfaces.EntityFactories;

/// <summary>
/// The Entity Factory for <see cref="T:Roblox.PremiumFeatures.Interfaces.Entities.IRobuxStipendFrequencyTypeEntity" />
/// </summary>
public interface IRobuxStipendFrequencyTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.PremiumFeatures.Interfaces.Entities.IRobuxStipendFrequencyTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.Interfaces.Entities.IRobuxStipendFrequencyTypeEntity" /> with the given ID, or null if none existed.</returns>
	IRobuxStipendFrequencyTypeEntity Get(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.PremiumFeatures.Interfaces.Entities.IRobuxStipendFrequencyTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value.</param>
	/// <returns>The <see cref="T:Roblox.PremiumFeatures.Interfaces.Entities.IRobuxStipendFrequencyTypeEntity" /> with the given value, or null if none existed.</returns>
	IRobuxStipendFrequencyTypeEntity GetByValue(string value);
}
