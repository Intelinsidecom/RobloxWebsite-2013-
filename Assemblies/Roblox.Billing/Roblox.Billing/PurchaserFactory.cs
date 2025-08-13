namespace Roblox.Billing;

public class PurchaserFactory
{
	public static readonly PurchaserFactory Singleton = new PurchaserFactory();

	private PurchaserFactory()
	{
	}

	public IPurchaser GetPurchaser(long accountId)
	{
		return new Purchaser(accountId);
	}
}
