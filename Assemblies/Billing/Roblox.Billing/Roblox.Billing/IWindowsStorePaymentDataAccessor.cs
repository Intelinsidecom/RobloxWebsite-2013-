using System;

namespace Roblox.Billing;

internal interface IWindowsStorePaymentDataAccessor
{
	IWindowsStorePayment GetByTransactionId(Guid transactionId);

	IWindowsStorePayment CreateNew(long paymentId, Guid transactionId, DateTime purchaseDate, string receipt);

	IWindowsStorePayment GetByPaymentId(long paymentId);
}
