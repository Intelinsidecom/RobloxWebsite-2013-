using System;
using System.Collections.Generic;
using System.Text;

namespace Roblox.EventLog.Windows;

/// <summary>
/// The ExtendedLogger class inherits the Logger class
///
/// The ExtendedLogger class provides possibility to predictably and safely extend the base Logger's functionality from outside
/// </summary>
public class ExtendedLogger : Logger
{
	private readonly IEnumerable<Func<string>> _ErrorMessagePrefixDataProviders;

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor takes a delegate that returns the max log level as a string)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevelGetter">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorPerformance">should monitor performance metrics for specified source</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, Func<string> maxLogLevelGetter, Func<bool> monitorPerformance, bool logThreadId = false)
		: base(source, maxLogLevelGetter, monitorPerformance, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor takes a delegate that returns the max log level as a string)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevelGetter">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, Func<string> maxLogLevelGetter, bool logThreadId = false)
		: base(source, maxLogLevelGetter, () => false, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor takes a delegate that returns the max log level)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorPerformance">should monitor performance metrics for specified source</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, Func<LogLevel> maxLogLevel, Func<bool> monitorPerformance, bool logThreadId = false)
		: base(source, maxLogLevel, monitorPerformance, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor takes a delegate that returns the max log level)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, Func<LogLevel> maxLogLevel, bool logThreadId = false)
		: base(source, maxLogLevel, () => false, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor uses a fixed log level. Used for backward compatibility)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	/// <param name="monitorPerformance">should monitor performance metrics for specified source</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, Func<bool> monitorPerformance, LogLevel maxLogLevel = LogLevel.Information, bool logThreadId = false)
		: base(source, monitorPerformance, maxLogLevel, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Initializes extensions and calls the Logger's corresponding constructor
	/// (This constructor uses a fixed log level. Used for backward compatibility)
	/// </summary>
	/// <param name="source">event source name</param>
	/// <param name="logExtensionsConfig">container with extensions configurations</param>
	/// <param name="maxLogLevel">maximal log level delegate</param>
	/// <param name="logThreadId">should thread id be logged</param>
	public ExtendedLogger(string source, ILogExtensionsConfig logExtensionsConfig, LogLevel maxLogLevel = LogLevel.Information, bool logThreadId = false)
		: base(source, () => false, maxLogLevel, logThreadId)
	{
		InitExtensions(logExtensionsConfig, out _ErrorMessagePrefixDataProviders);
	}

	/// <summary>
	/// Method that initialize extensions
	/// </summary>
	/// <param name="logExtensionsConfig">container with extensions configuration</param>
	/// <param name="errorMessagePrefixDataProviders">readonly property that contains error message prefix additional data providers</param>
	private static void InitExtensions(ILogExtensionsConfig logExtensionsConfig, out IEnumerable<Func<string>> errorMessagePrefixDataProviders)
	{
		errorMessagePrefixDataProviders = new Func<string>[0];
		if (logExtensionsConfig != null)
		{
			errorMessagePrefixDataProviders = logExtensionsConfig.ErrorMessagePrefixDataProviders ?? errorMessagePrefixDataProviders;
		}
	}

	/// <summary>
	/// overrided method which is extended with possibility to append messages from prefix data providers
	/// </summary>
	/// <returns></returns>
	protected override string GetPrefix(LogLevel logLevel)
	{
		StringBuilder prefixSb = new StringBuilder(base.GetPrefix(logLevel));
		if (logLevel == LogLevel.Error)
		{
			foreach (Func<string> errorPrefixProvider in _ErrorMessagePrefixDataProviders)
			{
				prefixSb.AppendFormat("{0} ", errorPrefixProvider());
			}
		}
		return prefixSb.ToString();
	}
}
