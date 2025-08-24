namespace Roblox.Platform.VirtualCurrency;

public interface ICurrencyOperations
{
	long CreditRobux(long agentId, long amount);

	ICurrencyBalance GetCurrencyBalance(long agentId);

	long GetRobuxBalance(long agentId);

	long GetRobuxHeld(long currencyHolderId);
}
