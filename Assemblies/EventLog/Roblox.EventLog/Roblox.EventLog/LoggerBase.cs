using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Roblox.EventLog;

public abstract class LoggerBase : ILogger
{
	private const string _DiagnosticsLogFormat = "[{0}] {1:yyyy'-'MM'-'dd' 'HH':'mm':'ss,fff} {2}{3}";

	public Func<LogLevel> MaxLogLevel { get; set; }

	public bool LogMethodName { get; set; }

	public bool LogClassAndMethodName { get; set; }

	public bool LogThreadID { get; set; }

	public Func<string> EscalationSearchString { get; set; }

	public Func<LogLevel> EscalationLogLevel { get; set; }

	public bool IsDefaultLog
	{
		set
		{
			if (value)
			{
				StaticLoggerRegistry.SetLogger(this);
			}
		}
	}

	protected virtual string GetPrefix(LogLevel logLevel)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (LogThreadID)
		{
			Thread currentThread = Thread.CurrentThread;
			string arg = currentThread.Name ?? currentThread.ManagedThreadId.ToString();
			stringBuilder.AppendFormat("[{0}] ", arg);
		}
		if (LogMethodName || LogClassAndMethodName)
		{
			MethodBase method = new StackFrame(3, needFileInfo: true).GetMethod();
			string arg2 = ((method != null) ? method.Name : "<Unknown method>");
			string arg3 = "";
			if (LogClassAndMethodName)
			{
				arg3 = ((method != null && method.DeclaringType != null) ? (method.DeclaringType.Name + ".") : "");
			}
			stringBuilder.AppendFormat("[{0}{1}] ", arg3, arg2);
		}
		return stringBuilder.ToString();
	}

	protected abstract void Log(LogLevel logLevel, string format, params object[] args);

	public void Debug(string format, params object[] args)
	{
	}

	public void Debug(Func<string> messageGetter)
	{
	}

	public void Error(Exception ex)
	{
		LogIfNeededLazy(LogLevel.Error, ex.ToString);
	}

	public void Error(string format, params object[] args)
	{
		LogIfNeeded(LogLevel.Error, format, args);
	}

	public void Error(Func<string> messageGetter)
	{
		LogIfNeededLazy(LogLevel.Error, messageGetter);
	}

	public void Info(string format, params object[] args)
	{
		LogIfNeeded(LogLevel.Information, format, args);
	}

	public void Info(Func<string> messageGetter)
	{
		LogIfNeededLazy(LogLevel.Information, messageGetter);
	}

	public void Warning(string format, params object[] args)
	{
		LogIfNeeded(LogLevel.Warning, format, args);
	}

	public void Warning(Func<string> messageGetter)
	{
		LogIfNeededLazy(LogLevel.Warning, messageGetter);
	}

	public void Verbose(string format, params object[] args)
	{
		LogIfNeeded(LogLevel.Verbose, format, args);
	}

	public void Verbose(Func<string> messageGetter)
	{
		LogIfNeededLazy(LogLevel.Verbose, messageGetter);
	}

	public void LifecycleEvent(string format, params object[] args)
	{
		Log(LogLevel.Information, format, args);
	}

	public void LifecycleEvent(Func<string> messageGetter)
	{
		Log(LogLevel.Information, messageGetter(), null);
	}

	internal void LogIfNeeded(LogLevel level, string message, object[] args = null)
	{
		if (level == LogLevel.Error)
		{
			LogWithDiagnosticsIfNecessary(level, message, args);
			return;
		}
		LogLevel logLevel = MaxLogLevel();
		string value = EscalationSearchString?.Invoke();
		if (EscalationLogLevel != null && EscalationLogLevel() < level && !string.IsNullOrEmpty(value) && message.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
		{
			level = ((logLevel < EscalationLogLevel()) ? logLevel : EscalationLogLevel());
		}
		if (logLevel >= level)
		{
			LogWithDiagnosticsIfNecessary(level, message, args);
		}
	}

	internal void LogIfNeededLazy(LogLevel level, Func<string> messageGetter)
	{
		if (level == LogLevel.Error)
		{
			LogWithDiagnosticsIfNecessary(level, messageGetter());
			return;
		}
		LogLevel logLevel = MaxLogLevel();
		string value = EscalationSearchString?.Invoke();
		string text = null;
		if (EscalationLogLevel != null && EscalationLogLevel() < level && !string.IsNullOrEmpty(value))
		{
			text = messageGetter();
			if (text.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0)
			{
				level = ((logLevel < EscalationLogLevel()) ? logLevel : EscalationLogLevel());
			}
		}
		if (logLevel >= level)
		{
			text = text ?? messageGetter();
			LogWithDiagnosticsIfNecessary(level, text);
		}
	}

	private void LogWithDiagnosticsIfNecessary(LogLevel level, string message, params object[] args)
	{
		Log(level, message, args);
	}

	private static void LogSafely(Action logLineAction)
	{
		try
		{
			logLineAction();
		}
		catch (Exception)
		{
			try
			{
			}
			catch (Exception)
			{
			}
		}
	}
}
