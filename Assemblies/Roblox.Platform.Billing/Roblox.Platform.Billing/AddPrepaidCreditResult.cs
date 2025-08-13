namespace Roblox.Platform.Billing;

public class AddPrepaidCreditResult : IAddPrepaidCreditResult, IFailableResult<CreditRedemptionFailureReason>
{
	public decimal NewBalance { get; set; }

	public CreditRedemptionFailureReason FailureReason { get; set; }

	public bool IsSuccess { get; set; }
}
