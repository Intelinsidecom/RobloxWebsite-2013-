namespace Roblox.Platform.RealTimeNotificationspublic {
    interface IUserRealTimeActivityMonitor

{
	void RecordUserRealTimeConnectionActive(long userId);

	bool IsUserActiveNow(long userId);

	bool HasUserBeenActiveRecently(long userId);
}


}
