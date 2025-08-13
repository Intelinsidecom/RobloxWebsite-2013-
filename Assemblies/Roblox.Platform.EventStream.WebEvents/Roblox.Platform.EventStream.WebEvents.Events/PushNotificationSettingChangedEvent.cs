using System;

namespace Roblox.Platform.EventStream.WebEvents.Events;

public class PushNotificationSettingChangedEvent : WebEventBase
{
	private const string _Name = "pushNotificationSettingsChanged";

	private const string _IsEnabled = "enabled";

	private const string _ReceiverDestinationType = "platformTypeId";

	private const string _ReceiverDestinationId = "destinationId";

	private const string _EventTime = "lt";

	public PushNotificationSettingChangedEvent(IEventStreamer eventStreamer, PushNotificationSettingChangedEventArgs pushNotificationSettingChangedEventArgs)
		: base(eventStreamer, "pushNotificationSettingsChanged", pushNotificationSettingChangedEventArgs)
	{
		if (!pushNotificationSettingChangedEventArgs.UserId.HasValue)
		{
			throw new ArgumentException(string.Format("{0}.UserId must be defined", "pushNotificationSettingChangedEventArgs"));
		}
		AddEventArg("lt", pushNotificationSettingChangedEventArgs.EventTime.ToString());
		AddEventArg("enabled", pushNotificationSettingChangedEventArgs.IsEnabled.ToString());
		AddEventArg("platformTypeId", pushNotificationSettingChangedEventArgs.ReceiverDestinationType);
		AddEventArg("destinationId", pushNotificationSettingChangedEventArgs.ReceiverDestinationId);
	}
}
