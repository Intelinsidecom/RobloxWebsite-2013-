using Roblox.Currency.Client;

namespace Roblox.Platform.VirtualCurrency;

internal class CurrencyBalance : ICurrencyBalance
{
	public long RobuxBalance { get; set; }

	public CurrencyBalance()
		: this(0L)
	{
	}

	public CurrencyBalance(CurrencyBalances balances)
	{
		RobuxBalance = balances.RobuxBalance;
	}

	public CurrencyBalance(long robuxBalance)
	{
		RobuxBalance = robuxBalance;
	}
}
