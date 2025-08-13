using System;
using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class ParentsVerifyInfoFloodChecker : FloodChecker
{
	public ParentsVerifyInfoFloodChecker(long userId, string ipAddress)
		: base($"ParentsVerifyInfoFloodChecker_UserID:{userId}_IPAddress:{ipAddress}", Settings.Default.ParentsVerifyInfoFloodCheckLimit, TimeSpan.FromHours(Settings.Default.ParentsVerifyInfoFloodCheckTimeLimit))
	{
	}
}
