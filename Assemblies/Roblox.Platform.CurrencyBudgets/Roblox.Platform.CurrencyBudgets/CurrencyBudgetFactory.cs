using Roblox.Platform.CurrencyBudgets.Entities;

namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Makes or gets PlatformCurrencyBudget instances.
///
/// This is misnamed, it's an ICurrencyBudgetFactory that only creates PlatformCurrencyBudgets. 
/// This is for legacy reasons.
/// </summary>
/// <seealso cref="T:Roblox.Platform.CurrencyBudgets.ICurrencyBudgetFactory" />
public class CurrencyBudgetFactory : ICurrencyBudgetFactory
{
	/// <summary>
	/// Creates a new currency budget.
	/// </summary>
	/// <param name="currencyBudgetType">Type of the currency budget.</param>
	/// <param name="currencyTypeId">The currency type identifier.</param>
	/// <param name="currencyHolderType">Type of the currency holder.</param>
	/// <param name="currencyHolderTargetId">The currency holder target identifier.</param>
	/// <returns>A new PlatformCurrencyBudget</returns>
	public IPlatformCurrencyBudget GetOrCreate(string currencyBudgetType, byte currencyTypeId, string currencyHolderType, long currencyHolderTargetId)
	{
		CurrencyBudgetType orCreate = CurrencyBudgetType.GetOrCreate(currencyBudgetType);
		return new PlatformCurrencyBudget(CurrencyBudget.GetOrCreate(currencyHolderTypeId: CurrencyHolderType.GetOrCreate(currencyHolderType).ID, currencyBudgetTypeId: orCreate.ID, currencyTypeId: currencyTypeId, currencyHolderTargetId: currencyHolderTargetId));
	}

	/// <summary>
	/// Gets an existing PlatformCurrencyBudget.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>
	/// Existing CurrencyBudged or null.
	/// </returns>
	public ICurrencyBudget Get(long id)
	{
		return CurrencyBudget.Get(id);
	}
}
