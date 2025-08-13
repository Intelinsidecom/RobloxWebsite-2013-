using Roblox.EventLog;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat.Events;

public class ChatPrivacySettingsChangeHandler
{
	private readonly ChatUserNotificationPublisher _RealtimeNotificationPublisher;

	public ChatPrivacySettingsChangeHandler(ILogger logger, IUserFactory userFactory)
	{
		_RealtimeNotificationPublisher = new ChatUserNotificationPublisher(logger, userFactory);
	}

	public void HandleChatPrivacySettingsChanged(IUser affectedUser, bool hasBeenDisabled)
	{
		ChatPrivacySettingChangeMessageType messageType = (hasBeenDisabled ? ChatPrivacySettingChangeMessageType.ChatDisabled : ChatPrivacySettingChangeMessageType.ChatEnabled);
		_RealtimeNotificationPublisher.PublishUserPrivacySettingsChanged(affectedUser, messageType);
	}
}
