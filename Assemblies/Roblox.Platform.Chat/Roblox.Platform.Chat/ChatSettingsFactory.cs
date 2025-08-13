using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat;

public class ChatSettingsFactory : IChatSettingsFactory
{
	public int GetMaximumConversationTitleLength()
	{
		return Settings.Default.MaxConversationTitleLength;
	}
}
