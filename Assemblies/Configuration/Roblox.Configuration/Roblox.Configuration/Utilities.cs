using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Roblox.Configuration;

public static class Utilities
{
	public static void MonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action propertyChangeHandler) where T : INotifyPropertyChanged
	{
		settings.MonitorChanges(exp, propertyChangeHandler, readValueFirst: false);
	}

	public static ISingleSetting<TVal> ToSingleSetting<T, TVal>(this T settings, Expression<Func<T, TVal>> exp) where T : class, INotifyPropertyChanged
	{
		Func<T, TVal> valueGetter = exp.Compile();
		string propertyName = GetPropertyName(exp);
		return new SingleSetting<T, TVal>(settings, valueGetter, propertyName);
	}

	public static void ReadValueAndMonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action propertyChangeHandler) where T : INotifyPropertyChanged
	{
		settings.MonitorChanges(exp, propertyChangeHandler, readValueFirst: true);
	}

	private static void MonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action propertyChangeHandler, bool readValueFirst) where T : INotifyPropertyChanged
	{
		Func<T, TVal> valueGetter = exp.Compile();
		TVal propertyValue = valueGetter(settings);
		if (readValueFirst)
		{
			SafelyInvokeAction(propertyChangeHandler);
		}
		string propertyName = GetPropertyName(exp);
		settings.PropertyChanged += delegate(object s, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == propertyName)
			{
				TVal val = valueGetter(settings);
				if (val == null || !val.Equals(propertyValue))
				{
					SafelyInvokeAction(propertyChangeHandler);
					propertyValue = val;
				}
			}
		};
	}

	public static void MonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action<TVal> propertyChangeHandler) where T : INotifyPropertyChanged
	{
		settings.MonitorChanges(exp, propertyChangeHandler, readValueFirst: false);
	}

	public static void ReadValueAndMonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action<TVal> propertyChangeHandler) where T : INotifyPropertyChanged
	{
		settings.MonitorChanges(exp, propertyChangeHandler, readValueFirst: true);
	}

	private static void MonitorChanges<T, TVal>(this T settings, Expression<Func<T, TVal>> exp, Action<TVal> propertyChangeHandler, bool readValueFirst) where T : INotifyPropertyChanged
	{
		Func<T, TVal> valueGetter = exp.Compile();
		TVal propertyValue = valueGetter(settings);
		if (readValueFirst)
		{
			SafelyInvokeAction(propertyChangeHandler, propertyValue);
		}
		string propertyName = GetPropertyName(exp);
		settings.PropertyChanged += delegate(object s, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == propertyName)
			{
				TVal val = valueGetter(settings);
				if (val == null || !val.Equals(propertyValue))
				{
					SafelyInvokeAction(propertyChangeHandler, val);
					propertyValue = val;
				}
			}
		};
	}

	private static void SafelyInvokeAction(Action propertyChangeHandler)
	{
		try
		{
			propertyChangeHandler();
		}
		catch (Exception ex)
		{
			LogError("{0}", ex.ToString());
		}
	}

	private static void SafelyInvokeAction<TVal>(Action<TVal> propertyChangeHandler, TVal propertyValue)
	{
		try
		{
			propertyChangeHandler(propertyValue);
		}
		catch (Exception ex)
		{
			LogError("{0}", ex.ToString());
		}
	}

	internal static DateTime GetTimestamp()
	{
		return DateTime.UtcNow.AddHours(-7.0);
	}

	internal static void LogError(string format, params object[] args)
	{
		ConfigurationLogging.Error(format, args);
	}

	internal static void LogWarning(string format, params object[] args)
	{
		ConfigurationLogging.Warning(format, args);
	}

	internal static void LogInformation(string format, params object[] args)
	{
		ConfigurationLogging.Info(format, args);
	}

	private static string GetPropertyName<T, TVal>(Expression<Func<T, TVal>> exp) where T : INotifyPropertyChanged
	{
		return ((MemberExpression)exp.Body).Member.Name;
	}
}
