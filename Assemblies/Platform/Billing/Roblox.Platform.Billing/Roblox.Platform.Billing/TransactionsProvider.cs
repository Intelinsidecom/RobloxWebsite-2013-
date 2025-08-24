using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;

namespace Roblox.Platform.Billing;

public class TransactionsProvider : ITransactionsProvider
{
	protected virtual byte CreditPaymentProviderTypeId => Roblox.Billing.PaymentProviderType.Credit.ID;

	protected virtual IPayment GetPayment(long paymentId)
	{
		return Payment.Get(paymentId);
	}

	protected virtual byte TranslateToBillingPaymentStatusTypeId(PaymentStatusType paymentStatusType)
	{
		return paymentStatusType switch
		{
			PaymentStatusType.Blocked => Roblox.Billing.PaymentStatusType.Blocked.ID, 
			PaymentStatusType.ChargedBack => Roblox.Billing.PaymentStatusType.ChargedBack.ID, 
			PaymentStatusType.Complete => Roblox.Billing.PaymentStatusType.Complete.ID, 
			PaymentStatusType.Error => Roblox.Billing.PaymentStatusType.Error.ID, 
			PaymentStatusType.Pending => Roblox.Billing.PaymentStatusType.Pending.ID, 
			PaymentStatusType.Refunded => Roblox.Billing.PaymentStatusType.Refunded.ID, 
			_ => throw new ApplicationException($"Unknown PaymentStatusType: {paymentStatusType}"), 
		};
	}

	public int GetTransactionsCountByAccountId(int accountId)
	{
		return TransactionLog.GetTransactionLogsByUserAccountID(accountId).Count;
	}

	public int GetTransactionsCountByAccountIdAndPaymentStatusType(int accountId, PaymentStatusType paymentStatusType)
	{
		byte paymentStatusTypeEntityId = TranslateToBillingPaymentStatusTypeId(paymentStatusType);
		return TransactionLog.GetCountByUserAccountIDAndPaymentStatusTypeID(accountId, paymentStatusTypeEntityId);
	}

	public int GetTransactionsCountByEmailAndPaymentStatusType(string email, PaymentStatusType paymentStatusType)
	{
		byte paymentStatusTypeEntityId = TranslateToBillingPaymentStatusTypeId(paymentStatusType);
		return TransactionLog.GetCountByEmailAndPaymentStatusTypeID(email, paymentStatusTypeEntityId);
	}

	public int GetTransactionsCountByAddressCityZipPostalCountryAndPaymentStatusType(string addressLine1, string city, string zipPostal, string country, PaymentStatusType paymentStatusType)
	{
		byte paymentStatusTypeEntityId = TranslateToBillingPaymentStatusTypeId(paymentStatusType);
		return TransactionLog.GetCountByAddressCityZipPostalCountryAndPaymentStatusTypeID(addressLine1, city, zipPostal, country, paymentStatusTypeEntityId);
	}

	public int GetTransactionsCountByNumberPaymentStatusTypeAccountIdAndCreatedBeforeDate(string number, PaymentStatusType paymentStatusType, int accountId, DateTime date)
	{
		byte paymentStatusTypeEntityId = TranslateToBillingPaymentStatusTypeId(paymentStatusType);
		return TransactionLog.GetCountByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate(number, paymentStatusTypeEntityId, accountId, date);
	}

	public IEnumerable<ITransactionLog> GetCompletedTransactionsInTheLastMonthExcludingStoreCreditByAccountId(int accountId)
	{
		return TransactionLog.GetTransactionLogsByUserAccountID(accountId, DateTime.Now.AddMonths(-1)).Where(IsPaymentCompleteAndNotPaidWithStoreCredit);
	}

	public IEnumerable<ITransactionLog> GetTransactionsByAccountIdAndCreatedAfterDate(int accountId, DateTime date)
	{
		return TransactionLog.GetTransactionLogsByUserAccountIDAndCreatedAfterDate(accountId, date);
	}

	public IEnumerable<ITransactionLog> GetPendingAndCompletedTransactionsByAccountIdAndCreatedAfterDate(int accountId, DateTime date)
	{
		return from x in TransactionLog.GetTransactionLogsByUserAccountIDAndCreatedAfterDate(accountId, date)
			where x.PaymentStatusTypeID == TranslateToBillingPaymentStatusTypeId(PaymentStatusType.Complete) || x.PaymentStatusTypeID == TranslateToBillingPaymentStatusTypeId(PaymentStatusType.Pending)
			select x;
	}

	public IEnumerable<ITransactionLog> GetTransactionLogsByEmailAndCreatedAfterDate(string email, DateTime createDateTime)
	{
		return TransactionLog.GetTransactionLogsByEmailAndCreatedAfterDate(email, createDateTime);
	}

	public IEnumerable<ITransactionLog> GetPendingAndCompletedTransactionsByEmailAndCreatedAfterDate(string email, DateTime date)
	{
		IEnumerable<ITransactionLog> transactionLogsByEmailAndCreatedAfterDate = GetTransactionLogsByEmailAndCreatedAfterDate(email, date);
		byte completeId = TranslateToBillingPaymentStatusTypeId(PaymentStatusType.Complete);
		byte pendingId = TranslateToBillingPaymentStatusTypeId(PaymentStatusType.Pending);
		return transactionLogsByEmailAndCreatedAfterDate.Where((ITransactionLog t) => t.PaymentStatusTypeID == completeId || t.PaymentStatusTypeID == pendingId);
	}

	public bool IsPaymentCompleteAndNotPaidWithStoreCredit(ITransactionLog transactionLog)
	{
		if (transactionLog.PaymentStatusTypeID == TranslateToBillingPaymentStatusTypeId(PaymentStatusType.Complete) && transactionLog.TransactionDate.HasValue)
		{
			return GetPayment(transactionLog.PaymentID).PaymentProviderTypeID != CreditPaymentProviderTypeId;
		}
		return false;
	}
}
