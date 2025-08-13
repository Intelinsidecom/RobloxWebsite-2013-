namespace Roblox.Platform.Chat;

internal interface IRawPlainTextMessage : IRawChatMessage
{
	string Over13Content { get; set; }

	string Under13Content { get; set; }
}
