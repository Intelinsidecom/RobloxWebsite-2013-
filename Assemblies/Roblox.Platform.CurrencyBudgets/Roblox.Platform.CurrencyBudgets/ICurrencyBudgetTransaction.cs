using System;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
/// </summary>
public interface ICurrencyBudgetTransaction
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long Id { get; }

	/// <summary>
	/// Gets the currency budget identifier.
	/// </summary>
	/// <value>
	/// The currency budget identifier.
	/// </value>
	long CurrencyBudgetId { get; }

	/// <summary>
	/// Gets the delta of the transaction.
	/// </summary>
	/// <value>
	/// The delta.
	/// </value>
	long Delta { get; }

	/// <summary>
	/// Gets the currency budget transaction type identifier.
	/// </summary>
	/// <value>
	/// The currency budget transaction type identifier.
	/// </value>
	int CurrencyBudgetTransactionTypeId { get; }

	/// <summary>
	/// Gets the type of the currency budget transaction.
	/// </summary>
	/// <value>
	/// The type of the currency budget transaction.
	/// </value>
	string CurrencyBudgetTransactionType { get; }

	/// <summary>
	/// Gets the currency budget transaction target identifier.
	/// </summary>
	/// <value>
	/// The currency budget transaction target identifier.
	/// </value>
	long CurrencyBudgetTransactionTargetId { get; }

	/// <summary>
	/// Gets the date and time this transaction happened.
	/// </summary>
	/// <value>
	/// The created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Deletes this transaction.
	/// </summary>
	void Delete();
}
