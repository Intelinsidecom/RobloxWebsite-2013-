using System;

namespace Roblox.EventLog;

public class ConsoleLogger : LoggerBase
{
	public ConsoleLogger(Func<LogLevel> maxLogLevel, bool logThreadId = false)
	{
		base.MaxLogLevel = maxLogLevel;
		base.LogThreadID = logThreadId;
	}

	protected override void Log(LogLevel logLevel, string format, params object[] args)
	{
		string arg = ((args != null && args.Length != 0) ? string.Format(format, args) : format);
		Console.WriteLine($"{DateTime.Now} - {logLevel} - {arg}");
	}
}
