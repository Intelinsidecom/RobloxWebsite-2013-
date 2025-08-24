using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeviceHandleLoginFloodChecker : FloodChecker
{
	public DeviceHandleLoginFloodChecker(ulong deviceHandleId)
		: base($"DeviceHandleFloodChecker_DeviceHandleID:{deviceHandleId}", Settings.Default.DeviceHandleLoginFloodCheckerLimit, Settings.Default.DeviceHandleLoginFloodCheckerExpiry)
	{
	}
}
