using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Roblox.EventLog.Windows;

/// <summary>
/// The Logger class implements the ILogger interface for the WindowsEventLog
///
/// Each instance must be bound to an existing local event source. Log messages will be
/// written using the EventLogEntryType matching the LogLevel enum. Supported log levels
/// are: Debug, Verbose, Information, Warning and Error. 
///
/// The Debug log level is the same as Information, but will be ignored in Release builds.
///
/// The Verbose log level allows verbose Information messages to be logged. This is designed
/// to allow production debugging by dynamically changing the log level temporarily to verbose
///
/// There is also a None log level that can be used to create dummy/mock loggers that
/// don't write anything.
///
/// The Logger class is designed not to cause problems for the calling code and never to 
/// throw exceptions. If for some reason logging doesn't work (bad format string, misconfiguration, 
/// permissions, out of space, etc) then it will try to log this logging failure to the current source 
/// first and then to the "Application" log. IF everything fails it will just eat the exception quietly.
///
/// Logger also supports writing to the console in addition to the event log via the LogToConsole
/// property (false by default)
///
/// Logger can also log some additional information as a prefix to each message. The additional
/// information is control by the LogThreadID, LogMethodName and LogClassAndMethodName properties.
/// </summary>
public class Logger : LoggerBase
{
	private const int _MaximumEventLogMessageSize = 30000;

	private readonly string _Source;

	private readonly Func<bool> _MonitorLogPerformance;

	private readonly bool _SourceExists;

	/// <summary>
	/// Configures whether this Logger logs to console in addition to Windows Event Log
	/// </summary>
	public bool LogToConsole { get; set; }

	/// <summary>
	/// Main constructor
	///
	/// If the event source doesn't exist. Return a dummy logger with None log level
	/// that will not log anything, but the application may safely call its methods.
	///
	/// Also write a warning to the Application log (always there), the Roblox
	/// log (probably there) and the console (maybe there)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorLogPerformance">should performance metrics be monitored for the specified source</param>
	public Logger(string source, Func<LogLevel> maxLogLevel, Func<bool> monitorLogPerformance, bool logThreadId = false)
	{
		_SourceExists = System.Diagnostics.EventLog.SourceExists(source);
		base.MaxLogLevel = maxLogLevel;
		if (!_SourceExists)
		{
			string message = $"EventLog source: {source}. Doesn't exist. There will be no logging";
			WriteEventLogEntry("Roblox", message, EventLogEntryType.Warning, () => false);
			WriteEventLogEntry("Application", message, EventLogEntryType.Warning, () => false);
			Console.WriteLine(message);
		}
		else
		{
			_Source = source;
			base.LogThreadID = logThreadId;
			_MonitorLogPerformance = monitorLogPerformance;
		}
	}

	/// <summary>
	/// Main constructor
	///
	/// If the event source doesn't exist. Return a dummy logger with None log level
	/// that will not log anything, but the application may safely call its methods.
	///
	/// Also write a warning to the Application log (always there), the Roblox
	/// log (probably there) and the console (maybe there)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public Logger(string source, Func<LogLevel> maxLogLevel, bool logThreadId = false)
		: this(source, maxLogLevel, () => false, logThreadId)
	{
	}

	/// <summary>
	/// Convenient string-based constructor
	///
	/// This constructor takes a delegate that returns the max log level as a string
	/// that corresponds to the LogLEvel enum values. This is less type-safe (you could
	/// pass invalid value), but more convenient in case you manage the log level
	/// via the configuration DBs.
	///
	/// Let the main constructor do the heavy lifting
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevelGetter">maximal log level (default to Warning if not parsable)</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorLogPerformance">should monitor performance metrics for specified source</param>
	public Logger(string source, Func<string> maxLogLevelGetter, Func<bool> monitorLogPerformance, bool logThreadId = false)
		: this(source, () => ParseLogLevel(maxLogLevelGetter()), monitorLogPerformance, logThreadId)
	{
	}

	/// <summary>
	/// Convenient string-based constructor
	///
	/// This constructor takes a delegate that returns the max log level as a string
	/// that corresponds to the LogLEvel enum values. This is less type-safe (you could
	/// pass invalid value), but more convenient in case you manage the log level
	/// via the configuration DBs.
	///
	/// Let the main constructor do the heavy lifting
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevelGetter">maximal log level (default to Warning if not parsable)</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public Logger(string source, Func<string> maxLogLevelGetter, bool logThreadId = false)
		: this(source, () => ParseLogLevel(maxLogLevelGetter()), () => false, logThreadId)
	{
	}

