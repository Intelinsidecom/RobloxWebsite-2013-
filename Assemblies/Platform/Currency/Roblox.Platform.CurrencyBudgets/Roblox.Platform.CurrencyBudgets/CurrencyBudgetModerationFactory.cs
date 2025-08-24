using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets CurrencyBudgetTransactions
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.ICurrencyBudgetFactory" />
public class CurrencyBudgetModerationFactory : ICurrencyBudgetModerationFactory, ICurrencyBudgetFactory
{
	/// <summary>
	/// Creates a new currency budget.
	/// </summary>
	/// <param name="currencyBudgetType">Type of the currency budget.</param>
	/// <param name="currencyTypeId">The currency type identifier.</param>
	/// <param name="currencyHolderType">Type of the currency holder.</param>
	/// <param name="currencyHolderTargetId">The currency holder target identifier.</param>
	/// <returns>
	/// A new PlatformCurrencyBudget
	/// </returns>
	public IPlatformCurrencyBudget GetOrCreate(string currencyBudgetType, byte currencyTypeId, string currencyHolderType, long currencyHolderTargetId)
	{
		CurrencyBudgetType orCreate = CurrencyBudgetType.GetOrCreate(currencyBudgetType);
		CurrencyBudget budgetEntity = CurrencyBudget.GetByCurrencyBudgetTypeIDCurrencyTypeIDCurrencyHolderTypeIDAndCurrencyHolderTargetID(currencyHolderTypeId: CurrencyHolderType.GetOrCreate(currencyHolderType).ID, currencyBudgetTypeId: orCreate.ID, currencyTypeId: currencyTypeId, currencyHolderTargetId: currencyHolderTargetId);
		if (budgetEntity == null)
		{
			return null;
		}
		return new PlatformCurrencyBudget(budgetEntity);
	}

	/// <summary>
	/// Gets the total number of currency budget transactions given a budget id.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <returns>The count of transactions.</returns>
	public long GetTotalNumberOfCurrencyBudgetTransactions(long currencyBudgetId)
	{
		return CurrencyBudgetTransaction.GetTotalNumberOfCurrencyBudgetTransactionsByCurrencyBudgetId(currencyBudgetId);
	}

	/// <summary>
	/// Gets the currency budget transactions for a budget id.
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="pageNumber">The page number.</param>
	/// <returns>A collection of transactions</returns>
	public IEnumerable<ICurrencyBudgetTransaction> GetCurrencyBudgetTransactions(long currencyBudgetId, int pageNumber)
	{
		int startRow = (pageNumber - 1) * 50;
		return from cbt in CurrencyBudgetTransaction.GetCurrencyBudgetTransactionsByCurrencyBudgetIDPaged(currencyBudgetId, startRow, 50L)
			select new PlatformCurrencyBudgetTransaction(cbt);
	}

	/// <summary>
	/// Tries to adjust the adjust currency budget.
	///
	/// Ideally this method should be eliminated in favor of using the correct Credit and Debit methods on PlatformCurrencyBudget, however: 
	///
	/// This is used by the endpoint "/users/adjust-xbox-currency-budget" which passes in a const string transactionType of "CS Adjustment"
	/// which isn't part of any defined Type and is used to record both credits and debits, which is terrible.
	///
	/// It's also used by DebitXboxStep.Rollback which passes in a null for transactoinType, which is worse.
	///
	/// These facts make it impossible to convert this method to using the proper PlatformCurrencyBudget classes without a major refactor.
	///
	/// TODO: Get rid of this method
	/// </summary>
	/// <param name="currencyBudgetId">The currency budget identifier.</param>
	/// <param name="amount">The amount.</param>
	/// <param name="transactionType">Type of the transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	/// <param name="errorMessage">The error message.</param>
	/// <returns>True if it succeeds, false otherwise.</returns>
	public bool TryAdjustCurrencyBudget(long currencyBudgetId, long amount, string transactionType, long transactionTargetId, out string errorMessage)
	{
		errorMessage = string.Empty;
		CurrencyBudget currencyBudget = CurrencyBudget.Get(currencyBudgetId);
		if (currencyBudget == null)
		{
			errorMessage = "No Currency Budget exists with that ID.";
			return false;
		}
		if (amount > 0)
		{
			currencyBudget.Credit(amount);
		}
		else
		{
			if (amount >= 0)
			{
				errorMessage = "Cannot adjust Currency Budget by zero.";
				return false;
			}
			if (!currencyBudget.TryDebit(amount * -1))
			{
				errorMessage = "Cannot reduce Currency Budget value below zero.";
				return false;
			}
		}
		if (!string.IsNullOrEmpty(transactionType))
		{
			CurrencyBudgetTransactionType currencyBudgetTransactionType = CurrencyBudgetTransactionType.GetOrCreate(transactionType);
			CurrencyBudgetTransaction.CreateNew(currencyBudgetId, amount, currencyBudgetTransactionType.ID, transactionTargetId);
		}
		return true;
	}

	/// <summary>
	/// Gets an existing PlatformCurrencyBudget.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>
	/// Existing CurrencyBudged or null.
	/// </returns>
	public ICurrencyBudget Get(long id)
	{
		return CurrencyBudget.Get(id);
	}
}
