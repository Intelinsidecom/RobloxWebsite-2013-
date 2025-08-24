namespace Roblox.Billing;

public class FraudDetectionResult : IFraudDetectorResult
{
	public bool IsFraudulent { get; set; }

	public string TransactionId { get; set; }

	public bool TransactionSucceeded { get; set; }
}
