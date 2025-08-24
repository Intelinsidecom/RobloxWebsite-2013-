using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets PlatformCurrencyBudgetTypes.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.IPlatformCurrencyBudgetTypeFactory" />
public class CurrencyBudgetTypeFactory : IPlatformCurrencyBudgetTypeFactory
{
	/// <summary>
	/// Gets an existing PlatformCurrencyBudgetType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>An existing PlatformCurrencyBudgetType or null.</returns>
	public IPlatformCurrencyBudgetType Get(int id)
	{
		CurrencyBudgetType currencyBudgetType = CurrencyBudgetType.Get(id);
		return new PlatformCurrencyBudgetType(id, currencyBudgetType.Value);
	}
}
