using System;
using Roblox.Billing.Entities;

namespace Roblox.Billing;

internal class WindowsStorePaymentDataAccessor : IWindowsStorePaymentDataAccessor
{
	public IWindowsStorePayment GetByTransactionId(Guid transactionId)
	{
		return Translate(Roblox.Billing.Entities.WindowsStorePayment.GetByTransactionID(transactionId.ToString("N")));
	}

	public IWindowsStorePayment CreateNew(long paymentId, Guid transactionId, DateTime purchaseDate, string receipt)
	{
		Roblox.Billing.Entities.WindowsStorePayment entity = new Roblox.Billing.Entities.WindowsStorePayment
		{
			PaymentID = paymentId,
			PurchaseDate = purchaseDate,
			Receipt = receipt,
			TransactionID = transactionId.ToString("N")
		};
		entity.Save();
		return Translate(entity);
	}

	public IWindowsStorePayment GetByPaymentId(long paymentId)
	{
		Roblox.Billing.Entities.WindowsStorePayment entity = Roblox.Billing.Entities.WindowsStorePayment.GetByPaymentID(paymentId);
		return Translate(entity);
	}

	private WindowsStorePayment Translate(Roblox.Billing.Entities.WindowsStorePayment entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new WindowsStorePayment
		{
			Id = entity.ID,
			TransactionId = new Guid(entity.TransactionID),
			PaymentId = entity.PaymentID,
			PurchaseDate = entity.PurchaseDate,
			Receipt = entity.Receipt
		};
	}
}
