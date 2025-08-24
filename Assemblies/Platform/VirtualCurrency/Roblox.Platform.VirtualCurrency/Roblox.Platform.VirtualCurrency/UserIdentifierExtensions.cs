using Roblox.Currency.Client;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.VirtualCurrency;

public static class UserIdentifierExtensions
{
	public static ICurrencyBalance GetCurrencyBalance(this IUserIdentifier user, ICurrencyAuthority currencyAuthority)
	{
		CurrencyOperations currencyOperations = new CurrencyOperations(currencyAuthority);
		if (user != null)
		{
			return currencyOperations.GetCurrencyBalance(user.Id);
		}
		return null;
	}

	public static long GetRobuxBalance(this IUserIdentifier user, ICurrencyAuthority currencyAuthority)
	{
		CurrencyOperations currencyOperations = new CurrencyOperations(currencyAuthority);
		if (user != null)
		{
			return currencyOperations.GetRobuxBalance(user.Id);
		}
		return 0L;
	}

	public static long CreditRobux(this IUserIdentifier user, ICurrencyAuthority currencyAuthority, long amount)
	{
		CurrencyOperations currencyOperations = new CurrencyOperations(currencyAuthority);
		if (user != null)
		{
			return currencyOperations.CreditRobux(user.Id, amount);
		}
		return 0L;
	}

	public static long GetRobuxHeld(this IUserIdentifier user, ICurrencyAuthority currencyAuthority)
	{
		CurrencyOperations currencyOperations = new CurrencyOperations(currencyAuthority);
		if (user != null)
		{
			return currencyOperations.GetRobuxHeld(user.Id);
		}
		return 0L;
	}
}
