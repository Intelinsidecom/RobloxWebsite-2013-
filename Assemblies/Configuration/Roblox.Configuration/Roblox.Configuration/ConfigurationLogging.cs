using System;
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
		if (_OverrideOnError == null)
		{
			SafelyLogViaStaticLoggerRegistry(format, args);
		}
		else
		{
			Log(_OverrideOnError, format, args);
		}
	}

	internal static void Warning(string format, params object[] args)
	{
		Log(_OverrideOnWarning, format, args);
	}

	internal static void Info(string format, params object[] args)
	{
		Log(_OverrideOnInformation, format, args);
	}

	private static void SafelyLogViaStaticLoggerRegistry(string format, params object[] args)
	{
		try
		{
			StaticLoggerRegistry.Instance.Error(format, args);
		}
		catch (UninitializedLoggerException)
		{
		}
	}

	private static void Log(Action<string> overrideLogger, string format, params object[] args)
	{
		string obj = string.Format(format, args);
		overrideLogger?.Invoke(obj);
	}
}
