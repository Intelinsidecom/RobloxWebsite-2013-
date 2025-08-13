namespace Roblox.Platform.Billing;

/// <inheritdoc />
/// <summary>
/// Add Prepaid Credit Operation result
/// </summary>
public interface IAddPrepaidCreditResult : IFailableResult<CreditRedemptionFailureReason>
{
	/// <summary>
	/// User's credit balance after the operation
	/// </summary>
	decimal NewBalance { get; set; }
}
