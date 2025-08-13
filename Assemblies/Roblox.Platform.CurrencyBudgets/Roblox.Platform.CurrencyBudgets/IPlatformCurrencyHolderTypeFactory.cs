namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets PlatformCurrencyHolderType.
/// </summary>
public interface IPlatformCurrencyHolderTypeFactory
{
	/// <summary>
	/// Gets an existing PlatformCurrencyHolderType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>An existing PlatformCurrencyHolderType or null.</returns>
	IPlatformCurrencyHolderType Get(int id);
}
