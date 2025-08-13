namespace Roblox.Platform.Billing;

/// <summary>
/// Credit Redemption result
/// </summary>
public interface ICreditRedemptionResult : IFailableResult<CreditRedemptionFailureReason>
{
	/// <summary>
	/// Amount redeemed
	/// </summary>
	decimal AmountRedeemed { get; set; }

	/// <summary>
	/// Transaction Id. Implementation may vary depending on the provider
	/// </summary>
	string TransactionId { get; set; }

	/// <summary>
	/// Merchant Id
	/// </summary>
	int MerchantId { get; set; }
}
