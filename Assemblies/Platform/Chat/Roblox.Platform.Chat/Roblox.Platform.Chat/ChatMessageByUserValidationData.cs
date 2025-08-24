namespace Roblox.Platform.Chat;

internal class ChatMessageByUserValidationData : ChatMessageValidationData, IChatMessageByUserValidationData, IChatMessageValidationData
{
	public bool IsRealTimeConnected { get; set; }
}
