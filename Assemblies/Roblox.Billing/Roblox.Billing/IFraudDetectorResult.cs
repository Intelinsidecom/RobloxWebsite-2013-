namespace Roblox.Billing;

public interface IFraudDetectorResult
{
	bool IsFraudulent { get; set; }

	string TransactionId { get; set; }

	bool TransactionSucceeded { get; set; }
}
