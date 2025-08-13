using System;

namespace Roblox.Instrumentation;

public static class StaticCounterRegistry
{
	public static ICounterRegistry Instance { get; }

	public static Action<Exception> ExceptionHandler { get; set; }

	static StaticCounterRegistry()
	{
		Instance = new CounterRegistry();
		new CounterReporter(Instance, HandleException).Start();
	}

	private static void HandleException(Exception ex)
	{
		try
		{
			ExceptionHandler?.Invoke(ex);
		}
		catch
		{
		}
	}
}
