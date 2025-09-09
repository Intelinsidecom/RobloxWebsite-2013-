using System;
using System.Diagnostics;
using Roblox.EventLog;

namespace Roblox.Configuration;

public static class ConfigurationLogging
{
	private static Action<string> _OverrideOnError;

	private static Action<string> _OverrideOnWarning;

	private static Action<string> _OverrideOnInformation;

	public static void OverrideDefaultConfigurationLogging(Action<string> onError, Action<string> onWarning, Action<string> onInformation)
	{
		_OverrideOnError = onError;
		_OverrideOnWarning = onWarning;
		_OverrideOnInformation = onInformation;
	}

	internal static void Error(string format, params object[] args)
	{
		if (_OverrideOnError != null)
		{
			Log(_OverrideOnError, format, args);
			return;
		}
		// Avoid initializing StaticLoggerRegistry during configuration bootstrap to prevent recursion/StackOverflow
		try { Debug.WriteLine(string.Format(format, args)); } catch { }
	}

	internal static void Warning(string format, params object[] args)
	{
		if (_OverrideOnWarning != null)
		{
			Log(_OverrideOnWarning, format, args);
			return;
		}
		try { Debug.WriteLine(string.Format(format, args)); } catch { }
	}

	internal static void Info(string format, params object[] args)
	{
		if (_OverrideOnInformation != null)
		{
			Log(_OverrideOnInformation, format, args);
			return;
		}
		try { Debug.WriteLine(string.Format(format, args)); } catch { }
	}

	private static void SafelyLogViaStaticLoggerRegistry(string format, params object[] args)
	{
		// Deprecated: Avoid using StaticLoggerRegistry by default to prevent bootstrap recursion
		try { Debug.WriteLine(string.Format(format, args)); } catch { }
	}

	private static void Log(Action<string> overrideLogger, string format, params object[] args)
	{
		string obj = string.Format(format, args);
		overrideLogger?.Invoke(obj);
	}
}
