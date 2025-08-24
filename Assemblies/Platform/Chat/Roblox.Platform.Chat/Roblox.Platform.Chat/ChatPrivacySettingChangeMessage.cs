using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Chat;

internal class ChatPrivacySettingChangeMessage : UserNotificationMessageBase
{
	public override string Type { get; set; }

	public ChatPrivacySettingChangeMessage(ChatPrivacySettingChangeMessageType chatPrivacySettingChangeMessageType)
	{
		Type = chatPrivacySettingChangeMessageType.ToString();
	}
}
