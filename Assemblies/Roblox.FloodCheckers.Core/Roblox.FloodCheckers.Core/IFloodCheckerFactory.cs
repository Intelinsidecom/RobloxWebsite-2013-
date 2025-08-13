using System;
using Roblox.EventLog;

namespace Roblox.FloodCheckers.Core;

/// <summary>
/// Factory to construct and return a new floodchecker
/// </summary>
public interface IFloodCheckerFactory<out TFloodChecker> where TFloodChecker : IBasicFloodChecker
{
	TFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger);
}
