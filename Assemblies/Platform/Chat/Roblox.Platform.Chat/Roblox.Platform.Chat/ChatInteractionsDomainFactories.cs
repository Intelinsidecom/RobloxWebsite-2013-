using System;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Social;
using Roblox.Platform.Universes;
using Roblox.Redis;

namespace Roblox.Platform.Chat;

public class ChatInteractionsDomainFactories
{
	private readonly IChatInteractionsFactory _ChatInteractionsFactory;

	private readonly IChatInteractionsBuilder _ChatInteractionsBuilder;

	public ChatInteractionsDomainFactories(IRedisClient chatConversationsRedisClient, IRedisClient chatInteractionsRedisClient, IFriendshipFactory friendshipFactory, IUserFactory userFactory, IUniverseFactory universeFactory, ILogger logger)
	{
		if (chatConversationsRedisClient == null)
		{
			throw new ArgumentNullException("chatConversationsRedisClient");
		}
		if (chatInteractionsRedisClient == null)
		{
			throw new ArgumentNullException("chatInteractionsRedisClient");
		}
		if (universeFactory == null)
		{
			throw new ArgumentNullException("universeFactory");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		if (friendshipFactory == null)
		{
			throw new ArgumentNullException("friendshipFactory");
		}
		ParticipantUtilities participantUtilities = new ParticipantUtilities(userFactory);
		IConversationDataAccessor conversationDataAccessor = ConversationDataAccessorFactory.GetConversationDataAccessor(chatConversationsRedisClient, logger, universeFactory);
		ChatInteractionsAccessor chatInteractionsAccessor = new ChatInteractionsAccessor(conversationDataAccessor, chatInteractionsRedisClient, participantUtilities, friendshipFactory, userFactory, logger);
		_ChatInteractionsFactory = new ChatInteractionsFactory(chatInteractionsAccessor, participantUtilities);
		_ChatInteractionsBuilder = new ChatInteractionsBuilder(conversationDataAccessor, chatInteractionsAccessor, participantUtilities, friendshipFactory, logger);
	}

	public IChatInteractionsFactory GetChatInteractionsFactory()
	{
		return _ChatInteractionsFactory;
	}

	public IChatInteractionsBuilder GetChatInteractionsBuilder()
	{
		return _ChatInteractionsBuilder;
	}
}
