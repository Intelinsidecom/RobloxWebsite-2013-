namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IAuthenticationTypeEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAuthenticationTypeEntity Get(int id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Fill in params
	/// TODO: Fill in exceptions
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> with the given TODO: Fill in characteristics, or null if none existed.</returns>
	IAuthenticationTypeEntity GetByValue(string value);

	/// <summary>
	/// Gets or creates an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> with the given TODO: Fill in characteristics.
	/// </summary>
	/// TODO: Add other params.
	/// TODO: Add exceptions.
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IAuthenticationTypeEntity" /> with the given TODO: Fill in characterisics.</returns>
	IAuthenticationTypeEntity GetOrCreate(string value);
}
