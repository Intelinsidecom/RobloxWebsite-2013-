using System;
using Roblox.ApiClientBase;
using Roblox.Currency.Client;
using Roblox.Platform.VirtualCurrency.Properties;
using Roblox.Sentinels;

namespace Roblox.Platform.VirtualCurrency;

public class CurrencyOperations : ICurrencyOperations, ICurrencyBudgetAuthority
{
	private const string _CurrencyServiceUnavailableMessage = "Currency service unavailable";

	private readonly ICurrencyAuthority _CurrencyAuthority;

	public CurrencyOperations(ICurrencyAuthority currencyAuthority)
	{
		_CurrencyAuthority = currencyAuthority ?? throw new ArgumentNullException("currencyAuthority");
	}

	public ICurrencyBalance GetCurrencyBalance(long agentId)
	{
		if (Settings.Default.UseGetCurrencyBalancesServiceMethod)
		{
			try
			{
				return new CurrencyBalance(_CurrencyAuthority.GetCurrencyBalances(agentId));
			}
			catch (Exception ex) when (ex.GetType().IsAssignableFrom(typeof(ApiClientException)) || ex.GetType().IsAssignableFrom(typeof(CircuitBreakerException)) || ex.GetType().IsAssignableFrom(typeof(CurrencyClientException)))
			{
				throw new CurrencyOperationUnavailableException("Currency service unavailable", ex);
			}
		}
		return new CurrencyBalance(_CurrencyAuthority.GetRobuxBalance(agentId));
	}

	public long GetRobuxBalance(long agentId)
	{
		try
		{
			return _CurrencyAuthority.GetRobuxBalance(agentId);
		}
		catch (Exception ex) when (ex.GetType().IsAssignableFrom(typeof(ApiClientException)) || ex.GetType().IsAssignableFrom(typeof(CircuitBreakerException)) || ex.GetType().IsAssignableFrom(typeof(CurrencyClientException)))
		{
			throw new CurrencyOperationUnavailableException("Currency service unavailable", ex);
		}
	}

	public long CreditRobux(long agentId, long amount)
	{
		try
		{
			return _CurrencyAuthority.CreditRobux((long)Convert.ToInt32(agentId), amount);
		}
		catch (Exception ex) when (ex.GetType().IsAssignableFrom(typeof(ApiClientException)) || ex.GetType().IsAssignableFrom(typeof(CircuitBreakerException)) || ex.GetType().IsAssignableFrom(typeof(CurrencyClientException)))
		{
			throw new CurrencyOperationUnavailableException("Currency service unavailable", ex);
		}
	}

	public long GetRobuxHeld(long currencyHolderId)
	{
		try
		{
			return _CurrencyAuthority.GetRobuxHeld((long)Convert.ToInt32(currencyHolderId));
		}
		catch (Exception ex) when (ex.GetType().IsAssignableFrom(typeof(ApiClientException)) || ex.GetType().IsAssignableFrom(typeof(CircuitBreakerException)) || ex.GetType().IsAssignableFrom(typeof(CurrencyClientException)))
		{
			throw new CurrencyOperationUnavailableException("Currency service unavailable", ex);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority.GetBalance(System.Int64)" />
	public long GetBalance(long userId)
	{
		return GetRobuxBalance(userId);
	}

	/// <inheritdoc cref="M:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority.VerifyBalanceIsSufficient(System.Int64,System.Int64)" />
	public bool VerifyBalanceIsSufficient(long userId, long amount)
	{
		return GetRobuxBalance(userId) >= amount;
	}

	/// <inheritdoc cref="M:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority.CreditBalance(System.Int64,System.Int64,System.Nullable{System.Int64})" />
	public void CreditBalance(long userId, long amount, long? saleId)
	{
		CreditRobux(userId, amount);
	}

	/// <inheritdoc cref="M:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority.TryDebitBalance(System.Int64,System.Int64,System.Nullable{System.Int64})" />
	public bool TryDebitBalance(long userId, long amount, long? saleId)
	{
		return _CurrencyAuthority.TryDebitRobux((long)(int)userId, amount);
	}
}
