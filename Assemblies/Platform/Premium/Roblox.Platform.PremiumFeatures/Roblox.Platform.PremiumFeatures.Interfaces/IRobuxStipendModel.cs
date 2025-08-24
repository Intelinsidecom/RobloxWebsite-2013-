using System;

namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// IRobuxStipendModel interface
/// </summary>
public interface IRobuxStipendModel
{
	/// <summary>
	/// RobuxStipend ID
	/// </summary>
	long ID { get; }

	/// <summary>
	/// AccountID
	/// </summary>
	long AccountID { get; }

	/// <summary>
	/// RobuxStipendQuantityTypeID
	/// </summary>
	byte RobuxStipendQuantityTypeID { get; }

	/// <summary>
	/// LastAwarded DateTime
	/// </summary>
	DateTime? LastAwarded { get; }

	/// <summary>
	/// Expiration DateTime
	/// </summary>
	DateTime Expiration { get; }

	/// <summary>
	/// RobuxStipendFrequencyTypeID
	/// </summary>
	byte? RobuxStipendFrequencyTypeID { get; }

	/// <summary>
	/// NextDistribution DateTime
	/// </summary>
	DateTime? NextDistribution { get; }
}
