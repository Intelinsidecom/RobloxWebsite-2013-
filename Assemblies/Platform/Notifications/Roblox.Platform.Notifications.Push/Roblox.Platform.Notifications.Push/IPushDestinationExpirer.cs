namespace Roblox.Platform.Notifications.Push;

public interface IPushDestinationExpirer
{
	void ExpireDestinationBasedOnDeliveryReceipt(string deliveryReceiptId);

	void ExpireDestinationById(long destinationId);
}