	/// <summary>
	/// Create a Logger instance
	///
	/// This constructor uses a fixed log level. Used for backward compatibility.
	/// Ok for tests. Not recommended for production code because you can't dynamically
	/// change its log level.
	///
	/// Let the main constructor do the heavy lifting
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">fixed maximal log level (defaults to Information)</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public Logger(string source, LogLevel maxLogLevel = LogLevel.Information, bool logThreadId = false)
		: this(source, () => maxLogLevel, () => false, logThreadId)
	{
	}

	/// <summary>
	/// Create a Logger instance
	///
	/// This constructor uses a fixed log level. Used for backward compatibility.
	/// Ok for tests. Not recommended for production code because you can't dynamically
	/// change its log level.
	///
	/// Let the main constructor do the heavy lifting
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="maxLogLevel">fixed maximal log level (defaults to Information)</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorLogPerformance">should monitor performance metrics for specified source</param>
	public Logger(string source, Func<bool> monitorLogPerformance, LogLevel maxLogLevel = LogLevel.Information, bool logThreadId = false)
		: this(source, () => maxLogLevel, monitorLogPerformance, logThreadId)
	{
	}

	/// <summary>
	/// method that actually logs the message with the appropriate entry type
	///
	/// Used by the interface methods: Debug(), Info(), Warning(), Error() and Verbose()
	/// </summary>
	/// <param name="logLevel">the log level</param>
	/// <param name="format">the message format string (or the message itself if no args)</param>
	/// <param name="args">the arguments to format the final message</param>
	protected override void Log(LogLevel logLevel, string format, params object[] args)
	{
		if (!_SourceExists)
		{
			return;
		}
		EventLogEntryType entryType = GetEventLogEntryTypeByLogLevel(logLevel);
		try
		{
			string message2 = ((args == null || args.Length == 0) ? format : string.Format(format, args));
			string prefix = GetPrefix(logLevel);
			if (LogToConsole)
			{
				Console.WriteLine("[{0}] {1}", entryType, prefix + message2);
			}
			WriteEventLogEntry(_Source, prefix + message2, entryType, _MonitorLogPerformance);
		}
		catch (Exception ex)
		{
			string message = string.Empty;
			try
			{
				List<string> environmentStackTrace = SplitToLines(Environment.StackTrace).Skip(3).ToList();
				string[] exceptionStackTrace = SplitToLines(ex.StackTrace);
				IEnumerable<string> lines = new string[1] { ex.Message }.Concat(exceptionStackTrace).Concat(environmentStackTrace);
				message = string.Join("\r\n", lines);
				WriteEventLogEntry(_Source, message, entryType, _MonitorLogPerformance);
			}
			catch (Exception)
			{
				try
				{
					WriteEventLogEntry("Application", message, entryType, () => false);
				}
				catch (Exception)
				{
				}
			}
		}
		static string[] SplitToLines(string s)
		{
			return s.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
		}
	}

	private static EventLogEntryType GetEventLogEntryTypeByLogLevel(LogLevel logLevel)
	{
		return logLevel switch
		{
			LogLevel.Error => EventLogEntryType.Error, 
			LogLevel.Warning => EventLogEntryType.Warning, 
			_ => EventLogEntryType.Information, 
		};
	}

	private static void WriteEventLogEntry(string source, string message, EventLogEntryType entryType, Func<bool> monitorPerformance)
	{
		bool isMessageTrimmed = false;
		if (message.Length > 30000)
		{
			message = "MESSAGE TRIMMED: " + message.Substring(0, 30000);
			isMessageTrimmed = true;
		}
		System.Diagnostics.EventLog.WriteEntry(source, message, entryType);
		if (monitorPerformance != null && monitorPerformance())
		{
			PerformanceMonitor.IncrementCounters(source, isMessageTrimmed, entryType);
		}
	}

	private static LogLevel ParseLogLevel(string logLevelString)
	{
		if (!Enum.TryParse<LogLevel>(logLevelString, ignoreCase: true, out var logLevel))
		{
			return LogLevel.Warning;
		}
		return logLevel;
	}
}
