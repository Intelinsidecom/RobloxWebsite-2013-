using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <inheritdoc />
public class RobuxStipendQuantityTypeModel : IRobuxStipendQuantityTypeModel
{
	/// <inheritdoc />
	public byte Id { get; }

	/// <inheritdoc />
	public long Amount { get; }

	/// <inheritdoc />
	public RobuxStipendQuantityTypeModel(byte id, long amount)
	{
		Id = id;
		Amount = amount;
	}
}
