namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
/// </summary>
public interface IPlatformCurrencyBudget
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long Id { get; }

	/// <summary>
	/// Gets the budget value.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	long Value { get; }

	/// <summary>
	/// Gets the type of the currency budget.
	/// </summary>
	/// <value>
	/// The type of the currency budget.
	/// </value>
	string CurrencyBudgetType { get; }

	/// <summary>
	/// Gets the currency type identifier.
	/// </summary>
	/// <value>
	/// The currency type identifier.
	/// </value>
	byte CurrencyTypeId { get; }

	/// <summary>
	/// Gets the type of the currency holder.
	/// </summary>
	/// <value>
	/// The type of the currency holder.
	/// </value>
	string CurrencyHolderType { get; }

	/// <summary>
	/// Gets the currency holder target identifier.
	/// </summary>
	/// <value>
	/// The currency holder target identifier.
	/// </value>
	long CurrencyHolderTargetId { get; }

	/// <summary>
	/// Credits the specified amount to the CurrencyBudget.
	/// </summary>
	/// <param name="amount">The amount.</param>
	/// <param name="transactionType">Type of the transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	void Credit(long amount, string transactionType, long transactionTargetId);

	/// <summary>
	/// Tries to debit from the CurrencyBudget. Returns true if the debit succeeded, 
	/// false if there was not enough money in the CurrencyBudget to cover the amount.
	/// </summary>
	/// <param name="amount">The amount to debit.</param>
	/// <param name="transactionType">Type of transaction.</param>
	/// <param name="transactionTargetId">The transaction target identifier.</param>
	/// <returns>true if the debit succeeded, 
	/// false if the amount was greater than the current credit.</returns>
	bool Debit(long amount, string transactionType, long transactionTargetId);
}
