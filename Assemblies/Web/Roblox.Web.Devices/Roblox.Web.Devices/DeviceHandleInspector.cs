using Roblox.Platform.Devices;

namespace Roblox.Web.Devices;

/// <summary>
/// Wrapper for <see cref="T:Roblox.Platform.Devices.IDeviceHandleEncryptor" /> that determines whether to use the header or cookie values
/// extracted from a DeviceHandle
/// </summary>
public class DeviceHandleInspector : IDeviceHandleInspector
{
	private readonly IDeviceHandleEncryptor _DeviceHandleEncryptor;

	/// <summary>
	/// DeviceHandleInspector
	/// </summary>
	/// <param name="encryptor">The implementor of the actual DeviceHandle evaluation algorithm.</param>
	public DeviceHandleInspector(IDeviceHandleEncryptor encryptor)
	{
		_DeviceHandleEncryptor = encryptor;
	}

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
	public DeviceHandleInspectionResult ResolveDeviceHandleValidFromHeaderOrCookie(string headerValue, string cookieValue, ulong browserTrackerId, OperatingSystemType operatingSystem)
	{
		DeviceHandleInspectionResult inspectionResult = new DeviceHandleInspectionResult();
		string deviceHandleStr = headerValue;
		if (string.IsNullOrEmpty(deviceHandleStr))
		{
			deviceHandleStr = cookieValue;
			if (!string.IsNullOrEmpty(deviceHandleStr))
			{
				inspectionResult.SuppliedInCookie = true;
			}
		}
		else
		{
			inspectionResult.SuppliedInHeader = true;
		}
		return IsDeviceHandleValid(browserTrackerId, deviceHandleStr, operatingSystem, inspectionResult);
	}

	private DeviceHandleInspectionResult IsDeviceHandleValid(ulong browserTrackerId, string deviceHandle, OperatingSystemType operatingSystem, DeviceHandleInspectionResult inspectionResult)
	{
		inspectionResult.OperatingSystemType = operatingSystem;
		if (string.IsNullOrWhiteSpace(deviceHandle) || browserTrackerId == 0L)
		{
			return inspectionResult;
		}
		DeviceHandleEvaluationResult evaluationResult = _DeviceHandleEncryptor.IsValidDeviceHandleId(browserTrackerId, deviceHandle);
		inspectionResult.EvaluationResult = evaluationResult;
		return inspectionResult;
	}
}
