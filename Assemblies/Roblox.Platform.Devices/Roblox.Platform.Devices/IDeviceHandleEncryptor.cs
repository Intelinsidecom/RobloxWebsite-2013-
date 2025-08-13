namespace Roblox.Platform.Devices;

public interface IDeviceHandleEncryptor
{
	/// <summary>
	/// Check if the encrypted device handle id is the same as the device handle id.
	/// </summary>
	/// <param name="encryptedDeviceHandleId">The encrypted handle of the device.</param>
	/// <param name="deviceHandleId">The value used to identify a device</param>
	/// <returns>If the handle matches the encrypted device handle.</returns>
	DeviceHandleEvaluationResult IsValidDeviceHandleId(ulong deviceHandleId, string encryptedDeviceHandleId);

	/// <summary>
	/// Gets the encrypted DeviceHandle
	/// </summary>
	/// <param name="browserTrackerId">Browser Tracker Id to encrypt</param>
	/// <returns></returns>
	string GetDeviceHandle(ulong browserTrackerId);
}
