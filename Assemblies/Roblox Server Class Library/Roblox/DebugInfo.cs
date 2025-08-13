using System;
using Roblox.EventLog;
using Roblox.Properties;

namespace Roblox;

public class DebugInfo
{
	public static void Log(string message)
	{
		if (Settings.Default.IsUserEntityDebugInfoLoggingEnabled)
		{
			ExceptionHandler.LogException($"{message}\nStackTrace:{Environment.StackTrace}", LogLevel.Warning);
		}
	}
}
