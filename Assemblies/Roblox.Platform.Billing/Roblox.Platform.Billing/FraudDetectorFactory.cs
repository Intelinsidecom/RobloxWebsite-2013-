namespace Roblox.Platform.Billing;

public class FraudDetectorFactory
{
	public static IFraudDetector GetFraudDetector()
	{
		return new FraudDetector();
	}
}
