using System;
using System.Collections.Generic;
using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <summary>
/// RobuxStipendFactory
/// </summary>
public class RobuxStipendFactory : IRobuxStipendFactory
{
	/// <inheritdoc />
	public IRobuxStipendModel Get(long id)
	{
		RobuxStipend robuxStipend = RobuxStipend.Get(id);
		return EntityToModel(robuxStipend);
	}

	/// <inheritdoc />
	public ICollection<RobuxStipend> GetByAccountId(long accountId)
	{
		return RobuxStipend.GetByAccountId(accountId);
	}

	/// <inheritdoc />
	public ICollection<RobuxStipend> LeaseRobuxStipends(Guid workerId, int leaseDurationInMinutes, int numberOfItems)
	{
		return RobuxStipend.LeaseRobuxStipends(workerId, leaseDurationInMinutes, numberOfItems);
	}

	/// <inheritdoc />
	public RobuxStipend LeaseRobuxStipend(long id, Guid workerId, int leaseDurationInMinutes)
	{
		return RobuxStipend.LeaseRobuxStipend(id, workerId, leaseDurationInMinutes);
	}

	/// <inheritdoc />
	public IRobuxStipendModel UpdateRobuxStipend(RobuxStipend robuxStipend, byte? robuxStipendFrequencyTypeID, byte robuxStipendQuantityTypeID, DateTime? lastAwarded, DateTime? nextDistribution)
	{
		robuxStipend.RobuxStipendFrequencyTypeID = robuxStipendFrequencyTypeID;
		robuxStipend.RobuxStipendQuantityTypeID = robuxStipendQuantityTypeID;
		robuxStipend.LastAwarded = lastAwarded;
		robuxStipend.NextDistribution = nextDistribution;
		robuxStipend.Save();
		return EntityToModel(robuxStipend);
	}

	private IRobuxStipendModel EntityToModel(RobuxStipend robuxStipend)
	{
		if (robuxStipend != null)
		{
			return new RobuxStipendModel(robuxStipend.ID, robuxStipend.AccountID, robuxStipend.RobuxStipendQuantityTypeID, robuxStipend.LastAwarded, robuxStipend.Expiration, robuxStipend.RobuxStipendFrequencyTypeID, robuxStipend.NextDistribution);
		}
		return null;
	}
}
