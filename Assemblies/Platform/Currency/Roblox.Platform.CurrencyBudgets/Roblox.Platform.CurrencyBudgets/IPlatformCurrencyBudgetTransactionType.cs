namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Types of transactions.
/// </summary>
public interface IPlatformCurrencyBudgetTransactionType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	int ID { get; }

	/// <summary>
	/// Gets or sets the transaction type value.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	string Value { get; set; }
}
