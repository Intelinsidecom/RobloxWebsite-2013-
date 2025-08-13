namespace Roblox.Platform.VirtualCurrency;

public interface IRecurringTransactionFactory
{
	bool CancelRecurringTransactionProfile(string id);

	IRecurringTransactionProfile GetRecurringTransactionProfile(string id);
}
