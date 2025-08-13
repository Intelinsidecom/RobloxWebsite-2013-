using System;
using System.Collections.Generic;
using Roblox.Billing;

namespace Roblox.Platform.Billing;

public interface ITransactionsProvider
{
	int GetTransactionsCountByAccountId(int accountId);

	int GetTransactionsCountByAccountIdAndPaymentStatusType(int accountId, PaymentStatusType paymentStatusType);

	int GetTransactionsCountByEmailAndPaymentStatusType(string email, PaymentStatusType paymentStatusType);

	int GetTransactionsCountByAddressCityZipPostalCountryAndPaymentStatusType(string addressLine1, string city, string zipPostal, string country, PaymentStatusType paymentStatusType);

	int GetTransactionsCountByNumberPaymentStatusTypeAccountIdAndCreatedBeforeDate(string number, PaymentStatusType paymentStatusType, int accountId, DateTime date);

	IEnumerable<ITransactionLog> GetCompletedTransactionsInTheLastMonthExcludingStoreCreditByAccountId(int accountId);

	IEnumerable<ITransactionLog> GetTransactionsByAccountIdAndCreatedAfterDate(int accountId, DateTime date);

	IEnumerable<ITransactionLog> GetPendingAndCompletedTransactionsByAccountIdAndCreatedAfterDate(int accountId, DateTime date);

	IEnumerable<ITransactionLog> GetTransactionLogsByEmailAndCreatedAfterDate(string email, DateTime createdDateTime);

	IEnumerable<ITransactionLog> GetPendingAndCompletedTransactionsByEmailAndCreatedAfterDate(string email, DateTime date);

	bool IsPaymentCompleteAndNotPaidWithStoreCredit(ITransactionLog transactionLog);
}
