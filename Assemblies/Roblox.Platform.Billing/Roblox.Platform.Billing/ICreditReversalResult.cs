namespace Roblox.Platform.Billing;

/// <summary>
/// Credit Redemption result
/// </summary>
public interface ICreditReversalResult : IFailableResult<CreditReversalFailureReason>
{
	/// <summary>
	/// Transaction Id. Implementation may vary depending on the provider
	/// </summary>
	string TransactionId { get; set; }
}
