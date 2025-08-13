using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Gets or creates PlatformCurrencyBudgetTransactionTypes.
/// </summary>
public class PlatformCurrencyBudgetTransactionTypeFactory : IPlatformCurrencyBudgetTransactionTypeFactory
{
	/// <summary>
	/// Gets or creates a PlatformCurrencyBudgetTransactionType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>New or existing PlatformCurrencyBudgetTransactionType.</returns>
	public IPlatformCurrencyBudgetTransactionType GetOrCreate(string id)
	{
		CurrencyBudgetTransactionType currenctyBudgetTransactionType = CurrencyBudgetTransactionType.GetOrCreate(id);
		return new PlatformCurrencyBudgetTransactionType(currenctyBudgetTransactionType.ID, currenctyBudgetTransactionType.Value);
	}

	/// <summary>
	/// Gets the an existing PlatformCurrencyBudgetTransactionType.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>Existing PlatformCurrencyBudgetTransactionType or null if it does not exist.</returns>
	public IPlatformCurrencyBudgetTransactionType Get(int id)
	{
		CurrencyBudgetTransactionType currenctyBudgetTransactionType = CurrencyBudgetTransactionType.Get(id);
		return new PlatformCurrencyBudgetTransactionType(currenctyBudgetTransactionType.ID, currenctyBudgetTransactionType.Value);
	}
}
