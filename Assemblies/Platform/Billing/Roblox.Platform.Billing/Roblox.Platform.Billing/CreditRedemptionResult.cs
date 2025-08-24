namespace Roblox.Platform.Billing;

/// <inheritdoc />
public class CreditRedemptionResult : ICreditRedemptionResult, IFailableResult<CreditRedemptionFailureReason>
{
	public decimal AmountRedeemed { get; set; }

	public string TransactionId { get; set; }

	public int MerchantId { get; set; }

	public CreditRedemptionFailureReason FailureReason { get; set; }

	public bool IsSuccess { get; set; }
}
