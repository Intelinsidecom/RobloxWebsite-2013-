namespace Roblox.Platform.Marketing;

/// <summary>
/// Provides common interface for an object that defines SponsoredPageDeviceType.
/// </summary>
public interface ISponsoredPageDeviceType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	int Id { get; }

	/// <summary>
	/// Gets or sets the sponsored page identifier.
	/// </summary>
	/// <value>
	/// The sponsored page identifier.
	/// </value>
	int SponsoredPageId { get; set; }

	/// <summary>
	/// Gets or sets the device types.
	/// </summary>
	/// <value>
	/// The device types.
	/// </value>
	long DeviceTypesBitMask { get; set; }

	/// <summary>
	/// Saves underlying entity of SponsoredPageDeviceType to database.
	/// </summary>
	void Save();

	/// <summary>
	/// Deletes underlying entity of SponsoredPageDeviceType from database.
	/// </summary>
	void Delete();
}
