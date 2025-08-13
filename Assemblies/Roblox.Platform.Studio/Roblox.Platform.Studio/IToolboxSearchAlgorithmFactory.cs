using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

/// <summary>
/// Provides a common interface for factory class to get the IToolboxSearchAlgorithmFactory.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.IDomainFactory`1" />
public interface IToolboxSearchAlgorithmFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Creates an instance of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithm" />.
	/// </summary>
	/// <param name="algorithmName"></param>
	/// <param name="description"></param>
	/// <returns>Instance of type IToolboxSearchAlgorithmResult</returns>
	IToolboxSearchAlgorithm Create(string algorithmName, string description);

	/// <summary>
	/// Gets the collection of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithm" />.
	/// </summary>
	/// <param name="startRowIndex"></param>
	/// <param name="maxRows"></param>
	/// <returns>Collection of <seealso cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithm" /></returns>
	IEnumerable<IToolboxSearchAlgorithm> GetAllPaged(int startRowIndex, int maxRows);
}
