namespace Roblox.Platform.Chat;

public interface IConversationTitle
{
	string TitleForViewer { get; }

	bool IsDefaultTitle { get; }
}
