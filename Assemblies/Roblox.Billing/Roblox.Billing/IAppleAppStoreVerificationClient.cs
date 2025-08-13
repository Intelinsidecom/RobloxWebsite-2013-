using System;

namespace Roblox.Billing;

public interface IAppleAppStoreVerificationClient
{
	IPurchase Verify(AppleAppStoreProofOfPurchase proofOfPurchase, Action<string, int> checkoutSessionLogger);
}
