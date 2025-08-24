using System;
using System.Collections.Generic;
using Roblox.Billing;
using Roblox.EventLog;

namespace Roblox.Platform.Billing;

public interface ICreditCardProvider
{
	ITransactionResult Process(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingRecurringMembershipSale, long? checkoutSessionId, byte platformTypeId, string sessionId = null);
}
