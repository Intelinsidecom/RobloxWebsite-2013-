using System;
using Roblox.EventLog;
using Roblox.Time;

namespace Roblox.Platform.Chat;

internal static class ChatMessageParserFactoryCreator
{
	private static readonly Func<IInstantProvider, IEphemeralChatMessageParserFactory> _EphemeralParserFactoryCreator;

	private static readonly Func<ILogger, IPersistentChatMessageParserFactory> _PersistentParserFactoryCreator;

	private static readonly Func<ILogger, IChatEventParserFactory> _ChatEventParserFactoryCreator;

	static ChatMessageParserFactoryCreator()
	{
		_EphemeralParserFactoryCreator = (IInstantProvider instantProvider) => new EphemeralChatMessageParserFactory(instantProvider);
		_PersistentParserFactoryCreator = (ILogger logger) => new PersistentChatMessageParserFactory(logger);
		_ChatEventParserFactoryCreator = (ILogger logger) => new ChatEventParserFactory(logger);
	}

	public static IEphemeralChatMessageParserFactory GetEphemeralChatMessageParserFactory(IInstantProvider instantProvider)
	{
		return _EphemeralParserFactoryCreator(instantProvider);
	}

	public static IPersistentChatMessageParserFactory GetPersistentChatMessageParserFactory(ILogger logger)
	{
		return _PersistentParserFactoryCreator(logger);
	}

	public static IChatEventParserFactory GetChatEventParserFactory(ILogger logger)
	{
		return _ChatEventParserFactoryCreator(logger);
	}
}
