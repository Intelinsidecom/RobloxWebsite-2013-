using Roblox.Platform.VirtualCurrency;

namespace Roblox.Platform.XboxLive;

public interface IXboxCurrencyBudgetAuthority : ICurrencyBudgetAuthority
{
	bool IsXboxCurrencyBudgetsEnabled { get; }

	long GetXboxRobuxBalance(long userId);

	bool VerifyXboxRobuxBalanceIsSufficient(long userId, long amount);

	void CreditXboxRobuxBalance(long userId, long amount, long billingSaleId);

	bool TryDebitXboxRobuxBalance(long userId, long amount, long economySaleId);
}
