using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class DeviceHandleUserActionFloodChecker : FloodChecker
{
	public DeviceHandleUserActionFloodChecker(ulong browserTrackerId)
		: base($"DeviceHandleFloodCheckerUserAction_BrowserTrackerID:{browserTrackerId}", Settings.Default.DeviceHandleUserActionFloodCheckLimit, Settings.Default.DeviceHandleUserActionFloodCheckExpiry, Settings.Default.DeviceHandleUserActionFloodCheckEnabled)
	{
	}

	public DeviceHandleUserActionFloodChecker(ulong browserTrackerId, string actionType, int limit, TimeSpan expiry, bool enabled)
		: base($"DeviceHandleFloodCheckerUserAction_{actionType}_BrowserTrackerID:{browserTrackerId}", limit, expiry, enabled, $"DeviceHandleFloodCheck_{actionType}")
	{
	}
}
