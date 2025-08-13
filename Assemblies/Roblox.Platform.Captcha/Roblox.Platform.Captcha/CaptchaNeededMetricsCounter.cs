using Roblox.EphemeralCounters;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Used by the CaptchaNeededManager to increment ephemeral counters for circumstances
/// when it allows a user to bypass a captcha action
/// </summary>
public class CaptchaNeededMetricsCounter
{
	private const string _CaptchaBypassedEventName = "CaptchaBypassed";

	private const string _BypassAccountAgeSuffix = "AccountAge";

	private const string _BypassTransactionHistorySuffix = "TransactionHistory";

	private const string _BypassTimeInGameSuffix = "TimeInGame";

	private const string _BypassPreviousSuccessSuffix = "PreviouslyPassed";

	private readonly IEphemeralCounterFactory _CounterFactory;

	internal CaptchaNeededMetricsCounter(IEphemeralCounterFactory counterFactory)
	{
		_CounterFactory = counterFactory;
	}

	internal virtual void IncrementAccountAgeBypassCounter()
	{
		IncrementCounter("AccountAge");
	}

	internal virtual void IncrementTransactionHistoryBypassCounter()
	{
		IncrementCounter("TransactionHistory");
	}

	internal virtual void IncrementTimeInGameBypassCounter()
	{
		IncrementCounter("TimeInGame");
	}

	internal virtual void IncrementPreviousSuccessCounter()
	{
		IncrementCounter("PreviouslyPassed");
	}

	private void IncrementCounter(string suffix)
	{
		string counterName = string.Format("{0}_{1}", "CaptchaBypassed", suffix);
		_CounterFactory.GetCounter(counterName).IncrementInBackground();
	}
}
