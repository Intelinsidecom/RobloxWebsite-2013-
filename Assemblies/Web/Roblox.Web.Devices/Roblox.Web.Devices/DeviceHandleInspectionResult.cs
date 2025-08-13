using Roblox.Platform.Devices;

namespace Roblox.Web.Devices;

/// <summary>
/// Contains information about how DeviceHandle was extracted from a request in addition to
/// the result of the cryptographic evaluation.
/// </summary>
public class DeviceHandleInspectionResult
{
	/// <summary>
	/// Operating system type of the requestor for which DeviceHandle was evaluated.
	/// </summary>
	public OperatingSystemType OperatingSystemType { get; set; }

	/// <summary>
	/// Device handle was supplied in the header.
	/// </summary>
	public bool SuppliedInHeader { get; set; }

	/// <summary>
	/// Device handle was supplied as a cookie
	/// </summary>
	public bool SuppliedInCookie { get; set; }

	/// <summary>
	/// The result of the IDeviceHandleEncryptor's evaluation of the DeviceHandle
	/// </summary>
	public DeviceHandleEvaluationResult EvaluationResult { get; set; }
}
