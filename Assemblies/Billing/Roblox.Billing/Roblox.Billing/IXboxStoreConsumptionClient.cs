namespace Roblox.Billing;

public interface IXboxStoreConsumptionClient
{
	bool Consume(XboxStoreProofOfPurchase proofOfPurchase);
}
