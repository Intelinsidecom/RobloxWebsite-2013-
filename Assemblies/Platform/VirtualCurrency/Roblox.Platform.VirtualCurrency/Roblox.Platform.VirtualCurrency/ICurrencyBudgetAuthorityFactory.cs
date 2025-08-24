namespace Roblox.Platform.VirtualCurrency;

/// <summary>
/// A factory to get the correct implementation of the <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" /> for the given platform type. 
/// This returns a default <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyOperations" /> if the platformType is not registered with this factory.
/// For all platforms except Xbox, the default implementation is fine. 
/// Components that use this on XBox MUST register Xbox with the correct implementation which can be found at Roblox.Platform.XboxLive.XboxCurrencyBudgetAuthority.
/// TODO Update the above two comments if they are no longer accurate.
/// </summary>
public interface ICurrencyBudgetAuthorityFactory
{
	/// <summary>
	/// A method to register an implementation of <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" /> with the given platformTypeId.
	/// </summary>
	/// <param name="platformTypeId">The platformTypeId to register.</param>
	/// <param name="currencyBudgetAuthority">The implementation of <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" />to register for the given platformTypeId.</param>
	void Register(byte platformTypeId, ICurrencyBudgetAuthority currencyBudgetAuthority);

	/// <summary>
	/// A method to get the <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" /> for the given platformTypeId.
	/// </summary>
	/// <param name="platformTypeId">The platformTypeId toge the <see cref="T:Roblox.Platform.VirtualCurrency.ICurrencyBudgetAuthority" /> for.</param>
	/// <returns></returns>
	ICurrencyBudgetAuthority GetCurrencyBudgetAuthority(byte platformTypeId);
}
