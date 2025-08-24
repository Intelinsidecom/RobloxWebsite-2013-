namespace Roblox.Platform.Devices;

internal interface IApplicationTypeEntityFactory
{
	/// <summary>
	/// Get the <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> for the specified ID value.
	/// </summary>
	/// <param name="id">The internal database ID of the ApplicationType.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /></returns>
	IApplicationTypeEntity GetById(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the ApplicationType.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> with the given value.</returns>
	IApplicationTypeEntity GetByValue(string value);
}
