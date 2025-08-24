using System;
using System.Collections.Generic;

namespace Roblox.Billing;

public interface IWindowsStoreVerificationClient
{
	/// <summary>
	/// Verifies that the supplied XML is a valid receipt, authenticates it, and verifies that it represents a transaction with the correct products.
	/// </summary>
	IEnumerable<WindowsStorePayment> VerifyReceiptAuthenticity(IPurchaser purchaser, string receiptXml, IEnumerable<Guid> transactionIds);
}
