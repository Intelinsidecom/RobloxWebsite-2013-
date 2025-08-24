namespace Roblox.Billing;

/// <summary>
/// Contains delegates for logging audit messages.
/// </summary>
/// <remarks>
/// This class exists to provide audit logging to the legacy billing platform. The delegates are a way to
/// represent the audit log functions (which are implemented in a new version of the billing platform),
/// thus avoiding a circular dependency.
/// </remarks>
public static class AuditLogDelegates
{
	public enum AuditLogSeverityType
	{
		Information = 1,
		Warning,
		Error
	}

	/// <summary>
	/// Represents a function that logs a message for a sale.
	/// </summary>
	/// <param name="saleId">The sale ID.</param>
	/// <param name="auditLogSeverityTypeId">The audit log severity type ID. Valid values are:
	/// <para>1 - Information</para>
	/// <para>2 - Warning</para>
	/// <para>3 - Error</para>
	/// </param>
	/// <param name="message">The message to log.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="message" /></exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="auditLogSeverityTypeId" /> is not a valid type ID.</exception>
	public delegate void SaleAuditLogFunc(int saleId, int auditLogSeverityTypeId, string message);

	/// <summary>
	/// Represents a function that logs a message for a sale.
	/// </summary>
	/// <param name="paymentId">The payment ID.</param>
	/// <param name="auditLogSeverityTypeId">The audit log severity type ID. Valid values are:
	/// <para>1 - Information</para>
	/// <para>2 - Warning</para>
	/// <para>3 - Error</para>
	/// </param>
	/// <param name="message">The message to log.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="message" /></exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="auditLogSeverityTypeId" /> is not a valid type ID.</exception>
	public delegate void PaymentAuditLogFunc(long paymentId, int auditLogSeverityTypeId, string message);

	/// <summary>
	/// Represents a function that logs a message for a checkout session.
	/// </summary>
	/// <remarks>
	/// If <paramref name="checkoutSessionId" /> is <c>null</c> then no logging will occur. This slight anti-pattern is
	/// used because it significantly cleans up consumers and is ultimately easier to clean up itself.
	/// </remarks>
	/// <param name="checkoutSessionId">The checkout session ID.</param>
	/// <param name="auditLogSeverityTypeId">The audit log severity type ID. Valid values are:
	/// <para>1 - Information</para>
	/// <para>2 - Warning</para>
	/// <para>3 - Error</para>
	/// </param>
	/// <param name="message">The message to log.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="message" /></exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Thrown if <paramref name="auditLogSeverityTypeId" /> is not a valid type ID.</exception>
	public delegate void CheckoutSessionAuditLogFunc(long? checkoutSessionId, int auditLogSeverityTypeId, string message);
}
