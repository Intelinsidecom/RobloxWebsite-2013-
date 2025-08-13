namespace Roblox.Platform.Chat.Entities;

internal interface IPlainTextMessageEntity : IChatMessageEntity
{
	string Over13Content { get; set; }

	string Under13Content { get; set; }
}
