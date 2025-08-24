using System.Collections.Generic;

namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Privides a common interface for producing <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" />s.
/// </summary>
public interface IEligibilityCriterionTypeFactory
{
	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" />s.
	/// </summary>
	/// <returns></returns>
	IEnumerable<IEligibilityCriterionType> GetAllEligibilityCriterionTypes();

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" /> with the given ID, or null if none existed.</returns>
	IEligibilityCriterionType GetById(int id);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" />s with the given experiment ID.
	/// </summary>
	/// <param name="experimentId">The experiment ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" />s to get.</param>
	/// <returns>All <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCriterionType" />s with the given experiment ID.</returns>
	IEnumerable<IEligibilityCriterionType> GetByExperimentId(int experimentId);
}
