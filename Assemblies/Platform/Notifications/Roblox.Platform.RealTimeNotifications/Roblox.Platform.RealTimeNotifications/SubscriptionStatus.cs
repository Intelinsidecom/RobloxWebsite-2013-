using System;
using System.Collections.Generic;

namespace Roblox.RealTimeNotifications;

internal class SubscriptionStatus<TKey, TSubscriberId>
{
	private readonly TKey _Key;

	private readonly HashSet<TSubscriberId> _Consumers;

	public TKey Key => _Key;

	public ISubscriptionResult SubscriptionResult { get; set; }

	public HashSet<TSubscriberId> Consumers => _Consumers;

	public DateTime SubscriptionTestDue { get; set; }

	public SubscriptionStatus(TKey key)
	{
		_Key = key;
		_Consumers = new HashSet<TSubscriberId>();
	}
}
