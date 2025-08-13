using System.Collections.Generic;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IDestinationTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" /> with the given ID, or null if none existed.</returns>
	IDestinationTypeEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IDestinationTypeEntity GetByApplicationTypeIdAndPlatformTypeId(int applicationTypeId, int platformTypeId);

	/// <summary>
	/// Gets a page of <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" />s by their TODO: Fill in.
	/// </summary>
	/// TODO: Add params
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// TODO: Add other exceptions
	/// <returns>The page of <see cref="T:Roblox.Platform.Notifications.Push.Entities.IDestinationTypeEntity" />s.</returns>
	IEnumerable<IDestinationTypeEntity> GetByApplicationTypeIdPaged(int applicationTypeId, int startRowIndex, int maxRows);

	IDestinationTypeEntity Create(int applicationTypeId, int platformTypeId, string registrationEndpoint);
}
