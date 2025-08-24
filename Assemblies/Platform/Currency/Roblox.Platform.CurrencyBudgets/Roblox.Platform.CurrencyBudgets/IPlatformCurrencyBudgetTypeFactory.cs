namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets PlatformCurrencyBudgetTypes.
/// </summary>
public interface IPlatformCurrencyBudgetTypeFactory
{
	/// <summary>
	/// Gets an existing PlatformCurrencyBudgetType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>An existing PlatformCurrencyBudgetType or null.</returns>
	IPlatformCurrencyBudgetType Get(int id);
}
