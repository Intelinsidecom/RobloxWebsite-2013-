using System;

namespace Roblox.EventLog;

public static class StaticLoggerRegistry
{
	private static ILogger _Instance;

	public static ILogger Instance
	{
		get
		{
			return _Instance ?? throw new UninitializedLoggerException();
		}
		private set
		{
			_Instance = value;
		}
	}

	public static void SetLogger(ILogger logger)
	{
		Instance = logger ?? throw new ArgumentNullException("logger");
	}
}
