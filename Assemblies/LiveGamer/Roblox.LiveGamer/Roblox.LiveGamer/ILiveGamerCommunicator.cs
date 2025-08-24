namespace Roblox.LiveGamer;

public interface ILiveGamerCommunicator
{
	string GetPaymentInitUrl(LiveGamerInitTransactionResult transactionResult);

	bool VerifySignature(string callbackXmlContent, string signature);

	LiveGamerTransactionInfo DeserializeCallbackContent(string callbackXmlContent, string signature);
}
