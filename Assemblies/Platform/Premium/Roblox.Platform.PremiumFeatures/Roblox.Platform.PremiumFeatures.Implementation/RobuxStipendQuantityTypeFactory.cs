using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <inheritdoc />
public class RobuxStipendQuantityTypeFactory : IRobuxStipendQuantityTypeFactory
{
	/// <inheritdoc />
	public byte NoneId()
	{
		return RobuxStipendQuantityType.NoneID;
	}

	/// <inheritdoc />
	public byte FifteenId()
	{
		return RobuxStipendQuantityType.FifteenID;
	}

	/// <inheritdoc />
	public byte ThirtyFiveId()
	{
		return RobuxStipendQuantityType.ThirtyFiveID;
	}

	/// <inheritdoc />
	public byte SixtyId()
	{
		return RobuxStipendQuantityType.SixtyID;
	}

	/// <inheritdoc />
	public byte OneHundredId()
	{
		return RobuxStipendQuantityType.OneHundredID;
	}

	/// <inheritdoc />
	public IRobuxStipendQuantityTypeModel Get(byte id)
	{
		RobuxStipendQuantityType robuxStipendQuantityType = RobuxStipendQuantityType.Get(id);
		return EntityToModel(robuxStipendQuantityType);
	}

	private IRobuxStipendQuantityTypeModel EntityToModel(RobuxStipendQuantityType robuxStipendQuantityType)
	{
		if (robuxStipendQuantityType != null)
		{
			return new RobuxStipendQuantityTypeModel(robuxStipendQuantityType.ID, robuxStipendQuantityType.Amount);
		}
		return null;
	}
}
