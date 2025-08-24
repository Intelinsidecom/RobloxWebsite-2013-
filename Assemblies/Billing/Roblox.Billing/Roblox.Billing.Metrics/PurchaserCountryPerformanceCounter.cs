using System;
using Roblox.Instrumentation;

namespace Roblox.Billing.Metrics;

/// <inheritdoc />
internal class PurchaserCountryPerformanceCounter : IPurchaserCountryPerformanceCounter
{
	private readonly string _InstanceName;

	internal IRateOfCountsPerSecondCounter PurchaserCountryCounter { get; set; }

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Billing.Metrics.PurchaserCountryPerformanceCounter" />.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCategory">The performance counter category.</param>
	/// <param name="performanceCounterName">The performance counter name.</param>
	/// <param name="countryName">The status code for the counter.</param>
	public PurchaserCountryPerformanceCounter(ICounterRegistry counterRegistry, string performanceCategory, string performanceCounterName, string countryName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrEmpty(performanceCategory))
		{
			throw new ArgumentException("performanceCategory cannot be null or empty");
		}
		if (string.IsNullOrWhiteSpace(performanceCounterName))
		{
			throw new ArgumentException(string.Format("{0} can not be null or whitespace.", "performanceCounterName"), "performanceCounterName");
		}
		if (string.IsNullOrWhiteSpace(countryName))
		{
			throw new ArgumentException("countryName cannot be null or empty");
		}
		_InstanceName = $"{performanceCounterName}_{countryName}";
		PurchaserCountryCounter = counterRegistry.GetRateOfCountsPerSecondCounter(performanceCategory, "PurchasesPerCountryPerSecond", _InstanceName);
	}

	/// <inheritdoc cref="M:Roblox.Billing.Metrics.IPurchaserCountryPerformanceCounter.Increment" />
	public void Increment()
	{
		PurchaserCountryCounter?.Increment();
	}

	private static T CheckForNull<T>(T value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("PerformanceCounterCategory can not be null.");
		}
		return value;
	}
}
