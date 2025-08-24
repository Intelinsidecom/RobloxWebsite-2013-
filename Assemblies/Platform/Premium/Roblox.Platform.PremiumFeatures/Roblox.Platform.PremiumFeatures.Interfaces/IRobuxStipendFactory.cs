using System;
using System.Collections.Generic;

namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// IRobuxStipendFactory interface
/// </summary>
public interface IRobuxStipendFactory
{
	/// <summary>
	/// Get a RobuxStipendModel
	/// </summary>
	/// <param name="id">RobuxStipend ID</param>
	/// <returns></returns>
	IRobuxStipendModel Get(long id);

	/// <summary>
	/// Get a collection of RobuxStipend by accountId
	/// </summary>
	/// <param name="accountId">account id</param>
	/// <returns></returns>
	ICollection<RobuxStipend> GetByAccountId(long accountId);

	/// <summary>
	/// Lease numberOfItems numbers of RobuxStipend, update workerId, set leaseDurationInMinutes
	/// </summary>
	/// <param name="workerId">Guid</param>
	/// <param name="leaseDurationInMinutes">lease duration in minutes</param>
	/// <param name="numberOfItems">numberOfItems</param>
	/// <returns></returns>
	ICollection<RobuxStipend> LeaseRobuxStipends(Guid workerId, int leaseDurationInMinutes, int numberOfItems);

	/// <summary>
	/// Lease a single RobuxStipend by its ID.
	/// </summary>
	/// <param name="id">RobuxStipend ID</param>
	/// <param name="workerId">Guid</param>
	/// <param name="leaseDurationInMinutes">lease duration in minutes</param>
	/// <returns></returns>
	RobuxStipend LeaseRobuxStipend(long id, Guid workerId, int leaseDurationInMinutes);

	/// <summary>
	/// Update RobuxStipend with values.
	/// </summary>
	/// <param name="robuxStipend">robuxStipend to be updated</param>
	/// <param name="robuxStipendFrequencyTypeID">robuxStipendFrequencyTypeID</param>
	/// <param name="robuxStipendQuantityTypeID">robuxStipendQuantityTypeID</param>
	/// <param name="lastAwarded">lastAwarded datetime</param>
	/// <param name="nextDistribution">nextDistribution datetime</param>
	/// <returns></returns>
	IRobuxStipendModel UpdateRobuxStipend(RobuxStipend robuxStipend, byte? robuxStipendFrequencyTypeID, byte robuxStipendQuantityTypeID, DateTime? lastAwarded, DateTime? nextDistribution);
}
