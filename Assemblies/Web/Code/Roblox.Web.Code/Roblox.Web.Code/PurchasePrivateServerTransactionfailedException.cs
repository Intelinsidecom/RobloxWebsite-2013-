using System;
using Roblox.Marketplace.Client;

namespace Roblox.Web.Code;

/// <summary>
/// Exception thrown if transaction failed when purchase the VIP server
/// </summary>
public class PurchasePrivateServerTransactionfailedException : Exception
{
	public TransactionStatus TransactionStatus { get; private set; }

	public PurchasePrivateServerTransactionfailedException(TransactionStatus transactionStatus)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		TransactionStatus = transactionStatus;
	}
}
