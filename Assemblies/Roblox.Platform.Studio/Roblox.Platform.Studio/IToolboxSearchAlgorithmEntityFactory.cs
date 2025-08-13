using System.Collections.Generic;
using Roblox.Platform.Core;

namespace Roblox.Platform.Studio;

internal interface IToolboxSearchAlgorithmEntityFactory : IDomainFactory<StudioDomainFactories>, IDomainObject<StudioDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" /> by its ID.
	/// </summary>
	/// <param name="name">Name of algorithm.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" /> with the given ID, or null if none existed.</returns>
	IToolboxSearchAlgorithmEntity Get(string name);

	/// <summary>
	/// Create an instance of <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" />
	/// </summary>
	/// <param name="name"></param>
	/// <param name="description"></param>
	/// <returns>Instance of <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" /></returns>
	IToolboxSearchAlgorithmEntity Create(string name, string description);

	/// <summary>
	/// Get collection of <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" /> by startRowIndex and max number of rows.
	/// </summary>
	/// <param name="startRowIndex"></param>
	/// <param name="maxRows"></param>
	/// <returns>IEnumerable of <see cref="T:Roblox.Platform.Studio.IToolboxSearchAlgorithmEntity" /></returns>
	IEnumerable<IToolboxSearchAlgorithmEntity> GetAllPaged(int startRowIndex, int maxRows);
}
