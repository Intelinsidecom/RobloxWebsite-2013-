namespace Roblox.Billing;

/// <summary>
/// Provides common methods for using the Amazon store verification service.
/// </summary>
public interface IAmazonStoreVerificationClient
{
	/// <summary>
	/// Verifies the proof of purchase and updates its data with data provided by Amazon.
	/// </summary>
	/// <returns>The verified purchase.</returns>
	/// <exception cref="T:System.Net.WebException">Thrown if the validation with amazon failed.</exception>
	IPurchase Verify(AmazonStoreProofOfPurchase proofOfPurchase);
}
