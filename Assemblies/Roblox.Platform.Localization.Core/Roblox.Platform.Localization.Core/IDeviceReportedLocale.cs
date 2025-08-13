namespace Roblox.Platform.Localization.Core;

/// <summary>
/// Represents a locale that was provided to roblox by a device/client by a user of the system.
/// Does not necessarily correspond to any Supported Locale that Roblox uses in the system
/// </summary>
public interface IDeviceReportedLocale
{
	/// <summary>
	/// ID of the Device Reported Locale
	/// </summary>
	IDeviceReportedLocaleIdentifier DeviceReportedLocaleId { get; }

	/// <summary>
	/// Standardized locale code. eg "en_us"
	/// </summary>
	string StandardizedLocale { get; }

	/// <summary>
	/// Language Family that the device reported locale is associated with. Can be null
	/// </summary>
	ILanguageFamily LanguageFamily { get; }

	/// <summary>
	/// Supported locale associated with locale. Can be null
	/// </summary>
	ISupportedLocale SupportedLocale { get; }
}
