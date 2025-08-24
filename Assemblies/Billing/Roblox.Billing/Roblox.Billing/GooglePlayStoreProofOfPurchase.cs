namespace Roblox.Billing;

public class GooglePlayStoreProofOfPurchase
{
	public enum PurchaseStateValues
	{
		Purchased,
		Cancelled
	}

	public enum ConsumptionStateValues
	{
		YetToBeConsumed,
		Consumed
	}

	internal class PurchaseResponse
	{
		public long PurchaseTime { get; set; }

		public int PurchaseState { get; set; }

		public int ConsumptionState { get; set; }

		public string DeveloperPayload { get; set; }
	}

	public string PackageName { get; private set; }

	public string PlayStoreProductId { get; private set; }

	public string Token { get; private set; }

	internal PurchaseResponse Response { get; set; }

	internal GooglePlayStoreProofOfPurchase(string packageName, string appStoreProductId, string token)
	{
		PackageName = packageName;
		PlayStoreProductId = appStoreProductId;
		Token = token;
	}
}
