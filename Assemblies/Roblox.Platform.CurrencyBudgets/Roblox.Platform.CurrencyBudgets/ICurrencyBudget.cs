namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Tracks the amount and transactions of a currency for a given holder.
///
/// This interface is required so the tests can mock out the db interaction and 
/// emulated the logic in the CurrencyBudget Entity and the TryDebit stored procedure. 
/// (yes, there is a TryDebit SP and yes it does validate the value of the amount too)
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudget" />
public interface ICurrencyBudget
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	long ID { get; }

	/// <summary>
	/// Gets or sets the currency budget type identifier.
	/// </summary>
	/// <value>
	/// The currency budget type identifier.
	/// </value>
	int CurrencyBudgetTypeID { get; set; }

	/// <summary>
	/// Gets or sets the currency type identifier.
	/// </summary>
	/// <value>
	/// The currency type identifier.
	/// </value>
	byte CurrencyTypeID { get; set; }

	/// <summary>
	/// Gets or sets the currency holder type identifier.
	/// </summary>
	/// <value>
	/// The currency holder type identifier.
	/// </value>
	int CurrencyHolderTypeID { get; set; }

	/// <summary>
	/// Gets or sets the currency holder target identifier.
	/// </summary>
	/// <value>
	/// The currency holder target identifier.
	/// </value>
	long CurrencyHolderTargetID { get; set; }

	/// <summary>
	/// Gets or sets the value.
	/// </summary>
	/// <value>
	/// The credit value of this budget.
	/// </value>
	long Value { get; set; }

	/// <summary>
	/// Deletes this instance.
	/// </summary>
	void Delete();

	/// <summary>
	/// Saves this instance.
	/// </summary>
	void Save();

	/// <summary>
	/// Credits the specified amount to the CurrencyBudget.
	/// </summary>
	/// <param name="amount">The amount.</param>
	void Credit(long amount);

	/// <summary>
	/// Tries to debit from the CurrencyBudget. Returns true if the debit succeeded, 
	/// false if there was not enough money in the CurrencyBudget to cover the amount.
	/// </summary>
	/// <param name="amount">The amount to debit.</param>
	/// <returns>true if the debit succeeded, 
	/// false if the amount was greater than the current credit.</returns>
	bool TryDebit(long amount);
}
