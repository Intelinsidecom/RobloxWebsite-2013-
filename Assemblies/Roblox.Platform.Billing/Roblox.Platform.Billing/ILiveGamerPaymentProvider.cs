using System.Collections.Generic;
using Roblox.LiveGamer;

namespace Roblox.Platform.Billing;

public interface ILiveGamerPaymentProvider
{
	LiveGamerInitTransactionResult Begin(ICollection<LiveGamerInitSellLineItem> lineItems, byte platformTypeId);

	LiveGamerTransactionResult Finalize(LiveGamerTransactionInfo transactionInfo);
}
