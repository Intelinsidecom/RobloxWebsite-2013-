namespace Roblox.Platform.Devices;

internal interface IApplicationTypeFactory
{
	/// <summary>
	/// Get the <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> for the specified ID value.
	/// </summary>
	/// <remarks>
	/// This method exists for resolving ApplicationType from other database tables. This ID should
	/// never appear outside of the implementation level.
	/// </remarks>
	/// <param name="id">The internal database ID of the ApplicationType.</param>
	/// <returns>An <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /></returns>
	ApplicationType GetById(byte id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> with the given value.
	/// </summary>
	/// <param name="value">The value of the ApplicationType.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Devices.IApplicationTypeEntity" /> with the given value.</returns>
	ApplicationType GetByValue(string value);
}
