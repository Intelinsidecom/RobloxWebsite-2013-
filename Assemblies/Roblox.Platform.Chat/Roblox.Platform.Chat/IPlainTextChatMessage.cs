namespace Roblox.Platform.Chat;

public interface IPlainTextChatMessage : IChatMessage
{
	/// <summary>
	/// The content of the message, filtered specifically for the viewer requested this message
	/// </summary>
	string ContentForViewer { get; set; }
}
