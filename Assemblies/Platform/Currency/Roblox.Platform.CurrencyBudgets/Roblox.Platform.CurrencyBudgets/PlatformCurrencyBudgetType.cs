using System;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Budget types.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudgetType" />
public class PlatformCurrencyBudgetType : IPlatformCurrencyBudgetType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	public int ID { get; }

	/// <summary>
	/// Gets or sets the currency budget type.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	public string Value { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyBudgetType" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="value">The budget type.</param>
	/// <exception cref="T:System.ArgumentNullException">Value can not be null.</exception>
	public PlatformCurrencyBudgetType(int id, string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value", "Value can not be null.");
		}
		ID = id;
		Value = value;
	}
}
