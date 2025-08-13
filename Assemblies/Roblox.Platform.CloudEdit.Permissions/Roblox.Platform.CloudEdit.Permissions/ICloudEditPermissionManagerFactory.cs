using System.Collections.Generic;

namespace Roblox.Platform.CloudEdit.Permissions;

/// <summary>
/// Factory for constructing <see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager" />s
/// </summary>
public interface ICloudEditPermissionManagerFactory
{
	/// <summary>
	/// Creates an <see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager" /> for managing the supplied universe
	/// </summary>
	/// <param name="universeId">The universe Id.</param>
	/// <returns><see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager" /></returns>
	/// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown when universeId isn't valid, or an internal service fails.</exception>
	ICloudEditPermissionManager GetPermissionManagerForUniverse(long universeId);

	/// <summary>
	/// Create <see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager" /> for each universe
	/// </summary>
	/// <param name="universeIds">The ids of the universes</param>
	/// <returns><see cref="T:Roblox.Platform.CloudEdit.Permissions.ICloudEditPermissionManager" /></returns>
	/// /// <exception cref="T:Roblox.Platform.CloudEdit.Permissions.Exceptions.CloudEditPermissionsPlatformException">Thrown when universeId isn't valid, or an internal service fails.</exception>
	ICollection<ICloudEditPermissionManager> MultiGetPermissionManagersForUniverses(ICollection<long> universeIds);
}
