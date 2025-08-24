using System;
using System.Collections.Generic;
using Roblox.EventLog;

namespace Roblox.Billing;

public interface IWindowsStorePaymentProvider
{
	void SubmitTransaction(IPurchaser purchaser, IEnumerable<Guid> transactionIds, string receipt, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, IWindowsStoreVerificationClient receiptVerifier, ILogger logger = null);
}
