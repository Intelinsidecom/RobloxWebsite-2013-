using System.Collections.Generic;

namespace Roblox.LiveGamer;

public class LiveGamerTransactionInfo
{
	public byte PaymentStatusId { get; set; }

	public int UserId { get; set; }

	public int InternalPaymentId { get; set; }

	public int PurchaseOrderId { get; set; }

	public IEnumerable<LiveGamerLineItem> LineItems { get; set; }

	public string PaymentType { get; set; }

	public string TaxModel { get; set; }

	public string Currency { get; set; }

	public decimal AmountPaid { get; set; }

	public decimal Price { get; set; }

	public decimal Tax { get; set; }

	public string CallbackXmlContent { get; set; }

	public string Signature { get; set; }
}
