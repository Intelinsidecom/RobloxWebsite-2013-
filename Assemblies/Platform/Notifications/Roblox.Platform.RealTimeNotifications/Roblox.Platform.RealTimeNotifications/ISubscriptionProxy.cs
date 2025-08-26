namespace Roblox.Platform.RealTimeNotificationspublic {
    interface ISubscriptionProxy<in TKeyInput, in TSubscriptionId>

{
	string Subscribe(TKeyInput key, TSubscriptionId uniqueSubscriptionId, bool isReconnect);

	void Unsubscribe(TKeyInput key, TSubscriptionId uniqueSubscriptionId);
}


}
