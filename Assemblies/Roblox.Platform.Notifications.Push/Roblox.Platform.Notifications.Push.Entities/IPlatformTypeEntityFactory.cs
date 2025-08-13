namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IPlatformTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IPlatformTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IPlatformTypeEntity" /> with the given ID, or null if none existed.</returns>
	IPlatformTypeEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Notifications.Push.Entities.IPlatformTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IPlatformTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IPlatformTypeEntity GetByValue(string value);
}
