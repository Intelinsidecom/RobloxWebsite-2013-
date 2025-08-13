namespace Roblox.Platform.CurrencyBudgets;

/// <summary>
/// Makes or gets PlatformCurrencyBudget instances
///
/// This is misnamed, it's an ICurrencyBudgetFactory that only creates PlatformCurrencyBudgets. 
/// This is for legacy reasons.
/// </summary>
public interface ICurrencyBudgetFactory
{
	/// <summary>
	/// Gets or creates a new currency budget.
	/// </summary>
	/// <param name="currencyBudgetType">Type of the currency budget.</param>
	/// <param name="currencyTypeId">The currency type identifier.</param>
	/// <param name="currencyHolderType">Type of the currency holder.</param>
	/// <param name="currencyHolderTargetId">The currency holder target identifier.</param>
	/// <returns>A new PlatformCurrencyBudget</returns>
	IPlatformCurrencyBudget GetOrCreate(string currencyBudgetType, byte currencyTypeId, string currencyHolderType, long currencyHolderTargetId);

	/// <summary>
	/// Gets an existing PlatformCurrencyBudget.
	/// </summary>
	/// <param name="id">The identifier.</param>
	/// <returns>Existing CurrencyBudged or null.</returns>
	ICurrencyBudget Get(long id);
}
