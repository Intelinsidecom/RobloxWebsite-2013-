namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Budget types.
/// </summary>
public interface IPlatformCurrencyBudgetType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	int ID { get; }

	/// <summary>
	/// Gets or sets the currency budget type.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	string Value { get; set; }
}
