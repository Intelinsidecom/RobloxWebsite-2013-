using System;

namespace Roblox.Billing;

public interface IWindowsStorePayment
{
	long Id { get; }

	long PaymentId { get; }

	Guid TransactionId { get; }

	DateTime PurchaseDate { get; }

	string Receipt { get; }
}
