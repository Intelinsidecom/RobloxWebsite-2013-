using System;

namespace Roblox.Web;

public interface ILoggingSpec
{
	Func<string> BillingLogLevel { get; }

	Func<string> BillingLogName { get; }

	Func<string> ConfigurationLogName { get; }

	Func<string> ConfigurationLogLevel { get; }

	Func<string> GeneralLogLevel { get; }

	Func<string> GeneralLogName { get; }

	Func<string> LogPrefix { get; }
}
