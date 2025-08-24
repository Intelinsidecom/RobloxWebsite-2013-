namespace Roblox.Platform.VirtualCurrency;

/// <summary>
/// A generic interface to provide currency operations for Virtual Economy independent of platform.
/// The implementation of this interface varies depending on what currency system is used by the platform it is implemented for.
/// This is necessary for walled gardens where we need to keep currency separate across platforms.
/// This interface presumes we only have once type of currency (robux) in our virtual economy. The interface should be updated if that changes.
/// </summary>
public interface ICurrencyBudgetAuthority
{
	/// <summary>
	/// A method to obtain the currenct balance for the given userId.
	/// </summary>
	/// <param name="userId">The Id of the user.</param>
	/// <returns>The current balance of the user in robux.</returns>
	long GetBalance(long userId);

	/// <summary>
	/// A method to check if the the the user has at least as much balance given a certain amount.
	/// </summary>
	/// <param name="userId">The Id of the user.</param>
	/// <param name="amount">The amount to check against.</param>
	/// <returns>A boolean representing whether the user has at least as much balance as the amount.</returns>
	bool VerifyBalanceIsSufficient(long userId, long amount);

	/// <summary>
	/// A method to credit a given amount of our virtual currency to given userId.
	/// </summary>
	/// <param name="userId">The Id of the user.</param>
	/// <param name="amount">The amount to credit to the user.</param>
	/// <param name="saleId">The Id of the sale for which this operation is being performed.</param>
	void CreditBalance(long userId, long amount, long? saleId);

	/// <summary>
	/// A method to debit amount from the given user's balance.
	/// </summary>
	/// <param name="userId">The Id of the user.</param>
	/// <param name="amount">The amount to debit from the user's balance.</param>
	/// <param name="saleId">The Id of the sale for which this operation is being performed.</param>
	/// <returns>Whether the amount was successfully debited from the user's balance.</returns>
	bool TryDebitBalance(long userId, long amount, long? saleId);
}
