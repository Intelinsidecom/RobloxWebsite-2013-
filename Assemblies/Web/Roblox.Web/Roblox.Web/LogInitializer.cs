using System;
using Roblox.Configuration;
using Roblox.EventLog;

namespace Roblox.Web;

public class LogInitializer
{
	private readonly ILoggingSpec _Spec;

	public ILogger GeneralLogger { get; private set; }

	public ILogger BillingLogger { get; private set; }

	public ILogger ConfigurationProviderLogger { get; private set; }

	public LogInitializer(ILoggingSpec spec)
	{
		_Spec = spec;
	}

	public void SetupApplicationLoggers(Func<bool> enableLoggingMetrics)
	{
		CreateAndWireUpConfigurationProviderLogger();
		CreateAndWireUpGeneralLogger(enableLoggingMetrics);
		CreateBillingLogger();
	}

	private void CreateAndWireUpConfigurationProviderLogger()
	{
		string logName = _Spec.ConfigurationLogName?.Invoke();
		if (!string.IsNullOrWhiteSpace(logName))
		{
			ConfigurationProviderLogger = new WebLogger(GetEventLogNamePrefix() + logName, _Spec.ConfigurationLogLevel, () => false);
			ConfigurationLogging.OverrideDefaultConfigurationLogging(delegate(string error)
			{
				ConfigurationProviderLogger.Error(error);
			}, delegate(string warn)
			{
				ConfigurationProviderLogger.Warning(warn);
			}, delegate(string info)
			{
				ConfigurationProviderLogger.Info(info);
			});
		}
	}

	private void CreateAndWireUpGeneralLogger(Func<bool> enableLoggingMetrics)
	{
		string generalEventLogName = GetEventLogNamePrefix() + _Spec.GeneralLogName();
		GeneralLogger = new WebLogger(generalEventLogName, _Spec.GeneralLogLevel, enableLoggingMetrics)
		{
			IsDefaultLog = true
		};
	}

	private void CreateBillingLogger()
	{
		string billingName = _Spec.BillingLogName?.Invoke();
		if (!string.IsNullOrWhiteSpace(billingName))
		{
			BillingLogger = new WebLogger(GetEventLogNamePrefix() + billingName, _Spec.BillingLogLevel, () => false);
		}
	}

	private string GetEventLogNamePrefix()
	{
		string eventLogNameSuffix = _Spec.LogPrefix?.Invoke();
		if (!string.IsNullOrWhiteSpace(eventLogNameSuffix))
		{
			return eventLogNameSuffix + ".";
		}
		return string.Empty;
	}
}
