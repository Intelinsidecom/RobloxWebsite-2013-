using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeviceHandleSuccessfulLoginFloodChecker : FloodChecker
{
	public DeviceHandleSuccessfulLoginFloodChecker(ulong deviceHandleId)
		: base($"DeviceHandleSuccessfulLoginFloodChecker_DeviceHandleID:{deviceHandleId}", Settings.Default.DeviceHandleSuccessfulLoginFloodCheckerLimit, Settings.Default.DeviceHandleSuccessfulLoginFloodCheckerExpiry)
	{
	}
}
