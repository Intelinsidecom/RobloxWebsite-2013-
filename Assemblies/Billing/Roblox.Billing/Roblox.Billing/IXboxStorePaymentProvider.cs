using System;
using System.Collections.Generic;
using Roblox.EventLog;

namespace Roblox.Billing;

public interface IXboxStorePaymentProvider
{
	IReadOnlyCollection<Sale> ProcessPendingTransactions(IPurchaser purchaser, Func<XboxStorePayment, bool> consumeOrVerifyConsumption, ILogger logger = null);

	IReadOnlyCollection<Sale> Process(IPurchaser purchaser, string transactionId, string titleId, string xboxStoreProductId, string consumableUrl, string sandboxId, DateTime purchasedDate, Func<XboxStorePayment, bool> consumeOrVerifyConsumption, ILogger logger = null);
}
