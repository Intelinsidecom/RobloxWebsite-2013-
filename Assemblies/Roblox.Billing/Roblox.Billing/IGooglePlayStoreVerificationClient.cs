using System;

namespace Roblox.Billing;

public interface IGooglePlayStoreVerificationClient
{
	IPurchase Verify(GooglePlayStoreProofOfPurchase proofOfPurchase, Action<string, int> checkoutSessionLogger, IPurchaser purchaser);
}
