using System.Collections.Generic;

namespace Roblox.Platform.AbTesting.Core;

public interface IVersionFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> by its ID.
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> today.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> with the given ID, or null of none existed.</returns>
	IVersion GetById(int id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> by its ID and version number.
	/// </summary>
	/// <param name="experimentId">The experiment ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> to get.</param>
	/// <param name="versionNumber">The version number of the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" /> with the given experiment ID and version number, or null if none existed.</returns>
	IVersion GetByExperimentIdAndVersionNumber(int experimentId, byte versionNumber);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s by whether or not they're active.
	/// </summary>
	/// <param name="isActive">True to get active versions. False to get inactive versions.</param>
	/// <param name="startRow">The zero-indexed row to begin getting <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s at.</param>
	/// <param name="maxRows">The maximum number of <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s to get.</param>
	/// <returns>The page of <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s.</returns>
	IEnumerable<IVersion> GetByIsActive(bool isActive, int startRow, int maxRows);

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s where <see cref="P:Roblox.Platform.AbTesting.Core.IVersion.IsActive" /> is true.
	/// </summary>
	/// <returns>All <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s where <see cref="P:Roblox.Platform.AbTesting.Core.IVersion.IsActive" /> is true.</returns>
	IEnumerable<IVersion> GetAllActiveVersions();

	/// <summary>
	/// Gets all <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />s for the given experimentId.
	/// </summary>
	IEnumerable<IVersion> GetByExperimentId(int experimentId);
}
