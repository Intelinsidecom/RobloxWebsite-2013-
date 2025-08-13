using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Chat;

internal class ChatFloodCheckerFactory : IChatFloodCheckerFactory
{
	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	internal ChatFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger, ISettings settings)
	{
		_FloodCheckerFactory = floodCheckerFactory;
		_Logger = logger;
		_Settings = settings;
	}

	public IFloodChecker GetFloodCheckerForSetConversationUniverse(string category, IUser currentUser)
	{
		return _FloodCheckerFactory.GetFloodChecker(category, $"SetConversationUniverse_User:{currentUser.Id}", () => _Settings.SetConversationUniverseFloodCheckLimit, () => _Settings.SetConversationUniverseFloodCheckExpiry, () => _Settings.SetConversationUniverseFloodCheckEnabled, () => false, _Logger);
	}

	public IFloodChecker GetFloodCheckerForUpdateUserTypingStatus(string category, IUser currentUser)
	{
		return _FloodCheckerFactory.GetFloodChecker(category, $"UpdateUserTypingStatus_User:{currentUser.Id}", () => _Settings.UpdateUserTypingStatusFloodCheckLimit, () => _Settings.UpdateUserTypingStatusFloodCheckExpiry, () => _Settings.UpdateUserTypingStatusFloodCheckEnabled, () => false, _Logger);
	}
}
