using System;
using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <summary>
/// RobuxStipendModel
/// </summary>
public class RobuxStipendModel : IRobuxStipendModel
{
	/// <inheritdoc />
	public long ID { get; }

	/// <inheritdoc />
	public long AccountID { get; }

	/// <inheritdoc />
	public byte RobuxStipendQuantityTypeID { get; }

	/// <inheritdoc />
	public DateTime? LastAwarded { get; }

	/// <inheritdoc />
	public DateTime Expiration { get; }

	/// <inheritdoc />
	public byte? RobuxStipendFrequencyTypeID { get; }

	/// <inheritdoc />
	public DateTime? NextDistribution { get; }

	/// <summary>
	/// Construct new RobuxStipendModel
	/// </summary>
	/// <param name="id"></param>
	/// <param name="accountId"></param>
	/// <param name="robuxStipendQuantityTypeID"></param>
	/// <param name="lastAwarded"></param>
	/// <param name="expiration"></param>
	/// <param name="robuxStipendFrequencyTypeID"></param>
	/// <param name="nextDistribution"></param>
	public RobuxStipendModel(long id, long accountId, byte robuxStipendQuantityTypeID, DateTime? lastAwarded, DateTime expiration, byte? robuxStipendFrequencyTypeID, DateTime? nextDistribution)
	{
		ID = id;
		AccountID = accountId;
		RobuxStipendQuantityTypeID = robuxStipendQuantityTypeID;
		LastAwarded = lastAwarded;
		Expiration = expiration;
		RobuxStipendFrequencyTypeID = robuxStipendFrequencyTypeID;
		NextDistribution = nextDistribution;
	}
}
