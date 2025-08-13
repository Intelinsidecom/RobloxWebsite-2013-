using System;
using Amazon.DynamoDBv2;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Chat.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;
using Roblox.TextFilter.Client;
using Roblox.Time;

namespace Roblox.Platform.Chat;

public class ChatMessageSenderFactory
{
	private static Roblox.Common.Func<IChatRedisClients, IAmazonDynamoDB, IUserFactory, Predicate<long>, ILogger, ITextFilterClientV2, IUniverseFactory, ChatMessageSender> _ChatMessageSenderCreator;

	static ChatMessageSenderFactory()
	{
		_ChatMessageSenderCreator = delegate(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, IUserFactory userFactory, Predicate<long> userHasConnectedToRealTimeRecently, ILogger logger, ITextFilterClientV2 textFilterClientV2, IUniverseFactory universeFactory)
		{
			InstantProvider instantProvider = new InstantProvider();
			ParticipantUtilities participantUtilities = new ParticipantUtilities(userFactory);
			IMessageDataAccessor messageDataAccessor = MessageDataAccessorFactory.GetMessageDataAccessor(chatRedisClients, dynamoDbClient, logger, instantProvider);
			IConversationDataAccessor conversationDataAccessor = ConversationDataAccessorFactory.GetConversationDataAccessor(chatRedisClients.ChatConversationRedisClient, logger, universeFactory);
			Settings @default = Settings.Default;
			ContentValidator contentValidator = new ContentValidator(new ContentValidationRules(participantUtilities), textFilterClientV2, participantUtilities);
			ChatMessageRemediator chatMessageRemediator = new ChatMessageRemediator(conversationDataAccessor, messageDataAccessor, contentValidator, userFactory, participantUtilities, logger, @default);
			return new ChatMessageSender(logger, conversationDataAccessor, messageDataAccessor, participantUtilities, instantProvider, @default, new ChatMessagePreProcessorFactory(logger, chatRedisClients.ChatConversationRedisClient, universeFactory, userHasConnectedToRealTimeRecently, userFactory, textFilterClientV2), new ChatMessagePostProcessorFactory(chatMessageRemediator), new DecoratorWhitelistValidator(), new DecoratorValidatorFactory(messageDataAccessor));
		};
	}

	public static ChatMessageSender GetChatMessageSenderFactory(IChatRedisClients chatRedisClients, IAmazonDynamoDB dynamoDbClient, IUserFactory userFactory, Predicate<long> userHasConnectedToRealTimeRecently, ILogger logger, ITextFilterClientV2 textFilterClientV2, IUniverseFactory universeFactory)
	{
		return _ChatMessageSenderCreator(chatRedisClients, dynamoDbClient, userFactory, userHasConnectedToRealTimeRecently, logger, textFilterClientV2, universeFactory);
	}
}
