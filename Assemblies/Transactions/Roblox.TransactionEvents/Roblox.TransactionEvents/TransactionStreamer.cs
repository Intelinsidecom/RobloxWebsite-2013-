using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.EventStream;

namespace Roblox.TransactionEvents;

public class TransactionStreamer : ITransactionStreamer
{
	private readonly IEventStreamer _EventStreamer;

	private readonly ILogger _Logger;

	private readonly string _EventTarget = "RobuxTransactionAudit";

	public TransactionStreamer(IEventStreamer eventStreamer, ILogger logger)
	{
		_EventStreamer = eventStreamer ?? throw new ArgumentNullException("eventStreamer");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	public void StreamTransactionEvent(string eventType, UserType originTypeId, string originId, UserType targetTypeId, string targetId, ContentType contentTypeId, long amount, long robuxBalanceBeforePurchase, byte acquisitionType, string typeOfTransaction, DateTime created, long? paymentId = null, long? saleId = null)
	{
		List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
		int num = (int)originTypeId;
		list.Add(new KeyValuePair<string, string>("originTypeId", num.ToString()));
		list.Add(new KeyValuePair<string, string>("originId", originId));
		num = (int)targetTypeId;
		list.Add(new KeyValuePair<string, string>("targetTypeId", num.ToString()));
		list.Add(new KeyValuePair<string, string>("targetId", targetId));
		num = (int)contentTypeId;
		list.Add(new KeyValuePair<string, string>("contentTypeId", num.ToString()));
		list.Add(new KeyValuePair<string, string>("amount", amount.ToString()));
		list.Add(new KeyValuePair<string, string>("robuxBalanceBeforePurchase", robuxBalanceBeforePurchase.ToString()));
		list.Add(new KeyValuePair<string, string>("acquisitionType", acquisitionType.ToString()));
		list.Add(new KeyValuePair<string, string>("paymentId", (!paymentId.HasValue) ? string.Empty : paymentId.ToString()));
		list.Add(new KeyValuePair<string, string>("saleId", (!saleId.HasValue) ? string.Empty : saleId.ToString()));
		list.Add(new KeyValuePair<string, string>("typeOfTransaction", typeOfTransaction));
		list.Add(new KeyValuePair<string, string>("created", created.ToString()));
		List<KeyValuePair<string, string>> eventParams = list;
		try
		{
			_EventStreamer.StreamEvent(_EventTarget, eventType, eventParams, null, isTrustedSource: true);
		}
		catch (Exception e)
		{
			_Logger.Error($"Event {eventType} failed to stream. Exception: {e}");
		}
	}
}
