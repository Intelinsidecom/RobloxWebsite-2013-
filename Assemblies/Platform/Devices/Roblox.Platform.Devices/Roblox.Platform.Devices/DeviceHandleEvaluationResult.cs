namespace Roblox.Platform.Devices;

/// <summary>
/// Contains the results of a DeviceHandle comparison out so that a
/// consumer may record per-device statistics
/// </summary>
public class DeviceHandleEvaluationResult
{
	/// <summary>
	/// Whether or not the DeviceHandle evaluator determined that the provided DeviceHandle was valid.
	/// </summary>
	public bool IsValid { get; set; }

	/// <summary>
	/// Which version of DeviceHandle with which key was used to evaluate it. Null if the DeviceHandle was invalid.
	/// <see cref="T:Roblox.Platform.Devices.DeviceHandleEvaluationType" />
	/// </summary>
	public DeviceHandleEvaluationType? EvaluationType { get; set; }

	/// <summary>
	/// The criterion on which the DeviceHandle check failed. Null if IsValid is true.
	/// <see cref="T:Roblox.Platform.Devices.DeviceHandleFailureReason" />
	/// </summary>
	public DeviceHandleFailureReason? FailureReason { get; set; }
}
