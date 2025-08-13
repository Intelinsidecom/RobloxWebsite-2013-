using System;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Types of transactions.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudgetTransactionType" />
public class PlatformCurrencyBudgetTransactionType : IPlatformCurrencyBudgetTransactionType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	public int ID { get; }

	/// <summary>
	/// Gets or sets the transaction type value.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	public string Value { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyBudgetTransactionType" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="value">The type.</param>
	public PlatformCurrencyBudgetTransactionType(int id, string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value", "Value can not be null.");
		}
		ID = id;
		Value = value;
	}
}
