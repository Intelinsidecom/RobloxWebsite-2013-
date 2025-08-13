using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers;

public class FloodCheckerFactory : IFloodCheckerFactory<IFloodChecker>
{
	public IFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
	{
		return new FloodChecker(category, key, getLimit(), getWindowPeriod(), isEnabled());
	}
}
