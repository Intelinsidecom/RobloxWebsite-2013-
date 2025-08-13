using Roblox.Entities;

namespace Roblox.PremiumFeatures.Interfaces.Entities;

/// <summary>
/// An interface for the <see cref="T:Roblox.PremiumFeatures.Entities.RobuxStipendFrequencyTypeEntity" />
/// </summary>
public interface IRobuxStipendFrequencyTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	/// <summary>
	/// The value of the <see cref="T:Roblox.PremiumFeatures.Entities.RobuxStipendFrequencyTypeEntity" />
	/// </summary>
	string Value { get; set; }
}
