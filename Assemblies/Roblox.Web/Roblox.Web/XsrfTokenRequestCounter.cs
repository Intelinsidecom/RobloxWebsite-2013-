using System;
using Roblox.Instrumentation;

namespace Roblox.Web;

/// <summary>
/// Attaches handlers to XsrfTokenHelper and counts Xsrf request attempts, successes and failures
/// </summary>
public class XsrfTokenRequestCounter : IDisposable
{
	private const string _PerformanceCategory = "Roblox.Web.XsrfToken";

	private readonly IRateOfCountsPerSecondCounter _ValidationRequestsPerSecond;

	private readonly IRateOfCountsPerSecondCounter _TotpChecksFailedPerSecond;

	private readonly IRateOfCountsPerSecondCounter _TotpChecksPassedPerSecond;

	public XsrfTokenRequestCounter(ICounterRegistry counterRegistry)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_ValidationRequestsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Web.XsrfToken", "ValidationRequestsPerSecond");
		_TotpChecksFailedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Web.XsrfToken", "TotpChecksFailedPerSecond");
		_TotpChecksPassedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Web.XsrfToken", "TotpChecksPassedPerSecond");
		XsrfTokenHelper.OnXsrfValidationRequest += IncrementValidationRequest;
		XsrfTokenHelper.OnXsrfTotpCheckFailed += IncrementTotpCheckFailed;
		XsrfTokenHelper.OnXsrfTotpCheckPassed += IncrementTotpCheckPassed;
	}

	private void IncrementValidationRequest(string key)
	{
		_ValidationRequestsPerSecond.Increment();
	}

	private void IncrementTotpCheckFailed(string key)
	{
		_TotpChecksFailedPerSecond.Increment();
	}

	private void IncrementTotpCheckPassed(string key)
	{
		_TotpChecksPassedPerSecond.Increment();
	}

	public void Dispose()
	{
		XsrfTokenHelper.OnXsrfValidationRequest -= IncrementValidationRequest;
		XsrfTokenHelper.OnXsrfTotpCheckFailed -= IncrementTotpCheckFailed;
		XsrfTokenHelper.OnXsrfTotpCheckPassed -= IncrementTotpCheckPassed;
	}
}
