namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IApplicationTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> with the given ID, or null if none existed.</returns>
	IApplicationTypeEntity Get(int id);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Add other params.
	/// TODO: Add exceptions.
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> with the given TODO: Fill in characterisics.</returns>
	IApplicationTypeEntity GetOrCreate(string value);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IApplicationTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IApplicationTypeEntity GetByValue(string value);
}
