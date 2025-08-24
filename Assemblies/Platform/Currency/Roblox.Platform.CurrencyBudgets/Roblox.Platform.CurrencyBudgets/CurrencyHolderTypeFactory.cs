using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets PlatformCurrencyHolderType.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyHolderTypeFactory" />
public class CurrencyHolderTypeFactory : IPlatformCurrencyHolderTypeFactory
{
	/// <summary>
	/// Gets an existing PlatformCurrencyHolderType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>An existing PlatformCurrencyHolderType or null.</returns>
	public IPlatformCurrencyHolderType Get(int id)
	{
		CurrencyHolderType currencyHolderType = CurrencyHolderType.Get(id);
		return new PlatformCurrencyHolderType(id, currencyHolderType.Value);
	}
}
