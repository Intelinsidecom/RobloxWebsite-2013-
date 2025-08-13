using System.Collections.Generic;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets CurrencyBudgetTransactions
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.ICurrencyBudgetFactory" />
public interface ICurrencyBudgetModerationFactory : ICurrencyBudgetFactory
{
	/// <summary>
	/// Gets the total number of currency budget transactions given a budget id.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <returns>The count of transactions.</returns>
	long GetTotalNumberOfCurrencyBudgetTransactions(long currencyBudgetId);

	/// <summary>
	/// Gets the currency budget transactions for a budget id.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <returns>A collection of transactions</returns>
	IEnumerable<ICurrencyBudgetTransaction> GetCurrencyBudgetTransactions(long currencyBudgetId, int pageNumber);

	/// <summary>
	/// Tries to adjust the adjust currency budget.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="amount">The amount.</param>
	/// <param name="transactionType">Type of the transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <returns>True if it succeeds, false otherwise.</returns>
	bool TryAdjustCurrencyBudget(long currencyBudgetId, long amount, string transactionType, long transactionTargetId, out string errorMessage);
}
