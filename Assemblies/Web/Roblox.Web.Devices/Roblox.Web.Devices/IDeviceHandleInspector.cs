using Roblox.Platform.Devices;

namespace Roblox.Web.Devices;

/// <summary>
/// Wrapper for <see cref="T:Roblox.Platform.Devices.IDeviceHandleEncryptor" /> that determines whether to use the header or cookie values
/// extracted from a DeviceHandle
/// </summary>
public interface IDeviceHandleInspector
{
	/// <summary>
	/// Populates and returns a <see cref="T:Roblox.Web.Devices.DeviceHandleInspectionResult" /> by comparing the <paramref name="browserTrackerId" />
	/// against the DeviceHandle header and cookie values extracted from a request.
	/// </summary>
	/// <remarks>
	/// This method will evaluate the header if it is not null, otherwise it will evaluate the cookie if it is likewise not null, but it will
	/// not evaluate both.
	/// </remarks>
	/// <param name="headerValue">The encrypted DeviceHandle value if available from the DeviceHandle header (null if not provided)</param>
	/// <param name="cookieValue">The encrypted DeviceHandle value if available from the DeviceHandle cookie (null if not provided)</param>
	/// <param name="browserTrackerId">Unique identifier for a device included in every request.</param>
	/// <param name="operatingSystem"></param>
	/// <returns></returns>
	DeviceHandleInspectionResult ResolveDeviceHandleValidFromHeaderOrCookie(string headerValue, string cookieValue, ulong browserTrackerId, OperatingSystemType operatingSystem);
}
