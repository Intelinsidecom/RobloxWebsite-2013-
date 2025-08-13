using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Creates PlatformCurrencyBudgetTransactions
/// </summary>
public class PlatformCurrencyBudgetTransactionFactory : IPlatformCurrencyBudgetTransactionFactory
{
	/// <summary>
	/// Creates a new CurrencyBudgetTransaction.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="delta">The transaction delta.</param>
	/// <param name="currencyBudgetTransactionTypeId">The currency budget transaction type identifier.</param>
	/// <param name="currencyBudgetTransactionTargetId">The currency budget transaction target identifier.</param>
	/// <returns>A new CurrencyBudgetTransaction.</returns>
	public ICurrencyBudgetTransaction CreateNew(long currencyBudgetId, long delta, int currencyBudgetTransactionTypeId, long currencyBudgetTransactionTargetId)
	{
		return new PlatformCurrencyBudgetTransaction(CurrencyBudgetTransaction.CreateNew(currencyBudgetId, delta, currencyBudgetTransactionTypeId, currencyBudgetId));
	}
}
