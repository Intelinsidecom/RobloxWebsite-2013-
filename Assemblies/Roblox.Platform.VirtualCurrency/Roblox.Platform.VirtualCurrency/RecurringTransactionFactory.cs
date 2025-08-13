using Roblox.Currency.Client;

namespace Roblox.Platform.VirtualCurrency;

public class RecurringTransactionFactory : IRecurringTransactionFactory
{
	private readonly ICurrencyAuthority _CurrencyAuthority;

	public RecurringTransactionFactory(ICurrencyAuthority currencyAuthority)
	{
		_CurrencyAuthority = currencyAuthority;
	}

	/// <summary>
	/// Cancels the recurring transaction
	/// NOTE : Make sure the callee of this method has the right set of permissions to cancel the transaction.
	/// </summary>
	/// <param name="id">Id of the recurring transaction to be cancelled.</param>
	/// <returns></returns>
	public bool CancelRecurringTransactionProfile(string id)
	{
		return _CurrencyAuthority.CancelRecurringTransaction(id);
	}

	/// <summary>
	/// Gets the recurring transaction
	/// NOTE : Make sure the callee of this method has the right set of permissions to view the recurring transaction.
	/// </summary>
	/// <param name="id">Id of the recurring transaction to be viewed.</param>
	/// <returns></returns>
	public IRecurringTransactionProfile GetRecurringTransactionProfile(string id)
	{
		RecurringTransactionProfileDetails profileDetails = _CurrencyAuthority.GetRecurringTransactionProfile(id);
		return new RecurringTransactionProfile
		{
			Id = profileDetails.RecurringTransactionProfileId,
			CurrencyTypeId = profileDetails.CurrencyTypeId,
			RecurrenceStartDate = profileDetails.RecurrenceStartDate,
			RecurrenceEndDate = profileDetails.RecurrenceEndDate,
			CurrencyHolderTypeId = profileDetails.CurrencyHolderTypeId,
			CurrencyHolderTargetId = profileDetails.CurrencyHolderTargetId,
			TransactionTypeId = profileDetails.TransactionTypeId,
			Amount = profileDetails.Amount
		};
	}
}
