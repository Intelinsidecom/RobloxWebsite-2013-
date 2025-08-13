using System;

namespace Roblox.FloodCheckers.Redis;

public interface ISettings
{
	string FloodCheckerRedisEndpointsCsv { get; }

	TimeSpan FloodCheckerMinimumWindowPeriod { get; }
}
