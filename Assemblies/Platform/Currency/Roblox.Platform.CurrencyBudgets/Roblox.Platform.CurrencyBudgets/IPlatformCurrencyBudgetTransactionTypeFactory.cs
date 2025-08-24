namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets or creates PlatformCurrencyBudgetTransactionTypes.
/// </summary>
public interface IPlatformCurrencyBudgetTransactionTypeFactory
{
	/// <summary>
	/// Gets or creates a PlatformCurrencyBudgetTransactionType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>New or existing PlatformCurrencyBudgetTransactionType.</returns>
	IPlatformCurrencyBudgetTransactionType GetOrCreate(string id);

	/// <summary>
	/// Gets the an existing PlatformCurrencyBudgetTransactionType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>Existing PlatformCurrencyBudgetTransactionType or null if it does not exist.</returns>
	IPlatformCurrencyBudgetTransactionType Get(int id);
}
