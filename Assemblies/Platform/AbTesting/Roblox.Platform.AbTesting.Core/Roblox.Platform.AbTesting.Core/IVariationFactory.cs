using System.Collections.Generic;

namespace Roblox.Platform.AbTesting.Core;

public interface IVariationFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /> with the given ID, or null if none existed.</returns>
	IVariation GetById(int id);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" />s with the given experiment ID and version number.
	/// </summary>
	/// <param name="experimentId">The experiment ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" />s to get.</param>
	/// <param name="versionNumber">The version number of the <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" />s to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" />s with the given experiment ID and version number.</returns>
	IEnumerable<IVariation> GetByExperimentIdAndVersionNumber(int experimentId, byte versionNumber);
}
