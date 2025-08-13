using System;

namespace Roblox.TransactionEvents;

/// <summary>
/// An interface for a TransactionStreamer, used to stream events with Robux transactions.
/// </summary>
public interface ITransactionStreamer
{
	/// <summary>
	/// Streams a transaction event.
	/// </summary>
	/// <param name="eventType">The name of the event we're streaming.</param>
	/// <param name="originTypeId">The sender's type id</param>
	/// <param name="originId">The sender's id</param>
	/// <param name="targetTypeId">The target's type id</param>
	/// <param name="targetId">The target's id</param>
	/// <param name="contentTypeId">Content type id for txn</param>
	/// <param name="amount">The amount of robux being transferred.</param>
	/// <param name="robuxBalanceBeforePurchase">The user's balance before the transfer.</param>
	/// <param name="acquisitionType">The transaction origin type</param>
	/// <param name="typeOfTransaction">Which economy it's in</param>
	/// <param name="created">The time at which the event was created</param>
	/// <param name="paymentId">The payment id. This can be empty.</param>
	/// <param name="saleId">The sale id. can be empty.</param>
	void StreamTransactionEvent(string eventType, UserType originTypeId, string originId, UserType targetTypeId, string targetId, ContentType contentTypeId, long amount, long robuxBalanceBeforePurchase, byte acquisitionType, string typeOfTransaction, DateTime created, long? paymentId = null, long? saleId = null);
}
