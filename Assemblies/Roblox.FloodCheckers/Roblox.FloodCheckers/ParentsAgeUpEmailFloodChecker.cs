using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ParentsAgeUpEmailFloodChecker : FloodChecker
{
	public ParentsAgeUpEmailFloodChecker(long userId, string ipAddress)
		: base($"ParentsAgeUpEmailFloodChecker_UserID:{userId}_IPAddress:{ipAddress}", Settings.Default.ParentsAgeUpEmailFloodCheckLimit, TimeSpan.FromHours(Settings.Default.ParentsAgeUpEmailFloodCheckExpiry))
	{
	}
}
