namespace Roblox.Billing;

public class XboxStoreProofOfPurchase
{
	public string AuthorizationToken;

	public string Signature;

	public string TransactionId;

	public string XboxStoreProductId;

	public string ConsumableUrl;

	public string JsonBody;

	public XboxStoreProofOfPurchase(string authorizationToken, string signature, string transactionId, string xboxStoreProductId, string consumableUrl, string jsonBody)
	{
		AuthorizationToken = authorizationToken;
		Signature = signature;
		TransactionId = transactionId;
		XboxStoreProductId = xboxStoreProductId;
		ConsumableUrl = consumableUrl;
		JsonBody = jsonBody;
	}
}
