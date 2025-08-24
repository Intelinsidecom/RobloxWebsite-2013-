using Roblox.Platform.Billing.Interface;

namespace Roblox.Platform.Billing.Implementation;

public class CreditStatusResult : ICreditStatusResult, IFailableResult<CreditStatusFailureReason>
{
	public string TransactionId { get; set; }

	public string Status { get; set; }

	public CreditStatusFailureReason FailureReason { get; set; }

	public bool IsSuccess { get; set; }
}
