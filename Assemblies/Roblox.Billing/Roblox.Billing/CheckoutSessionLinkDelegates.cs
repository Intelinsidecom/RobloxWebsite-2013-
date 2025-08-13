namespace Roblox.Billing;

/// <summary>
/// Contains delegates for linking checkout sessions.
/// </summary>
/// <remarks>
/// This class exists to provide checkout session linking to the legacy billing platform. The delegates are a way to
/// represent the linking functions (which are implemented in a new version of the billing platform),
/// thus avoiding a circular dependency.
/// </remarks>
public static class CheckoutSessionLinkDelegates
{
	/// <summary>
	/// Represents a function that links a checkout session with a sale.
	/// </summary>
	/// <param name="checkoutSessionId">The checkout session ID.</param>
	/// <param name="saleId">The sale identifier.</param>
	/// <exception cref="T:System.ArgumentException">
	///     Thrown if the checkout session associated with <paramref name="checkoutSessionId" /> is already linked with a sale.
	/// </exception>
	public delegate void LinkWithSale(long checkoutSessionId, int saleId);
}
