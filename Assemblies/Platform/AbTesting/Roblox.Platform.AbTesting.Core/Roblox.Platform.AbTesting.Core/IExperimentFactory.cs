using System.Collections.Generic;

namespace Roblox.Platform.AbTesting.Core;

public interface IExperimentFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> with the given ID, or null if none existed.</returns>
	IExperiment GetById(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> by its name.
	/// </summary>
	/// <param name="name">The name of the <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" /> with the given name, or null if none existed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="name" /> is null.</exception>
	IExperiment GetByName(string name);

	/// <summary>
	/// Gets all existing <see cref="T:Roblox.Platform.AbTesting.Core.IExperiment" />s.
	/// </summary>
	/// <returns>All existing experiments.</returns>
	IEnumerable<IExperiment> GetAllExperiments();
}
