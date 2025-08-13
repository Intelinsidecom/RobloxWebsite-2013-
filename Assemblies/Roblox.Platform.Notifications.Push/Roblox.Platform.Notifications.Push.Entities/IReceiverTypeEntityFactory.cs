namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IReceiverTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> with the given ID, or null if none existed.</returns>
	IReceiverTypeEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IReceiverTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Add other params.
	/// TODO: Add exceptions.
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverTypeEntity" /> with the given TODO: Fill in characterisics.</returns>
	IReceiverTypeEntity GetOrCreate(string value);
}
