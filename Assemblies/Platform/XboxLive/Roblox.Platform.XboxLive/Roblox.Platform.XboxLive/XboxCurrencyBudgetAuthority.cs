using Roblox.Economy.Common;
using Roblox.Platform.CurrencyBudgets;
using Roblox.Platform.VirtualCurrency;
using Roblox.Platform.XboxLive.Properties;

namespace Roblox.Platform.XboxLive;

public class XboxCurrencyBudgetAuthority : IXboxCurrencyBudgetAuthority, ICurrencyBudgetAuthority
{
	public const string XboxCurrencyBudgetType = "XBox";

	public const string UserCurrencyHolderType = "User";

	public const string BillingSaleCurrencyBudgetTransactionType = "Billing Sale";

	public const string EconomySaleCurrencyBudgetTransactionType = "Economy Sale";

	private readonly ICurrencyBudgetFactory _CurrencyBudgetFactory;

	public bool IsXboxCurrencyBudgetsEnabled => Settings.Default.XboxCurrencyBudgetsEnabled;

	public XboxCurrencyBudgetAuthority(ICurrencyBudgetFactory currencyBudgetFactory)
	{
		_CurrencyBudgetFactory = currencyBudgetFactory;
	}

	public long GetXboxRobuxBalance(long userId)
	{
		return _CurrencyBudgetFactory.GetOrCreate("XBox", CurrencyType.RobuxID, "User", userId).Value;
	}

	public bool VerifyXboxRobuxBalanceIsSufficient(long userId, long amount)
	{
		return _CurrencyBudgetFactory.GetOrCreate("XBox", CurrencyType.RobuxID, "User", userId).Value >= amount;
	}

	public void CreditXboxRobuxBalance(long userId, long amount, long billingSaleId)
	{
		_CurrencyBudgetFactory.GetOrCreate("XBox", CurrencyType.RobuxID, "User", userId).Credit(amount, "Billing Sale", billingSaleId);
	}

	public bool TryDebitXboxRobuxBalance(long userId, long amount, long economySaleId)
	{
		return _CurrencyBudgetFactory.GetOrCreate("XBox", CurrencyType.RobuxID, "User", userId).Debit(amount, "Economy Sale", economySaleId);
	}

	public long GetBalance(long userId)
	{
		return GetXboxRobuxBalance(userId);
	}

	public bool VerifyBalanceIsSufficient(long userId, long amount)
	{
		return VerifyXboxRobuxBalanceIsSufficient(userId, amount);
	}

	public void CreditBalance(long userId, long amount, long? saleId)
	{
		CreditXboxRobuxBalance((int)userId, amount, saleId ?? 0);
	}

	public bool TryDebitBalance(long userId, long amount, long? saleId)
	{
		return TryDebitXboxRobuxBalance(userId, amount, saleId ?? 0);
	}
}
