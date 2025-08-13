using System;
using System.Collections.Generic;

namespace Roblox.BillingTransactionEventPublisher;

public class BillingTransactionMessage
{
	public long? PurchaserUserID;

	public decimal Amount;

	public byte CurrencyTypeID;

	public byte PaymentProviderTypeID;

	public long PaymentID;

	public List<int> ProductIDs;

	public DateTime PaymentDate;

	public BillingTransactionType TransactionType;
}
