namespace Roblox.Platform.Chat;

internal interface IPlaintextMessageByUserValidationData : IChatMessageByUserValidationData, IChatMessageValidationData
{
	bool IsMoreStrictlyModeratedForSomeRecipients { get; set; }
}
