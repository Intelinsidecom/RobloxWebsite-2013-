using System;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Types of currency holders.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyHolderType" />
public class PlatformCurrencyHolderType : IPlatformCurrencyHolderType
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	public int ID { get; }

	/// <summary>
	/// Gets or sets the currency holder type.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	public string Value { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.CurrencyBudgets.PlatformCurrencyHolderType" /> class.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <param name="value">The holder type.</param>
	/// <exception cref="T:System.ArgumentNullException">Value can not be null.</exception>
	public PlatformCurrencyHolderType(int id, string value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value", "Value can not be null.");
		}
		ID = id;
		Value = value;
	}
}
