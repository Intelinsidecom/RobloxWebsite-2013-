namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Creates PlatformCurrencyBudgetTransactions
/// </summary>
public interface IPlatformCurrencyBudgetTransactionFactory
{
	/// <summary>
	/// Creates a new CurrencyBudgetTransaction.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="delta">The transaction delta.</param>
	/// <param name="currencyBudgetTransactionTypeId">The currency budget transaction type identifier.</param>
	/// <param name="currencyBudgetTransactionTargetId">The currency budget transaction target identifier.</param>
	/// <returns>A new CurrencyBudgetTransaction.</returns>
	ICurrencyBudgetTransaction CreateNew(long currencyBudgetId, long delta, int currencyBudgetTransactionTypeId, long currencyBudgetTransactionTargetId);
}
