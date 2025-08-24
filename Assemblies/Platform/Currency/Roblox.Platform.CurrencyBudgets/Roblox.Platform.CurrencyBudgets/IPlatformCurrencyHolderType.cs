namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Types of currency holders.
/// </summary>
public interface IPlatformCurrencyHolderType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	int ID { get; }

	/// <summary>
	/// Gets or sets the currency holder type.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	string Value { get; set; }
}
