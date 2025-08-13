using System.Collections.Generic;

namespace Roblox.Platform.AbTesting.Core;

public interface IExperimentCreator
{
	/// <summary>
	/// Creates a new <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" />.
	/// </summary>
	/// <param name="name">The name of the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to create.</param>
	/// <param name="numberOfVariations">The number of variations for the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to have.</param>
	/// <param name="isExclusive">Whether or not the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> is exclusive.</param>
	/// <param name="eligibilityCriteria">The eligility criteria for the experiment.</param>
	/// <returns>Returns the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> that was created.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="name" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="eligibilityCriteria" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="name" /> is white space.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="numberOfVariations" /> is less than or equal to 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="eligibilityCriteria" /> contains a null element.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if an experiment with the given name already exists.</exception>
	IExperiment Create(string name, byte numberOfVariations, bool isExclusive, IEnumerable<IEligibilityCriterionType> eligibilityCriteria);
}
