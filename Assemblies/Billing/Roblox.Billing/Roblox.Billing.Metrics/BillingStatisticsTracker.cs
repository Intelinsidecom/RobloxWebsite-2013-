using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using Roblox.Instrumentation;
using Roblox.Platform.Demographics;

namespace Roblox.Billing.Metrics;

/// <inheritdoc cref="T:Roblox.Billing.Metrics.IBillingStatisticsTracker" />
public class BillingStatisticsTracker : IBillingStatisticsTracker
{
	private readonly ConcurrentDictionary<string, Lazy<IPurchaserCountryPerformanceCounter>> _PurchaserCountryPerfCounterLookup = new ConcurrentDictionary<string, Lazy<IPurchaserCountryPerformanceCounter>>();

	private readonly string _PerformanceCounterCategory;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Billing.Metrics.BillingStatisticsTracker" />.
	/// </summary>
	/// <param name="counterRegistry">The counter registry injected.</param>
	/// <param name="performanceCounterCategory">The performance counter category.</param>
	public BillingStatisticsTracker(ICounterRegistry counterRegistry, string performanceCounterCategory)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		if (string.IsNullOrWhiteSpace(performanceCounterCategory))
		{
			throw new ArgumentException(string.Format("{0} must not be null or whitespace.", "performanceCounterCategory"), "performanceCounterCategory");
		}
		_PerformanceCounterCategory = performanceCounterCategory;
	}

	/// <inheritdoc cref="M:Roblox.Billing.Metrics.IBillingStatisticsTracker.OnPurchase(Roblox.Platform.Demographics.ICountry,Roblox.Billing.PaymentProviderType)" />
	public void OnPurchase(ICountry country, PaymentProviderType paymentProviderType)
	{
		string countryName = country?.Name;
		if (string.IsNullOrWhiteSpace(countryName) || paymentProviderType == null)
		{
			return;
		}
		string paymentProviderName = paymentProviderType.Value.Replace(" ", "");
		try
		{
			GetPurchaserCountryCounter(paymentProviderName, countryName).Increment();
		}
		catch (Exception)
		{
		}
	}

	private IPurchaserCountryPerformanceCounter GetPurchaserCountryCounter(string paymentProviderName, string countryName)
	{
		return _PurchaserCountryPerfCounterLookup.GetOrAdd($"{paymentProviderName}_{countryName}", (string _) => new Lazy<IPurchaserCountryPerformanceCounter>(() => CreatePurchaserCountryPerformanceCounter(paymentProviderName, countryName))).Value;
	}

	/// <summary>
	/// This is overriden in unit test.
	/// </summary>
	/// <param name="paymentProviderName"></param>
	/// <param name="countryName"></param>
	/// <returns></returns>
	[ExcludeFromCodeCoverage]
	internal virtual IPurchaserCountryPerformanceCounter CreatePurchaserCountryPerformanceCounter(string paymentProviderName, string countryName)
	{
		return new PurchaserCountryPerformanceCounter(_CounterRegistry, $"{_PerformanceCounterCategory}", $"{paymentProviderName}", countryName);
	}
}
