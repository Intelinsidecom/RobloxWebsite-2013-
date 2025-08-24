using System;
using Roblox.Platform.VirtualCurrency;

namespace Roblox.Economy.Common;

public static class UserBalance
{
	private static ICurrencyOperations _Client;

	public static ICurrencyOperations Client
	{
		get
		{
			return _Client ?? throw new ApplicationException("Client for UserBalance has not been initialized");
		}
		set
		{
			_Client = value;
		}
	}

	public static long GetRobuxBalance(long userId)
	{
		return Client.GetRobuxBalance(userId);
	}

	public static long CreditRobux(long userId, long amount)
	{
		return Client.CreditRobux(userId, amount);
	}

	public static bool TryDebitRobux(long userId, long amount)
	{
		// ICurrencyOperations doesn't expose debit; use ICurrencyBudgetAuthority
		var budget = Client as ICurrencyBudgetAuthority
			?? throw new ApplicationException("Client does not implement ICurrencyBudgetAuthority");
		return budget.TryDebitBalance(userId, amount, null);
	}
}
