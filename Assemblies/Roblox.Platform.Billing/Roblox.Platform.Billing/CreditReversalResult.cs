namespace Roblox.Platform.Billing;

/// <inheritdoc />
public class CreditReversalResult : ICreditReversalResult, IFailableResult<CreditReversalFailureReason>
{
	public string TransactionId { get; set; }

	public CreditReversalFailureReason FailureReason { get; set; }

	public bool IsSuccess { get; set; }
}
