using System;

namespace Roblox.Billing;

public class WindowsStorePayment : IWindowsStorePayment
{
	public long Id { get; set; }

	public long PaymentId { get; set; }

	public Guid TransactionId { get; set; }

	public DateTime PurchaseDate { get; set; }

	public string Receipt { get; set; }

	public string ProductId { get; set; }
}
