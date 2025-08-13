namespace Roblox.Platform.Chat;

internal class PlainTextMessageByUserValidationData : ChatMessageByUserValidationData, IPlaintextMessageByUserValidationData, IChatMessageByUserValidationData, IChatMessageValidationData
{
	public bool IsMoreStrictlyModeratedForSomeRecipients { get; set; }
}
