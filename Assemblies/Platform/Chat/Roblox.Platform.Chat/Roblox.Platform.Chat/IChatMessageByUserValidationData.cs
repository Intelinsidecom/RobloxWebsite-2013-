namespace Roblox.Platform.Chat;

internal interface IChatMessageByUserValidationData : IChatMessageValidationData
{
	bool IsRealTimeConnected { get; set; }
}
