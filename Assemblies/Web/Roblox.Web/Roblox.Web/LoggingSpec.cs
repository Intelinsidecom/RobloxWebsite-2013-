using System;

namespace Roblox.Web;

public class LoggingSpec : ILoggingSpec
{
	public Func<string> GeneralLogName { get; }

	public Func<string> GeneralLogLevel { get; }

	public Func<string> BillingLogName { get; }

	public Func<string> BillingLogLevel { get; }

	public Func<string> ConfigurationLogName { get; }

	public Func<string> ConfigurationLogLevel { get; }

	public Func<string> LogPrefix { get; }

	public LoggingSpec(Func<string> generalLogName, Func<string> generalLogLevel, Func<string> billingLogName = null, Func<string> billingLogLevel = null, Func<string> configurationLogName = null, Func<string> configurationLogLevel = null, Func<string> logPrefix = null)
	{
		GeneralLogName = generalLogName;
		GeneralLogLevel = generalLogLevel;
		BillingLogName = billingLogName;
		BillingLogLevel = billingLogLevel;
		ConfigurationLogName = configurationLogName;
		ConfigurationLogLevel = configurationLogLevel;
		LogPrefix = logPrefix;
	}
}
