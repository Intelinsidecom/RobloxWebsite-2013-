using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;

namespace Roblox.FloodCheckers;

/// <summary>
/// Proxy to use one or another flood checker factory when invoking the GetFloodChecker method based on the value returned from
/// the userFloodCheckerFactory2 getter constructor parameter.
/// </summary>
public class FloodCheckerFactoryProxy : IFloodCheckerFactory<IFloodChecker>
{
	private readonly Func<IFloodCheckerFactory<IFloodChecker>> _FloodCheckerFactoryGetter;

	/// <summary>
	/// Initialize a new instance of the <see cref="T:Roblox.FloodCheckers.FloodCheckerFactoryProxy" />.
	/// </summary>
	/// <param name="floodCheckerFactory1"></param>
	/// <param name="floodCheckerFactory2"></param>
	/// <param name="useFloodCheckerFactory2">Getter to determine if floodCheckerFactory2 is used.</param>
	/// <exception cref="T:System.ArgumentNullException">Null argument.</exception>
	public FloodCheckerFactoryProxy(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory1, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory2, Func<bool> useFloodCheckerFactory2)
	{
		if (floodCheckerFactory1 == null)
		{
			throw new ArgumentNullException("floodCheckerFactory1");
		}
		if (floodCheckerFactory2 == null)
		{
			throw new ArgumentNullException("floodCheckerFactory2");
		}
		if (useFloodCheckerFactory2 == null)
		{
			throw new ArgumentNullException("useFloodCheckerFactory2");
		}
		_FloodCheckerFactoryGetter = () => (!useFloodCheckerFactory2()) ? floodCheckerFactory1 : floodCheckerFactory2;
	}

	/// <inheritdoc />
	public IFloodChecker GetFloodChecker(string category, string key, Func<int> getLimit, Func<TimeSpan> getWindowPeriod, Func<bool> isEnabled, Func<bool> recordGlobalFloodedEvents, ILogger logger)
	{
		return _FloodCheckerFactoryGetter().GetFloodChecker(category, key, getLimit, getWindowPeriod, isEnabled, recordGlobalFloodedEvents, logger);
	}
}
