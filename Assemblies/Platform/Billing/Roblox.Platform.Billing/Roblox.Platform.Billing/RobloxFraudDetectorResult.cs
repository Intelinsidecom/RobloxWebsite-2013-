using Roblox.Billing;

namespace Roblox.Platform.Billing;

public class RobloxFraudDetectorResult : IFraudDetectorResult
{
	private FraudDetectorResultType _fraudDetectorResultType;

	public bool IsFraudulent { get; set; }

	public FraudDetectorResultType FraudDetectorResultType
	{
		get
		{
			return _fraudDetectorResultType;
		}
		set
		{
			_fraudDetectorResultType = value;
			if (value == FraudDetectorResultType.NoRulesChecked || value == FraudDetectorResultType.NoFraudDetected || value == FraudDetectorResultType.AmountTooSmall || value == FraudDetectorResultType.AccountAndCardAssociatedWithGoodPayments)
			{
				IsFraudulent = false;
			}
			else
			{
				IsFraudulent = true;
			}
		}
	}

	public string TransactionId { get; set; }

	public bool TransactionSucceeded { get; set; }

	public RobloxFraudDetectorResult()
	{
		FraudDetectorResultType = FraudDetectorResultType.NoFraudDetected;
	}
}
