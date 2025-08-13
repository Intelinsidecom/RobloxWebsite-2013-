using System;

namespace Roblox.RealTimeNotifications;

public interface ISubscriber<TKeyInput, TPublishMessage>
{
	ISubscriptionResult Subscribe(TKeyInput key, Action<string, TPublishMessage> successCallback, Action<Exception> errorCallback = null);

	bool IsSubscribed(string key);

	void SubscribeToServerDisconnect(TKeyInput key, Action<string, string> onConnectionFail);

	void Unsubscribe(ISubscriptionResult subscriptionResult);

	string KeyToChannelName(TKeyInput input);

	TKeyInput ChannelNameToKey(string channelName);
}
