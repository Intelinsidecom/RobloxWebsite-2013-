using System;
using Roblox.Currency.Client;

namespace Roblox.Economy.Common;

public static class UserBalance
{
	private static ICurrencyAuthority _Client;

	public static ICurrencyAuthority Client
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
		return Client.TryDebitRobux(userId, amount);
	}
}
