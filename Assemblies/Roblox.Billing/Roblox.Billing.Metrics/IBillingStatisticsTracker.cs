using Roblox.Platform.Demographics;

namespace Roblox.Billing.Metrics;

/// <summary>
/// A class for tracking billing metrics.
/// </summary>
public interface IBillingStatisticsTracker
{
	/// <summary>
	/// Tracks metrics when a purchase is made.
	/// </summary>
	/// <param name="country">The country of the purchaser.</param>
	/// <param name="paymentProviderType">The payment provider.</param>
	void OnPurchase(ICountry country, PaymentProviderType paymentProviderType);
}
