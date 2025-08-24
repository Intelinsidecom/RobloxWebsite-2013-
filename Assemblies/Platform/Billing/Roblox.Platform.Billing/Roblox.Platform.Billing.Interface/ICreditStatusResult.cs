namespace Roblox.Platform.Billing.Interface;

/// <summary>
/// Credit Status result
/// </summary>
public interface ICreditStatusResult : IFailableResult<CreditStatusFailureReason>
{
	/// <summary>
	/// Transaction Id. Implementation may vary depending on the provider
	/// </summary>
	string TransactionId { get; set; }

	/// <summary>
	/// Status of the blackhawk card
	/// </summary>
	string Status { get; set; }
}
